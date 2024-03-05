using System;
using System.Collections.Generic;

namespace MyFractalsLibrary
{
    public class KochFractal
    {
        public int Depth { get; set; } // Глубина фрактала
        public double Angle { get; set; } // Угол наклона
        public double X1 { get; set; } // Координата X начальной точки
        public double Y1 { get; set; } // Координата Y начальной точки

        public KochFractal(int depth, double angle, double x1, double y1)
        {
            Depth = depth;
            Angle = angle;
            X1 = x1;
            Y1 = y1;
        }

        public List<Tuple<double, double>> GeneratePoints()
        {
            var points = new List<Tuple<double, double>>();

            double length = 1.0; // Длина изначальной линии
            double theta = Angle * Math.PI / 180.0; // Угол наклона в радианах

            // Начальная точка
            double x1 = X1;
            double y1 = Y1;

            // Конечная точка
            double x2 = length * Math.Cos(theta) + X1;
            double y2 = length * Math.Sin(theta) + Y1;

            // Генерация фрактала Коха
            GenerateKochCurve(points, x1, y1, x2, y2, Depth);

            x1 = x2;
            y1 = y2;
            x2 = length * Math.Cos(theta + 60.0 * Math.PI / 180.0) + x1;
            y2 = length * Math.Sin(theta + 60.0 * Math.PI / 180.0) + y1;
            GenerateKochCurve(points, x1, y1, x2, y2, Depth);

            x1 = x2;
            y1 = y2;
            x2 = length * Math.Cos(theta - 60.0 * Math.PI / 180.0) + x1;
            y2 = length * Math.Sin(theta - 60.0 * Math.PI / 180.0) + y1;
            GenerateKochCurve(points, x1, y1, x2, y2, Depth);

            x1 = x2;
            y1 = y2;
            x2 = length * Math.Cos(theta) + x1;
            y2 = length * Math.Sin(theta) + y1;
            GenerateKochCurve(points, x1, y1, x2, y2, Depth);

            return points;
        }

        private void GenerateKochCurve(List<Tuple<double, double>> points, double x1, double y1, double x2, double y2, int depth)
        {
            if (depth == 0)
            {
                // Добавляем начальную и конечную точки линии
                points.Add(new Tuple<double, double>(x1, y1));
                points.Add(new Tuple<double, double>(x2, y2));
            }
            else
            {
                // Вычисляем промежуточные точки линии
                double deltaX = (x2 - x1) / 3.0;
                double deltaY = (y2 - y1) / 3.0;

                double x1n = x1 + deltaX;
                double y1n = y1 + deltaY;

                double x2n = x2 - deltaX;
                double y2n = y2 - deltaY;

                double x3 = x1n + (x2n - x1n) * Math.Cos(Math.PI / 3) - (y2n - y1n) * Math.Sin(Math.PI / 3);
                double y3 = y1n + (y2n - y1n) * Math.Cos(Math.PI / 3) + (x2n - x1n) * Math.Sin(Math.PI / 3);

                // Рекурсивно генерируем фрактал для каждой из четырех новых линий
                GenerateKochCurve(points, x1, y1, x1n, y1n, depth - 1);
                GenerateKochCurve(points, x1n, y1n, x3, y3, depth - 1);
                GenerateKochCurve(points, x3, y3, x2n, y2n, depth - 1);
                GenerateKochCurve(points, x2n, y2n, x2, y2, depth - 1);
            }
        }
    }
}
