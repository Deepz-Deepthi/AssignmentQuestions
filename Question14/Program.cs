namespace Question14
{
    using System;

    public class Owner
    {
        protected string ownerName;
    }
                             
    public class Car : Owner
    {
        internal double price;
        internal string bodyStyle;

        public string BodyStyle
        {
            get { return bodyStyle; }
             set { bodyStyle = value; }
        }

        public bool ValidateBodyStyle(string bodyStyle)
        {
            return bodyStyle == "SUV" || bodyStyle == "Sedan";
        }

        public double CalculatePrice()
        {
            double discountedPrice = 0;

            if (bodyStyle == "SUV")
            {
                discountedPrice = price - (price * 0.10); // 10% discount
            }
            else if (bodyStyle == "Sedan")
            {
                discountedPrice = price - (price * 0.25); // 25% discount
            }

            return discountedPrice > 0 ? discountedPrice : 0; // Return 0 for invalid body styles
        }

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

            // Get the owner name
            Console.Write("Enter the owner name: ");
            string ownerName = Console.ReadLine();
            car.SetOwnerName(ownerName); // Set owner name

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

            // Calculate the discounted price
            double finalPrice = car.CalculatePrice();

            // Display the result
            Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${finalPrice}");
        }
    }

}
