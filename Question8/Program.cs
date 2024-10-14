namespace Question8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            string[] productDetails = new string[numberOfProducts];

            Console.WriteLine("Enter the product details (ID:Name:Price):");
            for (int i = 0; i < numberOfProducts; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            Console.Write("Enter the product id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to update: ");
            double amount = double.Parse(Console.ReadLine());

            string result = UpdatePrice(productDetails, productId, amount);
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                // Split the product details
                string[] productInfo = details[i].Split(':');
                if (int.Parse(productInfo[0]) == id)
                {
                    // Update the price
                    productInfo[2] = amount.ToString();
                    return $"{productInfo[1]} {productInfo[2]}";
                }
            }
            return string.Empty; // Return empty string if ID is not found
        }
    }

}
