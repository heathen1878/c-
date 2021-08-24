using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Dom";
            string upper = MakeUpper(name);

            Assert.Equal("Dom", name);
            Assert.Equal("DOM", upper);
        }

        private string MakeUpper(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }
        
        private int GetInt()
        {
            return 3;
        }       
        
        private void SetInt(ref int x)
        {
            x = 42;
        }
        
        [Fact]
        public void PassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByRef(ref book1, "New Name");

            Assert.Equal("New Name", book1._name);

        }

        private void GetBookSetNameByRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void PassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByValue(book1, "New Name");

            Assert.Equal("Book 1", book1._name);

        }

        private void GetBookSetNameByValue(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetName()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1._name);

        }

        private void SetName(Book book, string name)
        {
            book._name = name;
        }


        [Fact]public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1._name);
            Assert.Equal("Book 2", book2._name);

        }

        [Fact]public void TwoVariablesCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // determine if both objects are the same
            Assert.Same(book1, book2);

        }


        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

