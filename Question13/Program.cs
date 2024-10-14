namespace Question13
{
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double DiscountedPrice { get; set; }

        public bool ValidateCandyFlavour()
        {
            // Check if the flavour is one of the valid ones
            return Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Candy candy = new Candy();

            // Get input from the user
            Console.Write("Enter the flavour: ");
            candy.Flavour = Console.ReadLine();

            Console.Write("Enter the quantity: ");
            candy.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the price per piece: ");
            candy.PricePerPiece = int.Parse(Console.ReadLine());

            // Validate the flavour
            if (!candy.ValidateCandyFlavour())
            {
                Console.WriteLine("Invalid flavour");
                return;
            }

            // Calculate the discounted price
            Candy discountedCandy = CalculateDiscountedPrice(candy);

            // Display the result
            Console.WriteLine($"Flavour : {discountedCandy.Flavour}");
            Console.WriteLine($"Quantity : {discountedCandy.Quantity}");
            Console.WriteLine($"Price Per Piece : {discountedCandy.PricePerPiece}");
            Console.WriteLine($"Total Price : {discountedCandy.TotalPrice}");
            Console.WriteLine($"Discount Price : {discountedCandy.DiscountedPrice}");
        }

        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            // Calculate total price
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

            // Determine the discount percentage based on the flavour
            double discountPercentage = 0;

            switch (candy.Flavour)
            {
                case "Strawberry":
                    discountPercentage = 15;
                    break;
                case "Lemon":
                    discountPercentage = 10;
                    break;
                case "Mint":
                    discountPercentage = 5;
                    break;
            }

            // Calculate discounted price
            candy.DiscountedPrice = candy.TotalPrice - (candy.TotalPrice * discountPercentage / 100);
            return candy;
        }
    }

}
