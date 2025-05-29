using Excel = Microsoft.Office.Interop.Excel;
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

namespace WindowsFormsApp1
{
    public partial class TempForm : Form
    {
        private DataTable weatherData;
        private int forecastDays = 5; // Количество дней для прогноза 
        private int movingAverageWindow = 3; // Окно скользящего среднего
        public TempForm()
        {
            InitializeComponent();
            InitializeChart();
            InitializeForecastControls();
        }

        // Инициализция графиков
        private void InitializeChart()
        {
            // Инициализация основного графика
            chartTemperature.Series.Clear();
            chartTemperature.ChartAreas[0].AxisX.Title = "День месяца";
            chartTemperature.ChartAreas[0].AxisY.Title = "Температура (°C)";
            chartTemperature.ChartAreas[0].AxisX.Interval = 1;

            // Инициализация графика прогноза
            chartForecast.ChartAreas[0].AxisX.Title = "День прогноза";
            chartForecast.ChartAreas[0].AxisY.Title = "Температура (°C)";
            chartForecast.ChartAreas[0].AxisX.Interval = 1;
        }

        // Инициализация переменных для прогнозов
        private void InitializeForecastControls()
        {
            // Настройка NumericUpDown для выбора дней прогноза
            numForecastDays.Minimum = 1;
            numForecastDays.Maximum = 30;
            numForecastDays.Value = forecastDays;
            numForecastDays.ValueChanged += (s, e) => forecastDays = (int)numForecastDays.Value;

            // Настройка NumericUpDown для выбора окна скользящего среднего
            numMovingAverage.Minimum = 2;
            numMovingAverage.Maximum = 10;
            numMovingAverage.Value = movingAverageWindow;
            numMovingAverage.ValueChanged += (s, e) => movingAverageWindow = (int)numMovingAverage.Value;
        }

        // Кнопка "Загрузить файл"
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Выберите файл с данными о погоде"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadExcelData(openFileDialog.FileName);
                    DisplayData();
                    PlotTemperatureData();
                    CalculateTemperatureDifferences();
                    ClearForecast(); // Очищаем прогноз при загрузке новых данных
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка "Прогноз"
        private void btnForecast_Click(object sender, EventArgs e)
        {
            if (weatherData == null || weatherData.Rows.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (weatherData.Rows.Count < movingAverageWindow)
            {
                MessageBox.Show($"Для выбранного окна скользящего среднего ({movingAverageWindow}) недостаточно данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlotForecastData();
        }

        // Обработка данных из файла
        private void LoadExcelData(string filePath)
        {
            var excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            weatherData = new DataTable();

            // Добавляем колонки
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                string columnName = (range.Cells[1, i] as Excel.Range).Value2?.ToString() ?? $"Column{i}";
                weatherData.Columns.Add(columnName);
            }

            // Заполняем данные
            for (int i = 2; i <= range.Rows.Count; i++)
            {
                DataRow row = weatherData.NewRow();
                for (int j = 1; j <= range.Columns.Count; j++)
                {
                    var cell = range.Cells[i, j] as Excel.Range;
                    object value = cell.Value2;

                    if (value != null)
                    {
                        // Обработка дат
                        if (j == 1 && value is double)
                        {
                            DateTime date = DateTime.FromOADate((double)value);
                            row[j - 1] = date.ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            // Унификация числового формата
                            string strValue = value.ToString();
                            if (double.TryParse(strValue.Replace(",", "."), System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture, out double numValue))
                            {
                                row[j - 1] = numValue;
                            }
                            else
                            {
                                row[j - 1] = strValue;
                            }
                        }
                    }
                }
                weatherData.Rows.Add(row);
            }

            workbook.Close(false);
            excelApp.Quit();
        }

        // Отображение таблицы
        private void DisplayData()
        {
            dataGridView.DataSource = weatherData;
            dataGridView.AutoResizeColumns();
        }

        // Построение графиков температур на основе данных
        private void PlotTemperatureData()
        {
            chartTemperature.Series.Clear();

            // Серия для максимальной температуры
            Series maxTempSeries = new Series("Максимальная температура")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            // Серия для минимальной температуры
            Series minTempSeries = new Series("Минимальная температура")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2
            };

            // Серия для средней температуры
            Series avgTempSeries = new Series("Средняя температура")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                BorderWidth = 2
            };

            // Заполняем данные
            for (int i = 0; i < weatherData.Rows.Count; i++)
            {
                string day = weatherData.Rows[i]["Дата"].ToString().Split(' ')[0];
                double maxTemp = weatherData.Rows[i]["Максимальная температура"] is DBNull ? 0 :
                                Convert.ToDouble(weatherData.Rows[i]["Максимальная температура"]);
                double minTemp = weatherData.Rows[i]["Минимальная температура"] is DBNull ? 0 :
                                Convert.ToDouble(weatherData.Rows[i]["Минимальная температура"]);
                double avgTemp = weatherData.Rows[i]["Средняя температура"] is DBNull ? 0 :
                                Convert.ToDouble(weatherData.Rows[i]["Средняя температура"]);

                maxTempSeries.Points.AddXY(day, maxTemp);
                minTempSeries.Points.AddXY(day, minTemp);
                avgTempSeries.Points.AddXY(day, avgTemp);
            }

            chartTemperature.Series.Add(maxTempSeries);
            chartTemperature.Series.Add(minTempSeries);
            chartTemperature.Series.Add(avgTempSeries);
        }

        // Построение графика прогнозирования
        private void PlotForecastData()
        {
            chartForecast.Series.Clear();

            // Серия для прогноза средней температуры
            var forecastSeries = new Series("Прогноз средней температуры")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Purple,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                MarkerColor = Color.Purple
            };

            double[] avgTemps = weatherData.AsEnumerable()
                .Select(row => row["Средняя температура"] is DBNull ? 0 :
                               Convert.ToDouble(row["Средняя температура"]))
                .ToArray();

            // Добавляем последние фактические значения для плавного перехода
            int transitionPoints = Math.Min(3, weatherData.Rows.Count);
            for (int i = weatherData.Rows.Count - transitionPoints; i < weatherData.Rows.Count; i++)
            {
                string day = $"День {i + 1}";
                double temp = Convert.ToDouble(weatherData.Rows[i]["Средняя температура"]);
                forecastSeries.Points.AddXY(day, temp);
            }

            // Прогнозируем на forecastDays дней вперед
            for (int i = 0; i < forecastDays; i++)
            {
                double sum = 0;
                int startIndex = avgTemps.Length - movingAverageWindow;

                // Суммируем значения за последние movingAverageWindow дней
                for (int j = 0; j < movingAverageWindow; j++)
                {
                    sum += avgTemps[startIndex + j];
                }

                double forecastValue = sum / movingAverageWindow;

                // Добавляем прогнозируемое значение в массив для следующих итераций
                Array.Resize(ref avgTemps, avgTemps.Length + 1);
                avgTemps[avgTemps.Length - 1] = forecastValue;

                // Добавляем точку на график
                string dayLabel = $"Прогноз {i + 1}";
                forecastSeries.Points.AddXY(dayLabel, forecastValue);
            }

            chartForecast.Series.Add(forecastSeries);

            // Добавляем заголовок
            chartForecast.Titles.Clear();
            chartForecast.Titles.Add(new Title($"Прогноз на {forecastDays} дней (скользящее среднее за {movingAverageWindow} дня)",
                Docking.Top, new Font("Arial", 10, FontStyle.Bold), Color.Black));
        }

        // Очистка графика прогноза
        private void ClearForecast()
        {
            chartForecast.Series.Clear();
            chartForecast.Titles.Clear();
        }

        // Вычисление перепады температур
        private void CalculateTemperatureDifferences()
        {
            if (weatherData == null || weatherData.Rows.Count == 0) return;

            // Создание врменной таблицы для фиксации вычисляемых перепадов
            DataTable differences = new DataTable();
            differences.Columns.Add("Дата", typeof(string));
            differences.Columns.Add("Перепад температуры", typeof(double));

            double maxDifference = double.MinValue;    // Начальное значение для поиска максимума
            double minDifference = double.MaxValue;    // Начальное значение для поиска минимума
            string maxDiffDate = "", minDiffDate = ""; // Даты экстремальных перепадов

            for (int i = 0; i < weatherData.Rows.Count; i++)
            {
                double maxTemp = Convert.ToDouble(weatherData.Rows[i]["Максимальная температура"]);
                double minTemp = Convert.ToDouble(weatherData.Rows[i]["Минимальная температура"]);
                double difference = maxTemp - minTemp;

                differences.Rows.Add(weatherData.Rows[i]["Дата"].ToString(), difference);

                // Поиск максимального перепада
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    maxDiffDate = weatherData.Rows[i]["Дата"].ToString();
                }

                // Поиск минимального перепада
                if (difference < minDifference)
                {
                    minDifference = difference;
                    minDiffDate = weatherData.Rows[i]["Дата"].ToString();
                }
            }

            lblMaxDifference.Text = $"Максимальный перепад: {maxDifference:F1}°C ({maxDiffDate.Split(' ')[0]})";
            lblMinDifference.Text = $"Минимальный перепад: {minDifference:F1}°C ({minDiffDate.Split(' ')[0]})";
        }

        // Кнопка "Закрыть"
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

