using System.Windows.Forms;

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
            this.IbIMaxDecrease = new System.Windows.Forms.TextBox();
            this.IbIMinDecrease = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            this.btnOpenFile.Location = new System.Drawing.Point(2226, 67);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(357, 46);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Открыть таблицу из файла";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // IbIMaxDecrease
            // 
            this.IbIMaxDecrease.Location = new System.Drawing.Point(39, 15);
            this.IbIMaxDecrease.Name = "IbIMaxDecrease";
            this.IbIMaxDecrease.Size = new System.Drawing.Size(1074, 31);
            this.IbIMaxDecrease.TabIndex = 3;
            // 
            // IbIMinDecrease
            // 
            this.IbIMinDecrease.Location = new System.Drawing.Point(1185, 15);
            this.IbIMinDecrease.Name = "IbIMinDecrease";
            this.IbIMinDecrease.Size = new System.Drawing.Size(1074, 31);
            this.IbIMinDecrease.TabIndex = 4;
            // 
            // RoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2711, 1500);
            this.Controls.Add(this.IbIMinDecrease);
            this.Controls.Add(this.IbIMaxDecrease);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Name = "RoadForm";
            this.Text = "Данные о дорогах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.Button btnOpenFile;
        private TextBox IbIMaxDecrease;
        private TextBox IbIMinDecrease;
    }
}