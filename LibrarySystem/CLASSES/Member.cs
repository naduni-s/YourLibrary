using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem;
using System.Xml.Linq;

namespace LibrarySystem.CLASSES
{
    internal class Member
    {
        public int memberId;
        public string name;
        public string phoneNumber;
        public int borrowedBooks = 0;
        public int x;

        public string Name { get; }
        public int MembershipID { get; }
        private List<Book> BorrowedBooks;

        static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db");

        public void BorrowBook(Book book)
        {
            if (book.CheckAvailability())
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Book '{book.Title}' has been borrowed by {Name}.");
                book.BorrowBook();
            }
            else
            {
                Console.WriteLine($"Sorry, book '{book.Title}' is not available for borrowing.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                Console.WriteLine($"Book '{book.Title}' has been returned by {Name}.");
                book.ReturnBook();
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' was not borrowed by {Name}.");
            }
        }
        public void ListBorrowedBooks()
        {
            Console.WriteLine($"Borrowed books by {Name}:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}
