using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using System.Threading;
using MyFractalsLibrary;
using System.IO;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public string NameFile = "";
        DateTime now;
        private Color drawColor;
        private Color backgroundColor = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            //создание обьекта Form_intro(заставки)
            Form_intro newForm = new Form_intro();
            newForm.Visible = true;
            newForm.Size = new Size(1205, 644);
            newForm.Location = new Point(0, 0);
            newForm.Show();
            Thread.Sleep(2000);
            newForm.Close();
            this.Visible = true;

            // Устанавливаем координаты окна в левый верхний угол экрана
            this.Location = new System.Drawing.Point(0, 0);
            GL.ClearColor(Color.White); // устанавливаем белый фон
            GL.Color3(Color.Black); // устанавливаем черный цвет для рисунка

            // устанавливаем невидимость параметров для каждого фрактала
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            textBoxX1.Visible = false;
            textBoxY1.Visible = false;

            textBoxAngle.Visible = false;
            textBoxDepth.Visible = false;
            textBoxSize.Visible = false;
            textBoxBranchRatio.Visible = false;
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)   // пункт меню вызова Paint
        {
            now = DateTime.Now;
            Export.ToPaint(glControl1, now);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)   // пункт меню выход
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти из программы?", "Подтвердите выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e) // пункт меню руководство пользователя
    {
         //string guidePath = @"Guide.docx";

            string guidePath = @"C:\Users\matil\OneDrive\Документы\4 sem 2023\gursky\курсач\Fractals_v1\Guide.chm";
        if (System.IO.File.Exists(guidePath))
        {
                //Process.Start(guidePath);
                Help.ShowHelp(this, guidePath);
            }
        else
        {
            MessageBox.Show("Файл руководства пользователя не найден.");
        }
    }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e) // пункт меню о приложении
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ToExcelNew_Click(object sender, EventArgs e)   // подпункт меню для создания нового файла эксель
        {
            if (radioButtonKoch.Checked)
            {
                Export.ToExcelNew(now, textBoxDepth.Text, textBoxAngle.Text, "-", "-");

            }
            else if (radioButtonSerpinsky.Checked)
            {
                Export.ToExcelNew(now, textBoxDepth.Text, "-", textBoxSize.Text, "-");
            }
            else if (radioButtonDragon.Checked)
            {
                Export.ToExcelNew(now, textBoxDepth.Text, textBoxAngle.Text, "-", "-");
            }
            else if (radioButtonPythagor.Checked)
            {
                Export.ToExcelNew(now, textBoxDepth.Text, textBoxAngle.Text, textBoxSize.Text, textBoxBranchRatio.Text);
            }
            else
            {
                MessageBox.Show("Please select a fractal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ToExcelAdd_Click(object sender, EventArgs e)   // подпункт меню для добавления информации в эксель
        {
            if (radioButtonKoch.Checked)
            {
                Export.ToExcelAdd(now, textBoxDepth.Text, textBoxAngle.Text, "-", "-");

            }
            else if (radioButtonSerpinsky.Checked)
            {
                Export.ToExcelAdd(now, textBoxDepth.Text, "-", textBoxSize.Text, "-");
            }
            else if (radioButtonDragon.Checked)
            {
                Export.ToExcelAdd(now, textBoxDepth.Text, textBoxAngle.Text, "-", "-");
            }
            else if (radioButtonPythagor.Checked)
            {
                Export.ToExcelAdd(now, textBoxDepth.Text, textBoxAngle.Text, textBoxSize.Text, textBoxBranchRatio.Text);
            }
            else
            {
                MessageBox.Show("Please select a fractal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void radioButtonKoch_CheckedChanged(object sender, EventArgs e) //выбор фрактала коха
        {
            //  установление видимости для нужных элементов и задание параметров для примера фрактала
            textBoxX1.Visible = true;
            textBoxY1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            textBoxAngle.Visible = true;
            label6.Visible = false;
            textBoxSize.Visible = false;
            label7.Visible = false;
            textBoxBranchRatio.Visible = false;
            textBoxDepth.Visible = true;

            textBoxScale.Text = "0,5";
            textBoxX1.Text = "0";
            textBoxY1.Text = "-1,5";
            textBoxDepth.Text = "4";
            textBoxAngle.Text = "60";
        }

        private void radioButtonSerpinsky_CheckedChanged(object sender, EventArgs e)    //выбор фрактала серпинского
        {
            //  установление видимости для нужных элементов и задание параметров для примера фрактала
            textBoxX1.Visible = true;
            textBoxY1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            label6.Visible = true;
            textBoxSize.Visible = true;
            label3.Visible = false;
            label2.Visible = false;
            textBoxAngle.Visible = false;
            label7.Visible = false;
            textBoxBranchRatio.Visible = false;
            textBoxDepth.Visible = true;

            textBoxScale.Text = "2";
            textBoxX1.Text = "-0,5";
            textBoxY1.Text = "-0,4";
            textBoxDepth.Text = "8";
            textBoxSize.Text = "1";
        }

        private void radioButtonDragon_CheckedChanged(object sender, EventArgs e)   //выбор фрактала дракона
        {
            //  установление видимости для нужных элементов и задание параметров для примера фрактала
            textBoxX1.Visible = true;
            textBoxY1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            label6.Visible = false;
            textBoxSize.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            textBoxAngle.Visible = true;
            label3.Visible = true;
            label7.Visible = false;
            textBoxBranchRatio.Visible = false;
            textBoxDepth.Visible = true;

            textBoxScale.Text = "1";
            textBoxX1.Text = "-0,2";
            textBoxY1.Text = "-0,4";
            textBoxDepth.Text = "10";
            textBoxAngle.Text = "45";
        }

        private void radioButtonPythagor_CheckedChanged(object sender, EventArgs e) // выбор фрактала дерева пифагора
        {
            //  установление видимости для нужных элементов и задание параметров для примера фрактала
            textBoxX1.Visible = true;
            textBoxY1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            label6.Visible = true;
            textBoxSize.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            textBoxAngle.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            textBoxBranchRatio.Visible = true;
            textBoxDepth.Visible = true;

            textBoxScale.Text = "0,5";
            textBoxX1.Text = "0,035";
            textBoxY1.Text = "-1,5";
            textBoxDepth.Text = "15";
            textBoxAngle.Text = "0";
            textBoxSize.Text = "1";
            textBoxBranchRatio.Text = "0,7";
        }


        private List<Tuple<double, double>> GenerateFractalPoints() // запись в список координат для соответствующего фрактала, проверка введенных значений
        {
            if (!double.TryParse(textBoxX1.Text, out double x1) ||
               !double.TryParse(textBoxY1.Text, out double y1))
            {
                throw new ArgumentException("Неверный формат ввода. Пожалуйста, введите только числа.");
            }

            if (radioButtonKoch.Checked)
            {
                if (!int.TryParse(textBoxDepth.Text, out int depth) || depth < 0 || depth > 10)
                {
                    throw new ArgumentException("Неверное значение глубины. Глубина должна быть числом от 0 до 10.");
                }

                if (!double.TryParse(textBoxAngle.Text, out double angle) || angle < -360.0 || angle > 360.0)
                {
                    throw new ArgumentException("Неверное значение угла. Угол должен быть числом от -360 до 360.");
                }

                KochFractal kochFractal = new KochFractal(depth, angle, x1, y1);
                List<Tuple<double, double>> points = kochFractal.GeneratePoints();

                // Генерация следующего фрактала Коха с координатами начала,
                // которые являются координатами конца предыдущей снежинки,
                // и углом, который на 120 градусов больше предыдущего, таким образом он стротся во внутрь треугольника
                double x2 = points[points.Count - 1].Item1;
                double y2 = points[points.Count - 1].Item2;
                kochFractal = new KochFractal(depth, angle + 120.0, x2, y2);
                points.AddRange(kochFractal.GeneratePoints());

                // Генерация третьей снежинки Коха аналогичным образом
                x2 = points[points.Count - 1].Item1;
                y2 = points[points.Count - 1].Item2;
                kochFractal = new KochFractal(depth, angle + 240.0, x2, y2);
                points.AddRange(kochFractal.GeneratePoints());

                return points;
            }
            else if (radioButtonSerpinsky.Checked)
            {
                if (!int.TryParse(textBoxDepth.Text, out int depth) || depth < 0 || depth > 15)
                {
                    throw new ArgumentException("Неверное значение глубины. Глубина должна быть числом от 0 до 15.");
                }

                if (!double.TryParse(textBoxSize.Text, out double size) || size <= 0.0)
                {
                    throw new ArgumentException("Неверное значение размера. Размер должен быть положительным числом.");
                }

                SierpinskiFractal serpinskyFractal = new SierpinskiFractal(depth, size, x1, y1);
                return serpinskyFractal.GeneratePoints();
            }
            else if (radioButtonDragon.Checked)
            {
                if (!int.TryParse(textBoxDepth.Text, out int depth) || depth < 0 || depth > 20)
                {
                    throw new ArgumentException("Неверное значение глубины. Глубина должна быть числом от 0 до 20.");
                }

                if (!double.TryParse(textBoxAngle.Text, out double angle) || angle < -360.0 || angle > 360.0)
                {
                    throw new ArgumentException("Неверное значение угла. Угол должен быть числом от -360 до 360.");
                }

                DragonFractal dragonFractal = new DragonFractal(depth, angle, x1, y1);
                return dragonFractal.GeneratePoints();
            }
            else if (radioButtonPythagor.Checked)
            {
                if (!int.TryParse(textBoxDepth.Text, out int depth) || depth < 0 || depth > 20)
                {
                    throw new ArgumentException("Неверное значение глубины. Глубина должна быть числом от 0 до 20.");
                }

                if (!double.TryParse(textBoxAngle.Text, out double angle) || angle < -360.0 || angle > 360.0)
                {
                    throw new ArgumentException("Неверное значение угла. Угол должен быть числом от -360 до 360.");
                }

                if (!double.TryParse(textBoxSize.Text, out double size) || size <= -10.0 || size >= 10.0)
                {
                    throw new ArgumentException("Неверное значение размера. Размер должен быть числом от -10 до 10.");
                }

                if (!double.TryParse(textBoxBranchRatio.Text, out double branchRatio) || branchRatio <= 0.0 || branchRatio >= 1.0)
                {
                    throw new ArgumentException("Неверное значение коэффициента ветвления. Коэффициент ветвления должен быть числом от 0 до 1.");
                }

                PythagorasTreeFractal pythagorasFractal = new PythagorasTreeFractal(depth, size, x1, y1, angle, branchRatio);
                return pythagorasFractal.GeneratePoints();
            }
            else
            {
                throw new ArgumentException("Пожалуйста, выберите фрактал.");
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e) // вызов отрисовки графика для фрактала
        {
            try
            {
                double scale;
                if (!double.TryParse(textBoxScale.Text, out scale))
                {
                    throw new ArgumentException("Неверное значение масштаба. Масштаб должен быть числом.");
                }

                List<Tuple<double, double>> points = GenerateFractalPoints();
                DrawFractal(points, scale);

                if (checkBox1.Checked)
                {
                    // Создание нового окна с графиком
                    FormGraph newGraphForm = new FormGraph(points, drawColor, backgroundColor);
                    newGraphForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверные данные: " + ex.Message);
            }
        }


        private void DrawFractal(List<Tuple<double, double>> points, double scale)  //отрисовка фрактала на glControl
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            GL.Scale(scale, scale, 1.0);
            GL.Begin(PrimitiveType.LineStrip);
            foreach (Tuple<double, double> point in points)
            {
                GL.Vertex2(point.Item1, point.Item2);
            }
            GL.End();
            glControl1.SwapBuffers();
        }

        private void Clear_Click(object sender, EventArgs e)    // очистка glControl
        {
            glControl1.MakeCurrent();
            GL.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.SwapBuffers();
        }

        private void glControl1_Load(object sender, EventArgs e)    // загрузка glControl
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1, 1, -1, 1, -1, 1);
        }

        private void glControl1_Resize(object sender, EventArgs e)  
        {
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Force a redraw of the glControl1 control
            glControl1.Invalidate();
        }

        private void buttonChooseDrawColor_Click(object sender, EventArgs e)    //выбор цвета пера
        {
            if (colorDialogDraw.ShowDialog() == DialogResult.OK)
            {
                drawColor = colorDialogDraw.Color;
                GL.Color3(drawColor.R / 255f, drawColor.G / 255f, drawColor.B / 255f);

                // Установка цвета кнопки выбранным цветом
                buttonChooseDrawColor.BackColor = drawColor;
            }
        }

        private void buttonChooseBackgroundColor_Click(object sender, EventArgs e)  //выбор цвета фона
        {
            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = colorDialogBackground.Color;
                GL.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, 1.0f);

                // Установка цвета кнопки выбранным цветом
                buttonChooseBackgroundColor.BackColor = backgroundColor;
            }
        }

    }
}
