namespace Question10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Create a jagged array for storing points for each student
            int[][] points = new int[numberOfStudents][];

            // Input points for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter the number of competitions attended by student {i + 1}: ");
                int numberOfCompetitions = int.Parse(Console.ReadLine());

                points[i] = new int[numberOfCompetitions]; // Initialize the sub-array for each student

                Console.WriteLine($"Enter the student {i + 1} points:");
                for (int j = 0; j < numberOfCompetitions; j++)
                {
                    points[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Find who got maximum points
            string result = FindWhoGotMaximumPoints(points);
            Console.WriteLine(result);
        }

        public static string FindWhoGotMaximumPoints(int[][] points)
        {
            int maxPoints = 0;
            int studentIndex = -1;

            // Calculate total points for each student and find the maximum
            for (int i = 0; i < points.Length; i++)
            {
                int totalPoints = 0;

                for (int j = 0; j < points[i].Length; j++)
                {
                    totalPoints += points[i][j];
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentIndex = i; // Keep track of the student with the maximum points
                }
            }

            return studentIndex != -1 ? $"Student {studentIndex + 1} got maximum points" : "No points available";
        }
    }

}
