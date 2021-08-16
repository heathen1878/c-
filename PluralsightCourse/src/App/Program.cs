using System;
using System.Collections.Generic;

namespace App
{
    class book
    {
        public book(string name)
        {
            // instantsiate the list
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }  

        public void ShowStatistics()
        {
            // result variable
            var result = 0.0;

            // variable for highest grade
            var highest = double.MinValue;

            //variable for the lowest grade
            var lowest = double.MaxValue;

            foreach(var number in grades){
                
                highest = Math.Max(number, highest);
                lowest = Math.Min(number, lowest);
                result += number;
            }

            Console.WriteLine($"The lowest grade is: {lowest}");
            Console.WriteLine($"The highest grade is: {highest}");
            Console.WriteLine($"The average grade is: {result / grades.Count:N1}");

        }

        // define the list
        private List<double> grades;
        private string name;

    }
    class Program
    {
        static void Main()
        {
            var gradeBook = new book("Pluralsight C# Fundamentals");
            gradeBook.AddGrade(92.1);
            gradeBook.AddGrade(56.8);
            gradeBook.AddGrade(75.3);
            gradeBook.AddGrade(45.9);
            gradeBook.ShowStatistics();

        }
    }
}
