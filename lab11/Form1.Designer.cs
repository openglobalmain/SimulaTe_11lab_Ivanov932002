namespace lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.numD = new System.Windows.Forms.NumericUpDown();
            this.expnum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MEr = new System.Windows.Forms.NumericUpDown();
            this.DEr = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numChi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мат. ожидание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дисперсия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число экспериментов";
            // 
            // numM
            // 
            this.numM.DecimalPlaces = 2;
            this.numM.Location = new System.Drawing.Point(157, 60);
            this.numM.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(120, 22);
            this.numM.TabIndex = 3;
            this.numM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numD
            // 
            this.numD.DecimalPlaces = 2;
            this.numD.Location = new System.Drawing.Point(157, 100);
            this.numD.Name = "numD";
            this.numD.Size = new System.Drawing.Size(120, 22);
            this.numD.TabIndex = 4;
            this.numD.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // expnum
            // 
            this.expnum.Location = new System.Drawing.Point(157, 141);
            this.expnum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.expnum.Name = "expnum";
            this.expnum.Size = new System.Drawing.Size(120, 22);
            this.expnum.TabIndex = 5;
            this.expnum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ошибка %";
            // 
            // MEr
            // 
            this.MEr.DecimalPlaces = 2;
            this.MEr.Enabled = false;
            this.MEr.Location = new System.Drawing.Point(315, 60);
            this.MEr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MEr.Name = "MEr";
            this.MEr.Size = new System.Drawing.Size(120, 22);
            this.MEr.TabIndex = 8;
            // 
            // DEr
            // 
            this.DEr.DecimalPlaces = 2;
            this.DEr.Enabled = false;
            this.DEr.Location = new System.Drawing.Point(315, 100);
            this.DEr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DEr.Name = "DEr";
            this.DEr.Size = new System.Drawing.Size(120, 22);
            this.DEr.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(499, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(631, 334);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(92, 204);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(204, 65);
            this.btCreate.TabIndex = 11;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chi-squared";
            // 
            // numChi
            // 
            this.numChi.DecimalPlaces = 2;
            this.numChi.Enabled = false;
            this.numChi.Location = new System.Drawing.Point(183, 307);
            this.numChi.Name = "numChi";
            this.numChi.Size = new System.Drawing.Size(120, 22);
            this.numChi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 452);
            this.Controls.Add(this.numChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DEr);
            this.Controls.Add(this.MEr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expnum);
            this.Controls.Add(this.numD);
            this.Controls.Add(this.numM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.NumericUpDown numD;
        private System.Windows.Forms.NumericUpDown expnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MEr;
        private System.Windows.Forms.NumericUpDown DEr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numChi;
    }
}

