using System;
using System.Collections.Generic;

namespace MyFractalsLibrary
{
    public class SierpinskiFractal
    {
        public int Depth { get; set; } // Глубина фрактала
        public double Size { get; set; } // Размер
        public double X1 { get; set; } // Координата X начальной точки
        public double Y1 { get; set; } // Координата Y начальной точки

        public SierpinskiFractal(int depth, double size, double x1, double y1)
        {
            Depth = depth;
            Size = size;
            X1 = x1;
            Y1 = y1;
        }

        public List<Tuple<double, double>> GeneratePoints()
        {
            var points = new List<Tuple<double, double>>();

            double size = Size;
            double x1 = X1;
            double y1 = Y1;

            // Генерация фрактала Серпинского
            GenerateSierpinski(points, x1, y1, size, Depth);

            return points;
        }

        private void GenerateSierpinski(List<Tuple<double, double>> points, double x1, double y1, double size, int depth)
        {
            if (depth == 0)
            {
                // Рисуем треугольник
                points.Add(new Tuple<double, double>(x1, y1));
                points.Add(new Tuple<double, double>(x1 + size, y1));
                points.Add(new Tuple<double, double>(x1 + size / 2.0, y1 + size * Math.Sqrt(3.0) / 2.0));
            }
            else
            {
                double size2 = size / 2.0;
                double x2 = x1 + size2;
                double y2 = y1;
                double x3 = x1 + size2 / 2.0;
                double y3 = y1 + size2 * Math.Sqrt(3.0) / 2.0;

                // Рекурсивно рисуем три меньших треугольника
                GenerateSierpinski(points, x1, y1, size2, depth - 1);
                GenerateSierpinski(points, x2, y2, size2, depth - 1);
                GenerateSierpinski(points, x3, y3, size2, depth - 1);
            }
        }
    }
}
