namespace Question4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word :");
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray();
            for(int i = 0; i < charArray.Length; i++)
            {
                if(i %  2 == 0)
                {
                    charArray[i] = Char.ToUpper(charArray[i]);
                }
                else
                {
                    charArray[i] = Char.ToLower(charArray[i]);
                }
            }
            Console.WriteLine(new string(charArray));
        }
    }
}

