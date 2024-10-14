namespace Question21
{
    public class Account
    {
        // Properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Method to deposit an amount
        public decimal Deposit(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    Balance += amount;
                    return Balance;
                }
                else
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance; // Return the current balance
            }
        }

        // Method to withdraw an amount
        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                else if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                else
                {
                    Balance -= amount;
                    return Balance;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance; // Return the current balance
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance; // Return the current balance
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the account number: ");
            account.AccountNumber = Console.ReadLine();

            Console.Write("Enter the balance: ");
            account.Balance = decimal.Parse(Console.ReadLine());

            if (choice == 1) // Deposit
            {
                Console.Write("Enter the amount to be deposited: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                decimal newBalance = account.Deposit(depositAmount);
                Console.WriteLine($"Balance amount: {newBalance}");
            }
            else if (choice == 2) // Withdraw
            {
                Console.Write("Enter the amount to be withdrawn: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                decimal newBalance = account.Withdraw(withdrawAmount);
                Console.WriteLine($"Balance amount: {newBalance}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

}
