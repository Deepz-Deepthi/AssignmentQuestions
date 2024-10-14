namespace Question18
{
    public class Product
    {
        // Method to calculate total price without discount
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            return price * quantity;
        }

        // Method to calculate total price with discount
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal totalPrice = price * quantity;
            decimal discountAmount = totalPrice * discountPercentage / 100;
            return totalPrice - discountAmount;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Calculate total price without discount
                decimal totalPriceWithoutDiscount = product.CalculateTotalPrice(price, quantity);
                Console.WriteLine($"Total price without discount: {totalPriceWithoutDiscount}");
            }
            else if (choice == 2)
            {
                // Calculate total price with discount
                Console.Write("Enter the discount percentage: ");
                int discountPercentage = int.Parse(Console.ReadLine());

                decimal totalPriceWithDiscount = product.CalculateTotalPrice(price, quantity, discountPercentage);
                Console.WriteLine($"Total price with discount: {totalPriceWithDiscount}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

}
