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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblMaxDifference = new System.Windows.Forms.Label();
            this.lblMinDifference = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(583, 12);
            this.chartTemperature.Name = "chartTemperature";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(923, 722);
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
            this.lblMaxDifference.Location = new System.Drawing.Point(609, 751);
            this.lblMaxDifference.Name = "lblMaxDifference";
            this.lblMaxDifference.Size = new System.Drawing.Size(131, 13);
            this.lblMaxDifference.TabIndex = 5;
            this.lblMaxDifference.Text = "Максимальный перепад";
            // 
            // lblMinDifference
            // 
            this.lblMinDifference.AutoSize = true;
            this.lblMinDifference.Location = new System.Drawing.Point(609, 777);
            this.lblMinDifference.Name = "lblMinDifference";
            this.lblMinDifference.Size = new System.Drawing.Size(125, 13);
            this.lblMinDifference.TabIndex = 6;
            this.lblMinDifference.Text = "Минимальный перепад";
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 824);
            this.Controls.Add(this.lblMinDifference);
            this.Controls.Add(this.lblMaxDifference);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.btnLoadData);
            this.Name = "TempForm";
            this.Text = "Данные о температуре";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblMaxDifference;
        private System.Windows.Forms.Label lblMinDifference;
    }
}