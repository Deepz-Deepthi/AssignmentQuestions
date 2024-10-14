using System;

public class Book
{
    // Private fields for book details
    private string title;
    private string author;
    private int numPages;
    private DateTime dueDate;
    private DateTime returnedDate;

    // Default constructor
    public Book()
    {
        title = string.Empty;
        author = string.Empty;
        numPages = 0;
        dueDate = DateTime.MinValue;
        returnedDate = DateTime.MinValue;
    }

    // Parameterized constructor
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }

    // Method to calculate average pages read per day
    public double AveragePagesReadPerDay(int daysToRead)
    {
        return (double)numPages / daysToRead;
    }

    // Method to calculate late fee
    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int daysLate = (returnedDate - dueDate).Days;
        if (daysLate > 0)
        {
            return daysLate * dailyLateFeeRate;
        }
        return 0; // No late fee if returned on or before due date
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Get user input
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author: ");
        string author = Console.ReadLine();

        Console.Write("Enter the number of pages: ");
        int numPages = int.Parse(Console.ReadLine());

        Console.Write("Enter the due date (MM/dd/yyyy): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the return date (MM/dd/yyyy): ");
        DateTime returnedDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the days to read: ");
        int daysToRead = int.Parse(Console.ReadLine());

        Console.Write("Enter the daily late fee rate: ");
        double dailyLateFeeRate = double.Parse(Console.ReadLine());

        // Create a Book object using the parameterized constructor
        Book book = new Book(title, author, numPages, dueDate, returnedDate);

        // Calculate average pages read per day and late fee
        double averagePages = book.AveragePagesReadPerDay(daysToRead);
        double lateFee = book.CalculateLateFee(dailyLateFeeRate);

        // Display the results
        Console.WriteLine($"Average Pages Read Per Day: {averagePages}");
        Console.WriteLine($"Late Fee: {lateFee}");
    }
}
