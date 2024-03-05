using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;

namespace Fractals
{
    public partial class FormGraph : Form
    {
        private List<Tuple<double, double>> points;
        private double currentScale;
        Color drawColor, backgroundColor;
        public FormGraph(List<Tuple<double, double>> points, Color drawColor, Color backgroundColor)
        {
            InitializeComponent();

            this.points = points;
            this.drawColor = drawColor;
            this.backgroundColor = backgroundColor;

            // Создаем таблицу и добавляем ее на вкладку tabPageTable
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;

            // Задаем цвет фона для таблицы
            dataGridView1.DefaultCellStyle.BackColor = Color.LavenderBlush;

            // Задаем цвет фона для заголовков столбцов
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumOrchid;

            tabPageTable.Controls.Add(dataGridView1);

            // Добавляем столбцы "x" и "y" в таблицу
            dataGridView1.Columns.Add("xColumn", "Значение X");
            dataGridView1.Columns.Add("yColumn", "Значение Y");

            // Добавляем значения точек в таблицу
            foreach (var point in points)
            {
                dataGridView1.Rows.Add(point.Item1.ToString("N5"), point.Item2.ToString("N5"));
            }
        }

        private void buttonExport_Click(object sender, EventArgs e) //кнопка экспорта в эксель
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Создаем экземпляр приложения Excel
                excelApp = new Excel.Application();

                // Создаем новую рабочую книгу
                workbook = excelApp.Workbooks.Add();

                // Получаем первый лист рабочей книги
                worksheet = (Excel.Worksheet)workbook.Sheets[1];

                worksheet.Cells[1, 1].Interior.Color = 8388736; // Фиолетовый цвет заливки
                worksheet.Cells[1, 2].Interior.Color = 8388736;
                worksheet.Cells[1, 1].Font.Color = 16777215; // Белый цвет шрифта
                worksheet.Cells[1, 2].Font.Color = 16777215;

                // Добавляем заголовки столбцов
                worksheet.Cells[1, 1] = "x";
                worksheet.Cells[1, 2] = "y";

                // Заполняем лист данными из DataGridView
                for (int i = 0; i < points.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = points[i].Item1.ToString("0.#####", CultureInfo.InvariantCulture);
                    worksheet.Cells[i + 2, 2] = points[i].Item2.ToString("0.#####", CultureInfo.InvariantCulture);
                }

                // Автоматически подгоняем ширину столбцов
                worksheet.Columns.AutoFit();

                // Отображаем диалог сохранения файла, чтобы получить имя файла и путь для сохранения Excel-файла
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Microsoft Excel Sheet (.xlsx)|*.xlsx";
                sfd.FileName = "File Name.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем рабочую книгу
                    workbook.SaveAs(sfd.FileName);

                    // Закрываем рабочую книгу
                    workbook.Close();

                    // Завершаем работу приложения Excel
                    excelApp.Quit();

                    // Открываем сохраненный Excel-файл в приложении Excel
                    Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании Excel-файла: {ex.Message}");
            }
            finally
            {
                // Освобождаем COM-объекты и закрываем приложение Excel
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void buttonWord_Click(object sender, EventArgs e)   //экспорт в ворд
        {

            Word.Application wordApp = null;
            Word.Document document = null;

            try
            {
                // Создаем экземпляр приложения Word
                wordApp = new Word.Application();

                // Создаем новый документ
                document = wordApp.Documents.Add();
                // Добавляем заголовки столбцов
                Word.Table table = document.Tables.Add(document.Range(), points.Count + 1, 2);

                table.Cell(1, 1).Range.Text = "x";
                table.Cell(1, 2).Range.Text = "y";

                // Задаем цвет фона и цвет шрифта для заголовков
                table.Cell(1, 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorIndigo;
                table.Cell(1, 2).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorIndigo;
                table.Cell(1, 1).Range.Font.Color = Word.WdColor.wdColorWhite;
                table.Cell(1, 2).Range.Font.Color = Word.WdColor.wdColorWhite;

                // Заполняем таблицу данными из points
                for (int i = 0; i < points.Count; i++)
                {
                    table.Cell(i + 2, 1).Range.Text = points[i].Item1.ToString("0.#####", CultureInfo.InvariantCulture);
                    table.Cell(i + 2, 2).Range.Text = points[i].Item2.ToString("0.#####", CultureInfo.InvariantCulture);
                }

                // Автоматически подгоняем ширину столбцов
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);

                // Отображаем диалог сохранения файла, чтобы получить имя файла и путь для сохранения Word-документа
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Microsoft Word Document (.docx)|*.docx";
                sfd.FileName = "File Name.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем документ
                    document.SaveAs2(sfd.FileName);

                    // Закрываем документ
                    document.Close();

                    // Завершаем работу приложения Word
                    wordApp.Quit();

                    // Открываем сохраненный Word-документ в приложении Word
                    Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании Word-документа: {ex.Message}");
            }
            finally
            {
                // Освобождаем COM-объекты и закрываем приложение Word
                if (document != null) Marshal.ReleaseComObject(document);
                if (wordApp != null) Marshal.ReleaseComObject(wordApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

        }

        private void buttonAnimation_Click(object sender, EventArgs e)  //кнопка создания и запуска анимации
        {
            Graphics graphics = PanelDraw.CreateGraphics();

            // Очищаем панель перед началом анимации
            graphics.Clear(Color.White);

            // Определяем задержку между кадрами анимации (в миллисекундах) в зависимости от количества точек
            int totalPoints = points.Count;
            int maxDelay = 25;
            int delay = maxDelay / totalPoints;

            // Получаем значение масштаба из текстового поля
            double scale;
            if (!double.TryParse(textBoxScale.Text, out scale))
            {
                MessageBox.Show("Пожалуйста, введите допустимое значение масштаба.");
                return;
            }

            // Обновляем текущий масштаб
            currentScale = scale;

            // Размер точки
            int pointSize = 2;

            // Определение градиента цветов
            Color startColor = drawColor;
            Color endColor;
            if (backgroundColor == Color.White)
            {
                endColor = Color.Black;
            }
            else
            {
                endColor = backgroundColor;
            }

            for (int i = 0; i < points.Count; i++)
            {
                Tuple<double, double> point = points[i];



                // Интерполяция цвета между начальным и конечным цветом на основе позиции
                double position = (double)i / (points.Count - 1); // Позиция точки в списке (от 0 до 1)
                int red = (int)(startColor.R + (endColor.R - startColor.R) * position);
                int green = (int)(startColor.G + (endColor.G - startColor.G) * position);
                int blue = (int)(startColor.B + (endColor.B - startColor.B) * position);
                Color pointColor = Color.FromArgb(red, green, blue);

                Brush brush = new SolidBrush(pointColor);

                // Рисуем точку с учетом текущего масштаба и цвета
                graphics.FillEllipse(brush, (float)((point.Item1 * currentScale * 30) - pointSize / 2 + PanelDraw.Width / 2), (float)((point.Item2 * currentScale * 30) - pointSize / 2 + PanelDraw.Height / 2), pointSize, pointSize);

                // Задержка между кадрами
                Thread.Sleep(delay);
            }
        }




        // Обработчик изменения содержимого текстового поля масштаба
        private void textBoxScale_TextChanged(object sender, EventArgs e)   //изменение масштаба
        {
            // Обновляем текущий масштаб
            double scale;
            if (double.TryParse(textBoxScale.Text, out scale))
            {
                currentScale = scale;
            }
        }
    }
}
