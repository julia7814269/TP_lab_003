namespace WindowsFormsApp1
{
    partial class TempForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblMaxDifference = new System.Windows.Forms.Label();
            this.lblMinDifference = new System.Windows.Forms.Label();
            this.numForecastDays = new System.Windows.Forms.NumericUpDown();
            this.numMovingAverage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForecast = new System.Windows.Forms.Button();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMovingAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 741);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(142, 71);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Загрузить файл";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // chartTemperature
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend5);
            this.chartTemperature.Location = new System.Drawing.Point(583, 12);
            this.chartTemperature.Name = "chartTemperature";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartTemperature.Series.Add(series5);
            this.chartTemperature.Size = new System.Drawing.Size(923, 478);
            this.chartTemperature.TabIndex = 3;
            this.chartTemperature.Text = "chart2";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(565, 722);
            this.dataGridView.TabIndex = 4;
            // 
            // lblMaxDifference
            // 
            this.lblMaxDifference.AutoSize = true;
            this.lblMaxDifference.Location = new System.Drawing.Point(580, 751);
            this.lblMaxDifference.Name = "lblMaxDifference";
            this.lblMaxDifference.Size = new System.Drawing.Size(131, 13);
            this.lblMaxDifference.TabIndex = 5;
            this.lblMaxDifference.Text = "Максимальный перепад";
            // 
            // lblMinDifference
            // 
            this.lblMinDifference.AutoSize = true;
            this.lblMinDifference.Location = new System.Drawing.Point(580, 777);
            this.lblMinDifference.Name = "lblMinDifference";
            this.lblMinDifference.Size = new System.Drawing.Size(125, 13);
            this.lblMinDifference.TabIndex = 6;
            this.lblMinDifference.Text = "Минимальный перепад";
            // 
            // numForecastDays
            // 
            this.numForecastDays.Location = new System.Drawing.Point(399, 751);
            this.numForecastDays.Name = "numForecastDays";
            this.numForecastDays.Size = new System.Drawing.Size(61, 20);
            this.numForecastDays.TabIndex = 7;
            // 
            // numMovingAverage
            // 
            this.numMovingAverage.Location = new System.Drawing.Point(399, 777);
            this.numMovingAverage.Name = "numMovingAverage";
            this.numMovingAverage.Size = new System.Drawing.Size(61, 20);
            this.numMovingAverage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 779);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Окно для вычислений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 753);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дни для прогноза";
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(466, 760);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(82, 30);
            this.btnForecast.TabIndex = 9;
            this.btnForecast.Text = "Прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // chartForecast
            // 
            chartArea6.Name = "ChartArea1";
            this.chartForecast.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartForecast.Legends.Add(legend6);
            this.chartForecast.Location = new System.Drawing.Point(583, 496);
            this.chartForecast.Name = "chartForecast";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartForecast.Series.Add(series6);
            this.chartForecast.Size = new System.Drawing.Size(923, 239);
            this.chartForecast.TabIndex = 2;
            this.chartForecast.Text = "chart1";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1363, 748);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(143, 70);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseMnemonic = false;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 824);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.numMovingAverage);
            this.Controls.Add(this.numForecastDays);
            this.Controls.Add(this.lblMinDifference);
            this.Controls.Add(this.lblMaxDifference);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.chartForecast);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.btnLoadData);
            this.Name = "TempForm";
            this.Text = "Данные о температуре";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMovingAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblMaxDifference;
        private System.Windows.Forms.Label lblMinDifference;
        private System.Windows.Forms.NumericUpDown numForecastDays;
        private System.Windows.Forms.NumericUpDown numMovingAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForecast;
        private System.Windows.Forms.Button buttonClose;
    }
}