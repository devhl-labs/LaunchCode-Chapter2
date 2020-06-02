using System;

namespace _2._5._4
{
    class Program
    {
        private const string ALICE = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a search parameter.");

            string input = Console.ReadLine();

            //Console.WriteLine(ALICE.ToLower().Contains(input.ToLower()) ?
            //    "The search text was found." :
            //    "The search text was not found.");

            Console.WriteLine(ALICE.IndexOf(input));

            //alice is a constant so I can't do this part anyway
            //ALICE = "";

            Console.ReadLine();
        }
    }
}
