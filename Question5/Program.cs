using System;
using System.Text;

namespace Question5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the first word from the user
            Console.WriteLine("Enter the word 1:");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());

            // Get the character to search for
            Console.WriteLine("Enter the character to search:");
            string inputChar = Console.ReadLine();

            // Check if input is valid
            if (string.IsNullOrEmpty(inputChar) || inputChar.Length > 1)
            {
                Console.WriteLine("Please enter a single character.");
                return;
            }

            char ch = inputChar[0];

            // Get the second word to insert
            Console.WriteLine("Enter the word 2:");
            string word2 = Console.ReadLine();

            // Call the WordInserting method and display the result
            StringBuilder result = WordInserting(word1, ch, word2);
            Console.WriteLine("Modified Word: " + result);
        }

        public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            // Find the position of the character in the word
            int index = word1.ToString().IndexOf(ch);

            // If the character is found, insert word2 at that position
            if (index != -1)
            {
                word1.Insert(index, word2);
            }
            else
            {
                Console.WriteLine($"Character '{ch}' not found in the word.");
            }

            // Return the modified word
            return word1;
        }
    }
}
