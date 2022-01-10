namespace Simple_Kriging
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadAndCalculateButton = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CovarianceModelComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NxTextBox = new System.Windows.Forms.TextBox();
            this.NyTextBox = new System.Windows.Forms.TextBox();
            this.XminTextBox = new System.Windows.Forms.TextBox();
            this.XmaxTextBox = new System.Windows.Forms.TextBox();
            this.YminTextBox = new System.Windows.Forms.TextBox();
            this.YmaxTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.RangeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadAndCalculateButton
            // 
            this.LoadAndCalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.LoadAndCalculateButton, 6);
            this.LoadAndCalculateButton.Location = new System.Drawing.Point(3, 164);
            this.LoadAndCalculateButton.Name = "LoadAndCalculateButton";
            this.LoadAndCalculateButton.Size = new System.Drawing.Size(318, 39);
            this.LoadAndCalculateButton.TabIndex = 0;
            this.LoadAndCalculateButton.Text = "Загрузить и рассчитать";
            this.LoadAndCalculateButton.UseVisualStyleBackColor = true;
            this.LoadAndCalculateButton.Click += new System.EventHandler(this.LoadAndCalculateButton_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "txt-input|*.txt";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.LoadAndCalculateButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.CovarianceModelComboBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.NyTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.XminTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.XmaxTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.YminTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.YmaxTextBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.RangeTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NxTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CovarianceModelComboBox
            // 
            this.CovarianceModelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.CovarianceModelComboBox, 6);
            this.CovarianceModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CovarianceModelComboBox.FormattingEnabled = true;
            this.CovarianceModelComboBox.Items.AddRange(new object[] {
            "Сферическая",
            "Экспоненциальная"});
            this.CovarianceModelComboBox.Location = new System.Drawing.Point(97, 128);
            this.CovarianceModelComboBox.Name = "CovarianceModelComboBox";
            this.CovarianceModelComboBox.Size = new System.Drawing.Size(129, 21);
            this.CovarianceModelComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 6);
            this.label4.Location = new System.Drawing.Point(40, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Модель построения ковариационной матрицы";
            // 
            // NxTextBox
            // 
            this.NxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NxTextBox.Location = new System.Drawing.Point(3, 23);
            this.NxTextBox.Name = "NxTextBox";
            this.NxTextBox.Size = new System.Drawing.Size(48, 20);
            this.NxTextBox.TabIndex = 2;
            this.NxTextBox.Text = "99";
            this.NxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NyTextBox
            // 
            this.NyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NyTextBox.Location = new System.Drawing.Point(57, 23);
            this.NyTextBox.Name = "NyTextBox";
            this.NyTextBox.Size = new System.Drawing.Size(48, 20);
            this.NyTextBox.TabIndex = 2;
            this.NyTextBox.Text = "187";
            this.NyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XminTextBox
            // 
            this.XminTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XminTextBox.Location = new System.Drawing.Point(111, 23);
            this.XminTextBox.Name = "XminTextBox";
            this.XminTextBox.Size = new System.Drawing.Size(48, 20);
            this.XminTextBox.TabIndex = 2;
            this.XminTextBox.Text = "449963";
            this.XminTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XmaxTextBox
            // 
            this.XmaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XmaxTextBox.Location = new System.Drawing.Point(165, 23);
            this.XmaxTextBox.Name = "XmaxTextBox";
            this.XmaxTextBox.Size = new System.Drawing.Size(48, 20);
            this.XmaxTextBox.TabIndex = 2;
            this.XmaxTextBox.Text = "459763";
            this.XmaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YminTextBox
            // 
            this.YminTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YminTextBox.Location = new System.Drawing.Point(219, 23);
            this.YminTextBox.Name = "YminTextBox";
            this.YminTextBox.Size = new System.Drawing.Size(48, 20);
            this.YminTextBox.TabIndex = 2;
            this.YminTextBox.Text = "6491198";
            this.YminTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YmaxTextBox
            // 
            this.YmaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YmaxTextBox.Location = new System.Drawing.Point(273, 23);
            this.YmaxTextBox.Name = "YmaxTextBox";
            this.YmaxTextBox.Size = new System.Drawing.Size(48, 20);
            this.YmaxTextBox.TabIndex = 2;
            this.YmaxTextBox.Text = "6509798";
            this.YmaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nx";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ny";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ymin";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xmin";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ymax";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Xmax";
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "grd";
            this.SFD.Filter = "Surfer Grid|*.grd";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(115, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметр Range";
            // 
            // RangeTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RangeTextBox, 2);
            this.RangeTextBox.Location = new System.Drawing.Point(111, 81);
            this.RangeTextBox.Name = "RangeTextBox";
            this.RangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RangeTextBox.TabIndex = 4;
            this.RangeTextBox.Text = "100000";
            this.RangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 210);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Simple Kriging";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadAndCalculateButton;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CovarianceModelComboBox;
        private System.Windows.Forms.TextBox NxTextBox;
        private System.Windows.Forms.TextBox NyTextBox;
        private System.Windows.Forms.TextBox XminTextBox;
        private System.Windows.Forms.TextBox XmaxTextBox;
        private System.Windows.Forms.TextBox YminTextBox;
        private System.Windows.Forms.TextBox YmaxTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RangeTextBox;
    }
}

