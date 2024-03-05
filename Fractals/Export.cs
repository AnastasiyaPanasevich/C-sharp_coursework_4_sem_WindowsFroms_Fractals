using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Fractals
{
    public partial class Export : Form
    {
        public static string NameFile = "";

        public static void ToPaint(Control control, DateTime now)   // создание и сохранение скриншота экрана с графиком
        {
            // Захват области клиентской области элемента управления GLControl
            var glControl = (OpenTK.GLControl)control;
            glControl.MakeCurrent();
            Form parentForm = control.FindForm();
            System.Threading.Thread.Sleep(500); // Пауза
            var bmp = new Bitmap(1239, 589);
            var gfx = Graphics.FromImage(bmp);
            gfx.CopyFromScreen(parentForm.PointToScreen(new Point(control.Location.X + 9, control.Location.Y + 24)), new Point(0, 0), bmp.Size);

            // Сохранение скриншота в файл
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Files (*.png)|*.png";
                dialog.DefaultExt = "png";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dialog.FileName, ImageFormat.Png);
                    NameFile = dialog.FileName;
                    now = DateTime.Now;
                    // Открытие скриншота в Paint
                    Process.Start("mspaint.exe", dialog.FileName);
                }
            }
        }

        public static void excelApp_SheetFollowHyperlink(object Sh, Excel.Hyperlink Target) // создание гипперссылки в виде ссылки на изображение по адресу расположения изображения
        {
            if (Target != null)
            {
                string address = Target.Address;
                if (!string.IsNullOrEmpty(address))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(address);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}");
                    }
                }
            }
        }

        public static void ToExcelNew(DateTime now, string depth, string angle, string size, string ratio)  // создание и открытие нового эксель документа
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.SheetFollowHyperlink += excelApp_SheetFollowHyperlink;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.Sheets[1];
                worksheet.Name = "Data";
                worksheet.Cells[1, 1] = "Creation date";
                worksheet.Cells[1, 2] = "Name of the image";
                worksheet.Cells[1, 3] = "Depth";
                worksheet.Cells[1, 4] = "Angle in °";
                worksheet.Cells[1, 5] = "Size";
                worksheet.Cells[1, 6] = "Branch ratio";

                int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;
                worksheet.Cells[lastRow, 1] = now.ToString("yyyy-MM-dd HH:mm:ss");
                worksheet.Cells[lastRow, 2] = $"=HYPERLINK(\"{NameFile.Replace("\\", "/")}\")";
                worksheet.Cells[lastRow, 3] = depth;
                worksheet.Cells[lastRow, 4] = angle;
                worksheet.Cells[lastRow, 5] = size;
                worksheet.Cells[lastRow, 6] = ratio;

                worksheet.Columns.AutoFit();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Microsoft Excel Sheet (.xlsx)|*.xlsx";
                sfd.FileName = "File Name.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("File successfully created!", "Notification");
                    Process.Start(sfd.FileName);
                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();
                    Process.Start(sfd.FileName);
                }

                NameFile = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to create the Excel file: {ex.Message}");
            }
            finally
            {
                // Освобождение COM-объектов и закрытие приложения Excel
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void ToExcelAdd(DateTime now, string depth, string angle, string size, string ratio)  // добавление информации в уже существующий файл эксель
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.SheetFollowHyperlink += excelApp_SheetFollowHyperlink;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Excel Sheet (.xlsx)|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    workbook = excelApp.Workbooks.Open(ofd.FileName);
                    worksheet = workbook.Sheets[1];

                    int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;
                    worksheet.Cells[lastRow, 1] = now.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Cells[lastRow, 2] = $"=HYPERLINK(\"{NameFile.Replace("\\", "/")}\")";
                    worksheet.Cells[lastRow, 3] = depth;
                    worksheet.Cells[lastRow, 4] = angle;
                    worksheet.Cells[lastRow, 5] = size;
                    worksheet.Cells[lastRow, 6] = ratio;
                    worksheet.Columns.AutoFit();

                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();
                    Process.Start(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while trying to add data to the Excel file: {ex.Message}");
                }
                finally
                {
                    // Освобождение COM-объектов и закрытие приложения Excel
                    if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                    if (workbook != null) Marshal.ReleaseComObject(workbook);
                    if (excelApp != null) Marshal.ReleaseComObject(excelApp);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }

            NameFile = "";
        }
    }
}
