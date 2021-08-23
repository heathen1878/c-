using Xunit;

namespace GradeBook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void TestStatistics()
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
    }
}
