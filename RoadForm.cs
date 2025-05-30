using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class RoadForm : Form
    {
        private DataTable dataTable;
        public RoadForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataGridView.DataSource = dataTable;
        }
        // Кнопка открытия файла
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Select Road Data File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadExcelData(openFileDialog.FileName);
                    DisplayData();
                    PlotCharts();
                    AnalyzeChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Загрузка данных из таблицы EXCEL
        private void LoadExcelData(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            dataTable.Clear();
            dataTable.Columns.Clear();

            // Добавление колонок
            for (int c = 1; c <= range.Columns.Count; c++)
            {
                string columnName = (range.Cells[1, c] as Excel.Range)?.Value?.ToString() ?? $"Column{c}";
                dataTable.Columns.Add(columnName);
            }

            // Добавление данных
            for (int r = 2; r <= range.Rows.Count; r++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int c = 1; c <= range.Columns.Count; c++)
                {
                    dataRow[c - 1] = (range.Cells[r, c] as Excel.Range)?.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            workbook.Close(false);
            excelApp.Quit();
        }
        // Вывод таблицы
        private void DisplayData()
        {
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        // Рисование графика
        private void PlotCharts()
        {
            // Настройки графика
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Title = "Год";
            chart.ChartAreas[0].AxisY.Title = "Доля плохих дорог (%)";
            chart.ChartAreas[0].AxisX.Interval = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                // Настрофка графика для нового региона
                string region = row[0].ToString();
                var series = new Series(region)
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2
                };
                // Добавление точек на график
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    if (double.TryParse(row[i].ToString(), out double value))
                    {
                        series.Points.AddXY(dataTable.Columns[i].ColumnName, value);
                    }
                }

                chart.Series.Add(series);
            }
        }
        // Функция анализа изменений
        private void AnalyzeChanges()
        {
            if (dataTable.Rows.Count == 0 || dataTable.Columns.Count < 2) return;

            string maxDecreaseRegion = "";
            double maxDecrease = double.MinValue;

            string minDecreaseRegion = "";
            double minDecrease = double.MaxValue;

            foreach (DataRow row in dataTable.Rows)
            {
                string region = row[0].ToString();

                if (!double.TryParse(row[1].ToString(), out double firstValue) ||
                    !double.TryParse(row[dataTable.Columns.Count - 1].ToString(), out double lastValue))
                    continue;

                // Расчёт изменения
                double change = firstValue - lastValue;

                // Сравнение с предыдущими и поиск наименьшего и наибольшего
                if (change > maxDecrease)
                {
                    maxDecrease = change;
                    maxDecreaseRegion = region;
                }

                if (change < minDecrease)
                {
                    minDecrease = change;
                    minDecreaseRegion = region;
                }
            }

            lblMaxDecrease.Text = $"Максимальное уменьшение: {maxDecreaseRegion} на {maxDecrease:F2}%";
            lblMinDecrease.Text = $"Минимальное уменьшение: {minDecreaseRegion} на {minDecrease:F2}%";
        }
    }
}
