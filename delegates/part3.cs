using System;

namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<double, double, double> calculateRectangleArea = (width, height) => width * height;
            double width = 5.0;
            double height = 3.0;
            double area = calculateRectangleArea(width, height);
            Console.WriteLine($"The area of a rectangle with width: {width} and height: {height} is {area}.");
        }
    }
}
