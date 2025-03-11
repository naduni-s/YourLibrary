using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.CLASSES
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }

        static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db");
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Availability = true;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Availability: {(Availability ? "Available" : "Not Available")}");
        }
        public bool CheckAvailability()
        {
            return Availability;
        }
        public void BorrowBook()
        {
            if (Availability)
            {
                Console.WriteLine($"Book '{Title}' has been borrowed.");
                Availability = false;
            }
            else
            {
                Console.WriteLine($"Sorry, book '{Title}' is not available for borrowing.");
            }
        }
        public void ReturnBook()
        {
            Console.WriteLine($"Book '{Title}' has been returned.");
            Availability = true;
        }
    }
}
