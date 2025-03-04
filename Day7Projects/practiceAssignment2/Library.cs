using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceAssignment2
{

    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Borrow();
                borrower.BorrowBook(book);
            }
            else
            {
                throw new InvalidOperationException("Either the book is already borrowed or the borrower is not registered.");
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && b.IsBorrowed);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Return();
                borrower.ReturnBook(book);
            }
            else
            {
                throw new InvalidOperationException("Book is not borrowed or borrower is not registered.");
            }
        }

        public void ViewBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Borrowed: {book.IsBorrowed}");
            }
        }

        public void ViewBorrowers()
        {
            foreach (var borrower in Borrowers)
            {
                Console.WriteLine($"Name: {borrower.Name}, Library Card: {borrower.LibraryCardNumber}");
                if (borrower.BorrowedBooks.Any())
                {
                    Console.WriteLine("Borrowed Books:");
                    foreach (var borrowedBook in borrower.BorrowedBooks)
                    {
                        Console.WriteLine($"- {borrowedBook.Title}");
                    }
                }
                else
                {
                    Console.WriteLine("No borrowed books.");
                }
            }
        }
    }

}
