namespace WindowsFormsApp1
{
    partial class RoadForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblMaxDecrease = new System.Windows.Forms.TextBox();
            this.lblMinDecrease = new System.Windows.Forms.TextBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-10, 1118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(2647, 340);
            this.dataGridView.TabIndex = 0;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(2, 67);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(2142, 1045);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(2263, 354);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(357, 46);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Открыть таблицу из файла";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(2273, 999);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(347, 47);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Прогнозировать";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblMaxDecrease
            // 
            this.lblMaxDecrease.Location = new System.Drawing.Point(59, 12);
            this.lblMaxDecrease.Name = "lblMaxDecrease";
            this.lblMaxDecrease.Size = new System.Drawing.Size(899, 31);
            this.lblMaxDecrease.TabIndex = 5;
            // 
            // lblMinDecrease
            // 
            this.lblMinDecrease.Location = new System.Drawing.Point(994, 12);
            this.lblMinDecrease.Name = "lblMinDecrease";
            this.lblMinDecrease.Size = new System.Drawing.Size(959, 31);
            this.lblMinDecrease.TabIndex = 6;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(2263, 284);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(357, 33);
            this.comboBoxRegion.TabIndex = 7;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(2500, 923);
            this.numericYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(120, 31);
            this.numericYears.TabIndex = 8;
            this.numericYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2711, 1500);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.lblMinDecrease);
            this.Controls.Add(this.lblMaxDecrease);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Name = "RoadForm";
            this.Text = "Данные о дорогах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.TextBox lblMaxDecrease;
        private System.Windows.Forms.TextBox lblMinDecrease;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.NumericUpDown numericYears;
    }
}