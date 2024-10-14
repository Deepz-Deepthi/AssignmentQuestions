using System;
using System.Collections.Generic;

namespace Question7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            // Split the input string by colons
            string[] words = input.Split(':');

            // Check the word count
            if (words.Length > 15)
            {
                Console.WriteLine("Invalid length");
                return;
            }

            // Dictionary to count occurrences of each word
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            // Count the occurrences of each word
            foreach (string word in words)
            {
                string upperWord = word.ToUpper();
                if (wordCount.ContainsKey(upperWord))
                {
                    wordCount[upperWord]++;
                }
                else
                {
                    wordCount[upperWord] = 1;
                }
            }

            // Display the words and their counts
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }

}
