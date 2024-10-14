namespace Question2
{
    public class Movie
    {
        //static variable
        public static string name;
        //instance variable(non-static variable)
        public int ticketId;
        public string seatNumber;

        //creating a method
        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            //Assigning values for the variables
            Movie.name = name;
            this.ticketId = ticketId;
            this.seatNumber = seatNumber;

            return this;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //prompting for user input
            Console.WriteLine("Enter the Movie name: ");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter the ticket Id: ");
            int ticketId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seat number: ");
            string seatNumber = Console.ReadLine();

            //creating object for Movie and setting the details
            Movie movie = new Movie();
            movie=movie.ReturnMovieDetails(movieName, ticketId, seatNumber);

            //display movie details
            Console.WriteLine($"Movie name: {Movie.name}");
            Console.WriteLine($"Ticket Id: {movie.ticketId}");
            Console.WriteLine($"Seat Number: {movie.seatNumber}");
        }
    }
}
