using System;

namespace AreaFigureLib
{
    public static class Area
    {
        public static class TiangleArea
        {
            public static double GetArea(double first, double second, double third)
            {
                if (first + second < third || first + third < second || third + second < first)
                {
                    throw new ArgumentException("Невозможно существование!");
                }
                else if (first < 0 || second < 0 || third < 0)
                {
                    throw new ArgumentException("Длины меньше нуля!");
                }
                double p = (first + second + third) / 2;
                return Math.Sqrt(p * (p - first) * (p - second) * (p - third));
            }
            public static bool IsRightTriangle(double first, double second, double third)
            {
                if (first + second < third || first + third < second || third + second < first)///Повтор кода, т.к. в даном случаче повторяется всего в друх местах 
                {
                    throw new ArgumentException("Невозможно существование!");
                }
                else if (first < 0 || second < 0 || third < 0)
                {
                    throw new ArgumentException("Длины меньше нуля!");
                }
                return (first == Math.Sqrt(Math.Pow(second, 2) + Math.Pow(third, 2))
                    || second == Math.Sqrt(Math.Pow(first, 2) + Math.Pow(third, 2))
                    || third == Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2)));
            }
        }
        public static class CircleArea
        {
            public static double GetArea(double radius)
            {
                if (radius < 0)
                {
                    throw new ArgumentException("Радиус не может быть меньше нуля!");
                }
                else if (radius == 0)
                {
                    return 0;
                }
                return Math.Pow(radius, 2) * Math.PI;
            }
        }
    }
}
