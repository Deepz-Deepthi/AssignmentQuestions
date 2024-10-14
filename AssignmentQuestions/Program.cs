namespace AssignmentQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer value: ");
            int integerValue = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the float value: ");
            float floatValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the double value: ");
            double doubleValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the long value: ");
            long longValue = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the string data: ");
            string stringData = Console.ReadLine();


            Console.WriteLine($"int: {integerValue}");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"string: {stringData}");

        }
    }
}
