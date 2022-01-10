using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Simple_Kriging
{
    public struct tdPoint
    {
        public readonly double x, y, Value;

        public tdPoint(double x, double y, double Value)
        {
            this.x = x;
            this.y = y;
            this.Value = Value;
        }
    }

    public partial class MainForm : Form
    {
        private List<tdPoint> V;

        public MainForm()
        {
            InitializeComponent();
            CovarianceModelComboBox.SelectedIndex = 1;
        }

        private void LoadAndCalculateButton_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                CultureInfo ci = CultureInfo.CreateSpecificCulture("en-GB");
                V = new List<tdPoint>();
                string[] lines = File.ReadAllLines(OFD.FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] cols = lines[i].Split('\t');
                    V.Add(new tdPoint(double.Parse(cols[1], ci), double.Parse(cols[2], ci), double.Parse(cols[3], ci)));
                }
                //Считываем данные о сетке, создаем и инициализируем соответствующую переменную
                ci = CultureInfo.CurrentCulture;
                int Nx = int.Parse(NxTextBox.Text, ci), Ny = int.Parse(NyTextBox.Text, ci);
                double Xmin = double.Parse(XminTextBox.Text, ci), Xmax = double.Parse(XmaxTextBox.Text, ci), Ymin = double.Parse(YminTextBox.Text, ci), Ymax = double.Parse(YmaxTextBox.Text, ci);
                double Zmin = V.Min(a => a.Value), Zmax = V.Max(a => a.Value);
                double Xstep = (Xmax - Xmin) / (Nx + 1), Ystep = (Ymax - Ymin) / (Ny + 1);
                tdPoint[,] grid = new tdPoint[Ny, Nx];
                //рассчитываем среднее значение по карте
                double meanValue = V.Sum(a => a.Value) / V.Count;
                //рассчитываем матрицу расстояний между известными точками
                double nugget = 0, psill = 1, range = double.Parse(RangeTextBox.Text, ci);
                double[,] dist = new double[V.Count, V.Count];
                for (int i = 0; i < V.Count; i++)
                {
                    for (int j = 0; j < V.Count; j++)
                    {
                        dist[i, j] = Math.Sqrt(Math.Pow(V[i].x - V[j].x, 2) + Math.Pow(V[i].y - V[j].y, 2));
                    }
                }
                //рассчитываем матрицу ковариаций
                int ModelN = CovarianceModelComboBox.SelectedIndex;
                this.Enabled = false;
                WaitForm WF = new WaitForm("Идет формирование grd-файла");
                WF.InfoLabel.Text = "I hate waiting...";
                WF.Show();
                Task CalculationTask = new Task(() =>
                    {
                        //рассчитываем матрицу ковариаций
                        double[,] K;
                        switch (ModelN)
                        {
                            case 0: { K = Covariation.Spherical(dist, nugget, psill, range); break; }
                            case 1: { K = Covariation.Exponential(dist, nugget, psill, range); break; }
                            default: { return; }
                        }
                        //вычисляем обратную матрицу
                        double[,] K_ = Algebra.InverseMatrix_LUDivision(K);
                        //приступаем к распараллеленному заполнению сетки
                        Parallel.For(0, Ny, new ParallelOptions() { MaxDegreeOfParallelism = -1 }, i =>
                        {
                            double y = Ymin + Ystep * (i + 1);
                            for (int j = 0; j < Nx; j++)
                            {
                                double x = Xmin + Xstep * (j + 1);
                                //рассчитываем матрицу расстояний между точкой с неизвестным значением и известными точками
                                double[,] dist_point = new double[V.Count, 1];
                                for (int m = 0; m < V.Count; m++)
                                {
                                    dist_point[m, 0] = Math.Sqrt(Math.Pow(V[m].x - x, 2) + Math.Pow(V[m].y - y, 2));
                                }
                                //рассчитываем матрицу ковариаций для неизвестной точки
                                double[,] k;
                                switch (ModelN)
                                {
                                    case 0: { k = Covariation.Spherical(dist_point, nugget, psill, range); break; }
                                    case 1: { k = Covariation.Exponential(dist_point, nugget, psill, range); break; }
                                    default: { return; }
                                }
                                //рассчитываем веса простого кригинга
                                double[,] Weights = Algebra.MultiplyMatrixByMatrix(K_, k);
                                //прогнозируем значение в неизвестной точке
                                double Value = meanValue;
                                for (int m = 0; m < V.Count; m++) Value += Weights[m, 0] * (V[m].Value - meanValue);
                                //добавляем полученные данные в сетку
                                grid[i, j] = new tdPoint(x, y, Value);
                            }
                        });
                        //составляем content-массив для файла
                        lines = new string[grid.GetLength(0) + 5];
                        lines[0] = "DSAA";
                        lines[1] = string.Format("{0} {1}", Nx, Ny);
                        lines[2] = string.Format("{0} {1}", Xmin, Xmax);
                        lines[3] = string.Format("{0} {1}", Ymin, Ymax);
                        lines[4] = string.Format("{0} {1}", Zmin, Zmax);
                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                            string s = grid[i, 0].Value.ToString();
                            for (int j = 1; j < grid.GetLength(1); j++) s += string.Format("\t{0}", grid[i, j].Value);
                            lines[5 + i] = s;
                        }
                        //сохраняем файл
                        Invoke(new Action(() =>
                            {
                                WF.Close();
                                if (SFD.ShowDialog() == DialogResult.OK)File.WriteAllLines(SFD.FileName, lines, Encoding.ASCII);
                                this.Enabled = true;
                            }));
                    });
                CalculationTask.Start();
            }
        }
    }
}
