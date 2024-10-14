namespace Question20
{
    public abstract class Employee
    {
        // Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        // Method to validate employee ID
        public bool ValidateEmployeeId()
        {
            if (Id.Length != 5) return false;
            if (!Id.StartsWith("EM")) return false;
            if (!int.TryParse(Id.Substring(2), out _)) return false;
            return true;
        }

        // Abstract method for salary calculation
        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        // Implementing the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            double da = BasicPay * 0.50; // 50% of Basic Pay
            double hra = BasicPay * 0.30; // 30% of Basic Pay
            Salary = BasicPay + da + hra;
            return this;
        }
    }

    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        // Implementing the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages;
            return this;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");
            Console.Write("Choose the employee type: ");
            int employeeType = int.Parse(Console.ReadLine());

            Employee employee = null;

            // Getting common employee details
            Console.Write("Enter the employee id: ");
            string id = Console.ReadLine();

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            if (employeeType == 1) // Permanent
            {
                employee = new Permanent();
                Console.Write("Enter basic pay: ");
                ((Permanent)employee).BasicPay = double.Parse(Console.ReadLine());
            }
            else if (employeeType == 2) // Temporary
            {
                employee = new Temporary();
                Console.Write("Enter hours worked: ");
                ((Temporary)employee).HrsWorked = int.Parse(Console.ReadLine());
                Console.Write("Enter hourly wages: ");
                ((Temporary)employee).HrlyWages = int.Parse(Console.ReadLine());
            }

            // Set the common properties
            employee.Id = id;
            employee.Name = name;

            // Validate ID
            if (employee.ValidateEmployeeId())
            {
                employee.SalaryCalculation();
                Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
        }
    }

}
