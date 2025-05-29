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
  
        public TempForm()
        {
            InitializeComponent();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        
    }
}

