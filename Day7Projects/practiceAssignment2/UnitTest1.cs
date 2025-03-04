namespace practiceAssignment2
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var book = new Book("Book Title", "Author Name", "12345");
            _library.AddBook(book);

            Assert.AreEqual(1, _library.Books.Count);
            Assert.AreEqual("Book Title", _library.Books[0].Title);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToLibrary()
        {
            var borrower = new Borrower("John Doe", "123");
            _library.RegisterBorrower(borrower);

            Assert.AreEqual(1, _library.Borrowers.Count);
            Assert.AreEqual("John Doe", _library.Borrowers[0].Name);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var book = new Book("Book Title", "Author Name", "12345");
            _library.AddBook(book);
            var borrower = new Borrower("John Doe", "123");
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("12345", "123");

            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var book = new Book("Book Title", "Author Name", "12345");
            _library.AddBook(book);
            var borrower = new Borrower("John Doe", "123");
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("12345", "123");
            _library.ReturnBook("12345", "123");

            Assert.IsFalse(book.IsBorrowed);
            Assert.IsFalse(borrower.BorrowedBooks.Contains(book));
        }

        [Test]
        public void ViewBooks_ShouldDisplayCorrectBookDetails()
        {
            var book = new Book("Book Title", "Author Name", "12345");
            _library.AddBook(book);

            var output = CaptureConsoleOutput(() => _library.ViewBooks());

            Assert.IsTrue(output.Contains("Book Title"));
        }

        [Test]
        public void ViewBorrowers_ShouldDisplayCorrectBorrowerDetails()
        {
            var borrower = new Borrower("John Doe", "123");
            _library.RegisterBorrower(borrower);

            var output = CaptureConsoleOutput(() => _library.ViewBorrowers());

            Assert.IsTrue(output.Contains("John Doe"));
        }

        private string CaptureConsoleOutput(Action action)
        {
            var sw = new StringWriter();
            Console.SetOut(sw);
            action();
            return sw.ToString();
        }

    }
}