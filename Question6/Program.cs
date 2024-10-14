using System;
using System.Text;

namespace Question6
{
    

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Find Exponential");
            Console.WriteLine("2.Replace Word");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                StringBuilder result = FindExponential(number);
                Console.WriteLine(result.ToString());
            }
            else if (option == 2)
            {
                Console.Write("Enter the sentence: ");
                string sentence = Console.ReadLine();
                Console.Write("Enter the word to replace: ");
                string word1 = Console.ReadLine();
                Console.Write("Enter the new word: ");
                string word2 = Console.ReadLine();
                StringBuilder result = ReplaceWord(sentence, word1, word2);
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }

        public static StringBuilder FindExponential(int number)
        {
            StringBuilder sb = new StringBuilder("Exponential is ");
            double exponentialValue = Math.Pow(10, number);
            sb.Append(exponentialValue.ToString("E6"));
            return sb;
        }

        public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
            StringBuilder sb = new StringBuilder(sentence);
            sb.Replace(word1, word2);
            return sb;
        }
    }

}
