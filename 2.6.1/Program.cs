using System;

namespace _2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string radiusPrompt = "Enter the radius of the circle.";

            double radius = 0;

            Console.WriteLine(radiusPrompt);
            while (double.TryParse(Console.ReadLine(), out radius) == false)
                Console.WriteLine(radiusPrompt);

            Console.WriteLine($"The area of a circle of radius {radius} is: {Math.Round(Math.PI * radius * radius, 3)}");

            Console.WriteLine($"The circumference of a circle of radius {radius} is: {Math.Round(2 * Math.PI * radius, 3)}");

            Console.WriteLine($"The diameter of a circle of radius {radius} is: {Math.Round(2 * radius, 3)}");
        }
    }
}
