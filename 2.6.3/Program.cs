using System;

namespace _2._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mpgPrompt = "Enter your vehicle's miles per gallon.";

            double mpg;

            Console.WriteLine(mpgPrompt);

            while (double.TryParse(Console.ReadLine(), out mpg) == false || mpg <= 0)
                Console.WriteLine(mpgPrompt);

            const string radiusPrompt = "Enter the radius of the circle in miles.";


            Console.WriteLine(radiusPrompt);

            double radius;

            while (double.TryParse(Console.ReadLine(), out radius) == false || radius <= 0)
                Console.WriteLine(radiusPrompt);

            Console.WriteLine($"You will use {Math.Round(radius / mpg, 2)} gallon to drive around the circle.");

            Console.ReadLine();
        }
    }
}
