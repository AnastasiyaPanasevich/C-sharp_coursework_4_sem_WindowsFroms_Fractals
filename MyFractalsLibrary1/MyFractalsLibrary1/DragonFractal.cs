using System;
using System.Collections.Generic;

namespace MyFractalsLibrary
{
    public class DragonFractal
    {
        public int Depth { get; set; } // Глубина фрактала
        public double Angle { get; set; } // Угол наклона
        public double X1 { get; set; } // Координата X начальной точки
        public double Y1 { get; set; } // Координата Y начальной точки

        public DragonFractal(int depth, double angle, double x1, double y1)
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

            // Генерация фрактала Дракона
            GenerateDragonCurve(points, x1, y1, x2, y2, Depth);

            return points;
        }

        private void GenerateDragonCurve(List<Tuple<double, double>> points, double x1, double y1, double x2, double y2, int depth)
        {
            if (depth == 0)
            {
                // Добавляем начальную и конечную точки линии
                points.Add(new Tuple<double, double>(x1, y1));
                points.Add(new Tuple<double, double>(x2, y2));
            }
            else
            {
                // Вычисляем координаты промежуточной точки
                double deltaX = x2 - x1;
                double deltaY = y2 - y1;

                double x3 = x1 + deltaX / 2.0 - deltaY / 2.0;
                double y3 = y1 + deltaY / 2.0 + deltaX / 2.0;

                // Рекурсивно генерируем фрактал для двух новых линий
                GenerateDragonCurve(points, x1, y1, x3, y3, depth - 1);
                GenerateDragonCurve(points, x2, y2, x3, y3, depth - 1);
            }
        }
    }
}
