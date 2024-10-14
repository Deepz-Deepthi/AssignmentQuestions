namespace Question12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            char[] chars = new char[size];

            Console.WriteLine("Enter the characters:");
            for (int i = 0; i < size; i++)
            {
                chars[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line after each character input
            }

            Console.Write("Enter the special character: ");
            char specialChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after special character input

            // Call the method to replace duplicates with the special character
            ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            // Display the modified character array
            Console.WriteLine("Modified characters:");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            // Additionally, displaying the string "Hello"
            Console.WriteLine("string: Hello");
        }

        public static void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            // Use a HashSet to track seen characters
            HashSet<char> seenCharacters = new HashSet<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                // Check if the character is already seen
                if (seenCharacters.Contains(chars[i]))
                {
                    // Replace duplicate with the special character
                    chars[i] = specialChar;
                }
                else
                {
                    // Add character to the seen set
                    seenCharacters.Add(chars[i]);
                }
            }
        }
    }

}
