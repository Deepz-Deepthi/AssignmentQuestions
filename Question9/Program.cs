namespace Question9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // 2D array to hold marks for each student in 5 subjects
            int[,] stdMarks = new int[numberOfStudents, 5];

            // Input marks for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    stdMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Find students' ranks
            int[] ranks = FindStudentsRank(stdMarks);

            // Display the ranks
            for (int i = 0; i < ranks.Length; i++)
            {
                Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
            }
        }

        public static int[] FindStudentsRank(int[,] stdMarks)
        {
            int numberOfStudents = stdMarks.GetLength(0);
            int[] totalMarks = new int[numberOfStudents];

            // Calculate total marks for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    totalMarks[i] += stdMarks[i, j];
                }
            }

            // Create an array to hold ranks
            int[] ranks = new int[numberOfStudents];

            // Assign ranks based on total marks
            for (int i = 0; i < numberOfStudents; i++)
            {
                ranks[i] = 1; // Start with the highest rank
                for (int j = 0; j < numberOfStudents; j++)
                {
                    if (totalMarks[i] < totalMarks[j])
                    {
                        ranks[i]++;
                    }
                }
            }

            return ranks;
        }
    }

}
