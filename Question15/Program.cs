namespace Question15
{
    public class Owner
    {
        protected string ownerName; // Protected field for the owner's name
    }

    public class Car : Owner
    {
        internal double price; // Internal field for the price
        internal string bodyStyle; // Internal field for the body style

        // Public property for accessing bodyStyle
        public string BodyStyle
        {
            get { return bodyStyle; }
             set { bodyStyle = value; }
        }

        // Method to validate the body style
        public bool ValidateBodyStyle(string bodyStyle)
        {
            return bodyStyle == "SUV" || bodyStyle == "Sedan";
        }

        // Method to calculate the discounted price
        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                return price - (price * 0.10); // 10% discount for SUVs
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 0.25); // 25% discount for Sedans
            }

            return 0; // Return 0 for invalid body styles
        }

        // Method to set the owner's name
        public void SetOwnerName(string name)
        {
            ownerName = name; // Set the owner's name
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            // Get the owner's name
            Console.Write("Enter the owner name: ");
            string ownerName = Console.ReadLine();
            car.SetOwnerName(ownerName); // Set owner's name

            // Get the car body style
            Console.Write("Enter the car body style: ");
            string bodyStyle = Console.ReadLine();
            car.BodyStyle = bodyStyle; // Set body style

            // Get the price
            Console.Write("Enter the price: ");
            car.price = double.Parse(Console.ReadLine());

            // Validate the body style
            if (!car.ValidateBodyStyle(bodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
                return; // Exit if invalid
            }

            // Calculate the final price
            double finalPrice = car.CalculatePrice();

            // Display the result
            Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${finalPrice}");
        }
    }

}
