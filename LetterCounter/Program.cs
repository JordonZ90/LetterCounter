using System;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterCounter();
        }

        public static void LetterCounter()
        {
            Console.WriteLine("Please enter your message ");
            string userInput = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your letter ");
            char userLetter = Convert.ToChar(Console.ReadLine().ToLower());

            int count = 0;
            foreach (var lettercount in userInput)
            {
                if (lettercount == userLetter)
                {
                    count++;
                }

            }
            Console.WriteLine($"The letter '{userLetter}' occurs {count} times.");      
        }
    }
}
