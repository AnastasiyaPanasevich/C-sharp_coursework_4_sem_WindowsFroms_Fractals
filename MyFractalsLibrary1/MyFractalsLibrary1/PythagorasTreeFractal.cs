using System.Collections.Generic;
using System;

namespace MyFractalsLibrary
{
    public class PythagorasTreeFractal
    {
        public int Depth { get; set; } // Глубина фрактала
        public double Size { get; set; } // Размер исходной линии
        public double X1 { get; set; } // Координата X начала линии
        public double Y1 { get; set; } // Координата Y начала линии
        public double Angle { get; set; } // Угол наклона исходной линии
        public double BranchRatio { get; set; } // Коэффициент масштабирования ветвей

        public PythagorasTreeFractal(int depth, double size, double x1, double y1, double angle, double branchRatio)
        {
            Depth = depth;
            Size = size;
            X1 = x1;
            Y1 = y1;
            Angle = angle;
            BranchRatio = branchRatio;
        }

        public List<Tuple<double, double>> GeneratePoints()
        {
            var points = new List<Tuple<double, double>>();
            double size = Size;
            double x1 = X1;
            double y1 = Y1;
            double angle = Angle;

            GenerateTree(points, x1, y1, size, angle, Depth);

            return points;
        }

        private void GenerateTree(List<Tuple<double, double>> points, double x1, double y1, double size, double angle, int depth)
        {
            if (depth == 0)
            {
                // Рисуем лист
                points.Add(new Tuple<double, double>(x1, y1));
            }
            else
            {
                double x2 = x1 + size * Math.Sin(angle * Math.PI / 180.0);
                double y2 = y1 + size * Math.Cos(angle * Math.PI / 180.0);

                // Рисуем ствол
                points.Add(new Tuple<double, double>(x1, y1));
                points.Add(new Tuple<double, double>(x2, y2));

                // Вычисляем две ветви
                double size1 = size * BranchRatio;
                double size2 = size * Math.Sqrt(1 - BranchRatio * BranchRatio);
                double angle1 = angle + 45;
                double angle2 = angle - 45;

                // Рекурсивно рисуем две ветви
                GenerateTree(points, x2, y2, size1, angle1, depth - 1);
                GenerateTree(points, x2, y2, size2, angle2, depth - 1);
            }
        }
    }
}
