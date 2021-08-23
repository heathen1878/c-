using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // class methods
        public Book(string name)
        {
            // instantiate the list
            _grades = new List<double>();
            _name = name;
        }

        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }

        public Statistics ComputeStatistics()
        {
            var _result = new Statistics();
            _result.Average = 0.0;
            _result.High = double.MinValue;
            _result.Low = double.MaxValue;

            foreach (var _grade in _grades)
            {
                _result.Average += _grade;
                _result.High = Math.Max(_grade, _result.High);
                _result.Low = Math.Min(_grade, _result.Low);
               
            }
            _result.Average /= _grades.Count;

            return _result;
            
        }

        public void ShowStatistics(double average, double high, double low)
        {
            // Output to 1 decimal place
            Console.WriteLine($"The lowest grade is: {low:N1}");
            Console.WriteLine($"The highest grade is: {high:N1}");
            Console.WriteLine($"The average grade is: {average:N1}");
        }

        // Class fields
        private List<double> _grades;
        private string _name;

    }
}
