namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeBook = new Book("Pluralsight C# Fundamentals");
            gradeBook.AddGrade(92.1);
            gradeBook.AddGrade(56.8);
            gradeBook.AddGrade(75.3);
            gradeBook.AddGrade(45.9);

            // compute grades
            var stats = gradeBook.ComputeStatistics();

            // Show stats
            gradeBook.ShowStatistics(stats.Average, stats.High, stats.Low);

        }
    }
}
