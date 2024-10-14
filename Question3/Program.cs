namespace Question3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                int j = 1;

                do
                {
                    Console.WriteLine(i + "" + j);
                    j++;
                }
                while (j <= 2);
                i++;
            }
            while(i <= 5);
        }
    }
}
