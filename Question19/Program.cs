namespace Question19
{
    public class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Virtual method to calculate cost
        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice; // Default implementation
        }
    }

    public class SportsCar : Car
    {
        // Overriding the CalculateCost method
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double age = currentYear - Year;
            double fixedTaxRate = 0.10; // 10%
            double totalTax = basePrice * fixedTaxRate * age;
            return basePrice + totalTax;
        }
    }

    public class SUV : Car
    {
        // Overriding the CalculateCost method
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double age = currentYear - Year;
            double fixedTaxRate = 0.05; // 5%
            double totalTax = basePrice * fixedTaxRate * age;
            return basePrice + totalTax;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            Car car = null;

            // Get common car details
            Console.Write("Enter the make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the year the car was made: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the basic price: ");
            double basePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the current year: ");
            int currentYear = int.Parse(Console.ReadLine());

            // Create specific car type based on user choice
            if (option == 1)
            {
                car = new SportsCar { Make = make, Model = model, Year = year };
                double cost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"Sports car cost is {cost}");
            }
            else if (option == 2)
            {
                car = new SUV { Make = make, Model = model, Year = year };
                double cost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"SUV car cost is {cost}");
            }
            else
            {
                Console.WriteLine("The cost is not calculated for this type.");
            }
        }
    }

}
