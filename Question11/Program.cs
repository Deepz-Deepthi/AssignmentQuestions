namespace Question11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the total cost: ");
            // Read input from the user
            string input = Console.ReadLine();

            // Parse the input to double and box it into an object
            object totalCost = Convert.ToDouble(input);

            // Call the CalculateDiscountedPrice method
            object discountedPrice = CalculateDiscountedPrice(totalCost);

            // Display the result
            Console.WriteLine($"Price after discount is {discountedPrice}");
        }

        public static object CalculateDiscountedPrice(object totalCost)
        {
            // Unbox the object to double
            double cost = (double)totalCost;
            double discount;

            // Determine discount based on the total cost
            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost; // 5%
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost; // 15%
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost; // 30%
            }
            else
            {
                discount = 0; // No discount for costs below 100
            }

            // Calculate the discounted price
            double discountedPrice = cost - discount;

            // Box the result back to object and return
            return (object)discountedPrice;
        }
    }

}
