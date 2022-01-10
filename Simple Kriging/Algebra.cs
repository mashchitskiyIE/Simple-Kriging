using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Kriging
{
    static class Algebra
    {
        public static double[,] InverseMatrix_LUDivision(double[,] m)
        {
            int n = m.GetLength(0);
            double[,] L = new double[n, n], U = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    U[0, i] = m[0, i];
                    L[i, 0] = m[i, 0] / U[0, 0];
                    double sum = 0;
                    for (int k = 0; k < i; k++)
                    {
                        sum += L[i, k] * U[k, j];
                    }
                    U[i, j] = m[i, j] - sum;
                    if (i > j)
                    {
                        L[j, i] = 0;
                    }
                    else
                    {
                        sum = 0;
                        for (int k = 0; k < i; k++)
                        {
                            sum += L[j, k] * U[k, i];
                        }
                        L[j, i] = (m[j, i] - sum) / U[i, i];
                    }
                }
            }
            double[,] ans = new double[n, n];
            for (int k = 0; k < n; k++)
            {
                double[] v = new double[n];
                for (int i = 0; i < n; i++) v[i] = i == k ? 1 : 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++) v[i] -= L[i, j] * v[j];
                    v[i] = v[i] / L[i, i];
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = n - 1; j > i; j--) v[i] -= U[i, j] * v[j];
                    ans[i,k] = v[i] = v[i] / U[i, i];
                }
            }
            return ans;
        }

        public static double[] MultiplyMatrixByVector(double[,] m, double[] v)
        {
            double[] ans = new double[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++) { ans[i] = 0; for (int j = 0; j < v.Length; j++) ans[i] += m[i, j] * v[j]; }
            return ans;
        }

        public static double[,] MultiplyMatrixByMatrix(double[,] ml, double[,] mr)
        {
            double[,] ans = new double[ml.GetLength(0), mr.GetLength(1)];
            for (int i = 0; i < ml.GetLength(0); i++) for (int j = 0; j < mr.GetLength(1); j++) { ans[i, j] = 0; for (int k = 0; k < ml.GetLength(0); k++) ans[i, j] += ml[i, k] * mr[k, j]; }
            return ans;
        }

    }
}
