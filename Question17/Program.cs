namespace Question17
{
    public class Computer
    {
        // Properties for common computer characteristics
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }
    }

    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        public double DesktopPriceCalculation()
        {
            // Processor prices
            double processorCost = Processor switch
            {
                "i3" => 1500,
                "i5" => 3000,
                "i7" => 4500,
                _ => 0
            };

            // Other accessory prices
            double ramPrice = 200;
            double hardDiskPrice = 1500;
            double graphicCardPrice = 2500;
            double powerSupplyPrice = 20;
            double monitorPrice = 250;

            // Calculate the total price
            double totalPrice = processorCost +
                                (RamSize * ramPrice) +
                                (HardDiskSize * hardDiskPrice) +
                                (GraphicCard * graphicCardPrice) +
                                (MonitorSize * monitorPrice) +
                                (PowerSupplyVolt * powerSupplyPrice);

            return totalPrice;
        }
    }

    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public double LaptopPriceCalculation()
        {
            // Processor prices
            double processorCost = Processor switch
            {
                "i3" => 2500,
                "i5" => 5000,
                "i7" => 6500,
                _ => 0
            };

            // Other accessory prices
            double ramPrice = 200;
            double hardDiskPrice = 1500;
            double graphicCardPrice = 2500;
            double batteryPrice = 20;
            double displayPrice = 250;

            // Calculate the total price
            double totalPrice = processorCost +
                                 (RamSize * ramPrice) +
                                 (HardDiskSize * hardDiskPrice) +
                                 (GraphicCard * graphicCardPrice) +
                                 (DisplaySize * displayPrice) +
                                 (BatteryVolt * batteryPrice);

            return totalPrice;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Desktop");
            Console.WriteLine("2. Laptop");
            Console.Write("Choose the option: ");
            int choice = int.Parse(Console.ReadLine());

            Computer computer;

            if (choice == 1)
            {
                computer = new Desktop();
                Console.Write("Enter the processor: ");
                computer.Processor = Console.ReadLine();
                Console.Write("Enter the RAM size: ");
                computer.RamSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the hard disk size (in TB): ");
                computer.HardDiskSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the graphic card size (in GB): ");
                computer.GraphicCard = int.Parse(Console.ReadLine());
                ((Desktop)computer).MonitorSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the power supply volt: ");
                ((Desktop)computer).PowerSupplyVolt = int.Parse(Console.ReadLine());

                double totalPrice = ((Desktop)computer).DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is {totalPrice}");
            }
            else if (choice == 2)
            {
                computer = new Laptop();
                Console.Write("Enter the processor: ");
                computer.Processor = Console.ReadLine();
                Console.Write("Enter the RAM size: ");
                computer.RamSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the hard disk size (in TB): ");
                computer.HardDiskSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the graphic card size (in GB): ");
                computer.GraphicCard = int.Parse(Console.ReadLine());
                ((Laptop)computer).DisplaySize = int.Parse(Console.ReadLine());
                Console.Write("Enter the battery volt: ");
                ((Laptop)computer).BatteryVolt = int.Parse(Console.ReadLine());

                double totalPrice = ((Laptop)computer).LaptopPriceCalculation();
                Console.WriteLine($"Laptop price is {totalPrice}");
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
    }

}
