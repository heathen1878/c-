using Xunit;

namespace GradeBook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void TestBookHighLowAverageCompute()
        {
            // arrange tests
            var book = new Book("");
            book.AddGrade(90.5);
            book.AddGrade(89.3);
            book.AddGrade(52.7);

            // act - produce a result
            var testResult = book.ComputeStatistics();

            // assert - test
            Assert.Equal(77.5, testResult.Average, 1);
            Assert.Equal(90.5, testResult.High, 1);
            Assert.Equal(52.7, testResult.Low, 1);
         
        }

        [Fact]
        public void TestAddingOfNegativeGrade()
        {
            var book = new Book("Test");
            book.AddGrade(-1);

            var testResult = book.ComputeStatistics();

            Assert.Equal(0, testResult.High);
            Assert.Equal(0, testResult.Low);
            Assert.Equal(0, testResult.Average);

        }

        [Fact]
        public void TestAddingOfGradeAbove100()
        {
            var book = new Book("Test");
            book.AddGrade(105);

            var testResult = book.ComputeStatistics();

            Assert.Equal(0, testResult.High);
            Assert.Equal(0, testResult.Low);
            Assert.Equal(0, testResult.Average);

        }

        [Fact]
        public void TestAddingOfValidGrade()
        {
            var book = new Book("Test");
            book.AddGrade(50);

            var testResult = book.ComputeStatistics();

            Assert.Equal(50, testResult.High);
            Assert.Equal(50, testResult.Low);
            Assert.Equal(50, testResult.Average);

        }
    }
}
