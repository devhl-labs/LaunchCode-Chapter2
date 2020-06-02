using System;

namespace _2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;

            Console.WriteLine("How many miles have you driven?");
            while (int.TryParse(Console.ReadLine(), out miles) == false)
                Console.WriteLine("How many miles have you driven?");

            int gallons;

            Console.WriteLine("How many gallons were used?");
            while (int.TryParse(Console.ReadLine(), out gallons) == false)
                Console.WriteLine("How many gallons were used?");

            Console.WriteLine($"You got {Math.Round((decimal) miles / gallons, 2)}.");

            Console.ReadLine();
        }
    }
}
