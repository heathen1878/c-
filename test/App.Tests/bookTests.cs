using System;
using Xunit;

namespace App.Tests
{
    public class bookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var gradeBook = new book("");
            gradeBook.AddGrade(10.0);
            gradeBook.AddGrade(50.0);
            gradeBook.AddGrade(99.9);

            //act
            var result = gradeBook.ShowStatistics();

            //assert
            Assert.Equal(50.0, result.Average);
        }
    }
}
