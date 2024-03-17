using System;
using System.Runtime.InteropServices;

namespace Pr_3.Pr_3_task2
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3, string name)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, string name)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5, string name)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double P = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                P += LengthSide(points[i], points[nextIndex]);
            }
            Console.Write("Perimeter of the figure with points ");
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write(points[i].PointName);
                if (i < points.Length - 1)
                    Console.Write("");
            }
            Console.WriteLine($" is: {P}");
        }
    }
}
