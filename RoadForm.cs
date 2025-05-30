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
                comboBoxRegion.Items.Add(dataRow[0]?.ToString());
            }

            workbook.Close(false);
            excelApp.Quit();

            if (comboBoxRegion.Items.Count > 0)
            {
                comboBoxRegion.SelectedIndex = 0; // Выбрать первый регион по умолчанию
            }
        }
        // Вывод таблицы
        private void DisplayData()
        {
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        // Рисование графика
        private void PlotCharts()
        {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Title = "Год";
            chart.ChartAreas[0].AxisY.Title = "Доля плохих дорог (%)";
            chart.ChartAreas[0].AxisX.Interval = 1;

            // Выбор региона для графика
            string selectedRegion = comboBoxRegion.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRegion)) return;

            DataRow[] rows = dataTable.Select($"{dataTable.Columns[0].ColumnName} = '{selectedRegion.Replace("'", "''")}'");
            if (rows.Length == 0) return;

            var row = rows[0];
            var series = new Series(selectedRegion)
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
        // Изменение графика по выбранному региону
        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotCharts();
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

            IbIMaxDecrease.Text = $"Максимальное уменьшение: {maxDecreaseRegion} на {maxDecrease:F2}%";
            IbIMinDecrease.Text = $"Минимальное уменьшение: {minDecreaseRegion} на {minDecrease:F2}%";
        }

        // Кнопка прогнозирования
        // Кнопка прогнозирования
        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0) return;

            int years = (int)numericYears.Value;
            int windowSize = (int)numericWindowSize.Value;

            PredictAndPlot(years, windowSize);
        }
        // Рисование графика прогноза
        private void PredictAndPlot(int yearsToPredict, int windowSize)
        {
            // Очистка для обновления графика
            chart.Series.Clear();

            string selectedRegion = comboBoxRegion.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRegion)) return;

            DataRow[] rows = dataTable.Select($"{dataTable.Columns[0].ColumnName} = '{selectedRegion.Replace("'", "''")}'");
            if (rows.Length == 0) return;

            DataRow row = rows[0];
            var values = new List<double>();
            var series = new Series(selectedRegion)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            List<int> years = new List<int>();
            for (int i = 1; i < dataTable.Columns.Count; i++)
            {
                if (double.TryParse(row[i].ToString(), out double value) &&
                    int.TryParse(dataTable.Columns[i].ColumnName, out int year))
                {
                    values.Add(value);
                    years.Add(year);
                    series.Points.AddXY(year, value);
                }
            }

            chart.Series.Add(series);

            // Прогнозирование
            var predictedValues = MovingAverageExtrapolation(values, yearsToPredict, windowSize);
            var predictionSeries = new Series($"{selectedRegion} (прогноз)")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Red,
                BorderDashStyle = ChartDashStyle.Dash
            };
            // Выбор последнего года и прорисовка точек графика прогноза
            int lastYear = years.Last();
            double lastValue = values.Last();
            foreach (var (prediction, index) in predictedValues.Select((val, idx) => (val, idx)))
            {
                int futureYear = lastYear + index + 1;
                predictionSeries.Points.AddXY(futureYear, prediction);
            }

            chart.Series.Add(predictionSeries);

            // Вывод значения последнего года прогноза
            if (predictedValues.Count > 0)
            {
                int finalYear = lastYear + predictedValues.Count;
                double finalValue = predictedValues.Last();
                textBoxPrediction.Text = $"Согласно прогнозу в {finalYear} году: {finalValue:F2}%";
            }
            else
            {
                textBoxPrediction.Text = "Недостаточно данных для прогноза.";
            }
        }
        // Функция прогнозирования методом скользящей средней
        private List<double> MovingAverageExtrapolation(List<double> data, int yearsToPredict, int windowSize)
        {
            var predicted = new List<double>();

            // Копия исходных + будут добавляться прогнозные значения
            var extendedData = new List<double>(data);

            for (int i = 0; i < yearsToPredict; i++)
            {
                if (extendedData.Count < windowSize)
                {
                    // если данных меньше, чем размер окна — нельзя прогнозировать
                    break;
                }

                // Последние n значений
                var lastWindow = extendedData.Skip(extendedData.Count - windowSize).Take(windowSize).ToList();
                double forecast = lastWindow.Average();

                predicted.Add(forecast);
                extendedData.Add(forecast);
            }

            return predicted;
        }
    }
}