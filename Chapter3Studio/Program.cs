using System;
using System.Collections.Generic;

namespace Chapter3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text you want to analyze: ");

            string text = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char character in text)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character] += 1;
                }
                else
                {
                    charCount.Add(character, 1);
                }
            }

            foreach (KeyValuePair<char, int> count in charCount)
            {
                Console.WriteLine($"{count.Key} : {count.Value}");
            }
        }
    }
}
