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
            this.btnPredict = new System.Windows.Forms.Button();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrediction = new System.Windows.Forms.TextBox();
            this.numericWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 1122);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(2850, 457);
            this.dataGridView.TabIndex = 0;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 186);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(2850, 930);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(336, 54);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Открыть таблицу из файла";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // IbIMaxDecrease
            // 
            this.IbIMaxDecrease.Location = new System.Drawing.Point(956, 69);
            this.IbIMaxDecrease.Name = "IbIMaxDecrease";
            this.IbIMaxDecrease.Size = new System.Drawing.Size(1074, 31);
            this.IbIMaxDecrease.TabIndex = 3;
            // 
            // IbIMinDecrease
            // 
            this.IbIMinDecrease.Location = new System.Drawing.Point(956, 12);
            this.IbIMinDecrease.Name = "IbIMinDecrease";
            this.IbIMinDecrease.Size = new System.Drawing.Size(1074, 31);
            this.IbIMinDecrease.TabIndex = 4;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(2393, 120);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(389, 41);
            this.btnPredict.TabIndex = 5;
            this.btnPredict.Text = "Прогнозировать";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(12, 130);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(731, 33);
            this.comboBoxRegion.TabIndex = 7;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(2660, 70);
            this.numericYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(202, 31);
            this.numericYears.TabIndex = 8;
            this.numericYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxPrediction
            // 
            this.textBoxPrediction.Location = new System.Drawing.Point(956, 130);
            this.textBoxPrediction.Name = "textBoxPrediction";
            this.textBoxPrediction.Size = new System.Drawing.Size(1074, 31);
            this.textBoxPrediction.TabIndex = 10;
            // 
            // numericWindowSize
            // 
            this.numericWindowSize.Location = new System.Drawing.Point(2660, 12);
            this.numericWindowSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericWindowSize.Name = "numericWindowSize";
            this.numericWindowSize.Size = new System.Drawing.Size(202, 31);
            this.numericWindowSize.TabIndex = 9;
            this.numericWindowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2242, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите размер окна для расчёта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2242, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите количество лет для прогноза";
            // 
            // RoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2874, 1600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericWindowSize);
            this.Controls.Add(this.textBoxPrediction);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.btnPredict);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.Button btnOpenFile;
        private TextBox IbIMaxDecrease;
        private TextBox IbIMinDecrease;
        private Button btnPredict;
        private ComboBox comboBoxRegion;
        private NumericUpDown numericYears;
        private TextBox textBoxPrediction;
        private NumericUpDown numericWindowSize;
        private Label label1;
        private Label label2;
    }
}