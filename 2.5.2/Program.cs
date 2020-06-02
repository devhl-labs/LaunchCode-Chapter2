using System;
using System.ComponentModel.DataAnnotations;

namespace _2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");

            string input = Console.ReadLine();

            int length;

            while (int.TryParse(input, out length) == false)
            {
                Console.WriteLine("What is the length?");

                input = Console.ReadLine();
            }

            Console.WriteLine("What is the width?");

            input = Console.ReadLine();

            int width;

            while (int.TryParse(input, out width) == false)
            {
                Console.WriteLine("What is the width?");

                input = Console.ReadLine();
            }

            Console.WriteLine($"The area of the given rectangle is {length * width}.");
        }
    }
}
