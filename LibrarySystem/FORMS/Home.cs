using LibrarySystem.CLASSES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

namespace LibrarySystem.FORMS
{
    public partial class Home : Form
    {
        static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db");
        public Home()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Available_Books availableBooksForm = new Available_Books();
            availableBooksForm.ShowDialog();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Manage_Books manageBooksForm = new Manage_Books();
            manageBooksForm.ShowDialog();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Transactions transactionsForm = new Transactions();
            transactionsForm.ShowDialog();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AllocConsole();
            DisplayMenu();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        static extern bool FreeConsole();

        private void DisplayMenu()
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Open GUI");
            Console.WriteLine("6. Close");
            Console.WriteLine("================");
            HandleUserInput();
        }
        private void HandleUserInput()
        {
            while (true)
            {
                Console.Write("Enter your choice (1-6): ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Add Member selected");
                        AddMember();
                        break;
                    case "2":
                        Console.WriteLine("Remove Member selected");
                        RemoveMember();
                        break;
                    case "3":
                        Console.WriteLine("Borrow Book selected");
                        BorrowBook();
                        break;
                    case "4":
                        Console.WriteLine("Return Book selected");
                        ReturnBook();
                        break;
                    case "5":
                        this.Hide();
                        Home frm2 = new Home();
                        frm2.ShowDialog();
                        break;
                    case "6":
                        Console.WriteLine("Closing console...");
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        private void AddMember()
        {
            Member member = new Member();
            Console.Write("Enter Member Id:");

            if (int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.Write("Name: ");
                member.name = Console.ReadLine();
                Console.Write("Phone Number: ");
                member.phoneNumber = Console.ReadLine();

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `members`(`id`, `name`, `phone_number`, `borrowed_books`) VALUES (@id,@name,@phone_number,@borrowed_books)", connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@id", memberId);
                        cmd.Parameters.AddWithValue("@name", member.name);
                        cmd.Parameters.AddWithValue("@phone_number", member.phoneNumber);
                        cmd.Parameters.AddWithValue("@borrowed_books", member.borrowedBooks);
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Member ID {0} has been successfully added.", memberId);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding member to the database: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Member ID.");
            }
        }
        private void RemoveMember()
        {
            Console.Write("Enter Member ID to remove: ");
            if (int.TryParse(Console.ReadLine(), out int memberId))
            {
                try
                {
                    using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM members WHERE id = @id", connection))
                    {
                        connection.Open();
                        checkCmd.Parameters.AddWithValue("@id", memberId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        connection.Close();
                        if (count > 0)
                        {
                            using (MySqlCommand removeCmd = new MySqlCommand("DELETE FROM members WHERE id = @id", connection))
                            {
                                connection.Open();
                                removeCmd.Parameters.AddWithValue("@id", memberId);
                                removeCmd.ExecuteNonQuery();

                                Console.WriteLine("Member with ID {0} has been successfully removed.", memberId);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Member with ID {0} does not exist.", memberId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error removing member: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Member ID.");
            }
        }

        private void BorrowBook()
        {
            Console.Write("Enter Book ISBN: ");
            string bookISBN = Console.ReadLine();

            if (IsBookAvailable(bookISBN))
            {
                Console.WriteLine("Book with ISBN {0} is available.", bookISBN);
                Console.Write("Enter Member ID: ");
                if (int.TryParse(Console.ReadLine(), out int memberId))
                {
                    RecordBorrowTransaction(memberId, bookISBN);
                    UpdateMemberBorrowedBooks(memberId, bookISBN);
                    UpdateBookAvailability(bookISBN, false);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Member ID.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, the book with ISBN {0} is not available.", bookISBN);
            }
        }
        private void RecordBorrowTransaction(int memberId, string bookISBN)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO transactions (id, isbn, issued_date) VALUES (@id, @isbn, NOW())", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", memberId);
                    cmd.Parameters.AddWithValue("@isbn", bookISBN);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recording borrow transaction: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private bool IsBookAvailable(string bookISBN)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM books WHERE isbn = @isbn AND available = 1", connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@isbn", bookISBN);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
        }
        private void UpdateBookAvailability(string bookISBN, bool isAvailable)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE books SET available = @isAvailable WHERE isbn = @isbn", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@isbn", bookISBN);
                    cmd.Parameters.AddWithValue("@isAvailable", isAvailable ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Book with ISBN {0} availability updated.", bookISBN, isAvailable ? "available" : "not available");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating book availability: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void UpdateMemberBorrowedBooks(int memberId, string bookISBN)
        {
            try
            {
                string currentBorrowedBooks = string.Empty;
                using (MySqlCommand selectCmd = new MySqlCommand("SELECT borrowed_books FROM members WHERE id = @id", connection))
                {
                    connection.Open();
                    selectCmd.Parameters.AddWithValue("@id", memberId);
                    currentBorrowedBooks = selectCmd.ExecuteScalar() as string;
                    connection.Close();
                }
                string updatedBorrowedBooks = string.IsNullOrEmpty(currentBorrowedBooks)
                    ? bookISBN
                    : $"{currentBorrowedBooks}\n{bookISBN}";

                using (MySqlCommand updateCmd = new MySqlCommand("UPDATE members SET borrowed_books = @updatedBorrowedBooks WHERE id = @id", connection))
                {
                    connection.Open();
                    updateCmd.Parameters.AddWithValue("@id", memberId);
                    updateCmd.Parameters.AddWithValue("@updatedBorrowedBooks", updatedBorrowedBooks);
                    updateCmd.ExecuteNonQuery();
                    Console.WriteLine("Book with ISBN {0} has been successfully borrowed by Member ID {1}.", bookISBN, memberId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating member information: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void ReturnBook()
        {
            Console.Write("Enter Book ISBN: ");
            string bookISBN = Console.ReadLine();

            Console.Write("Enter Member ID: ");
            if (int.TryParse(Console.ReadLine(), out int memberId))
            {
                RecordReturnTransaction(memberId, bookISBN);
                UpdateMemberReturnedBooks(memberId, bookISBN);
                UpdateBookAvailability(bookISBN, true);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Member ID.");
            }
        }
        private void RecordReturnTransaction(int memberId, string bookISBN)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE transactions SET returned_date = CURRENT_TIMESTAMP WHERE id = @id AND isbn = @isbn AND returned_date IS NULL", connection))
                {
                    cmd.Parameters.AddWithValue("@id", memberId);
                    cmd.Parameters.AddWithValue("@isbn", bookISBN);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Return transaction recorded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recording return transaction: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void UpdateMemberReturnedBooks(int memberId, string bookISBN)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT borrowed_books FROM members WHERE id = @id", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", memberId);
                    string borrowedBooks = cmd.ExecuteScalar() as string;
                    connection.Close();
                    string updatedBorrowedBooks = borrowedBooks.Replace(bookISBN, "").Replace("\n\n", "\n").Trim();

                    using (MySqlCommand updateCmd = new MySqlCommand("UPDATE members SET borrowed_books = @updatedBorrowedBooks WHERE id = @id", connection))
                    {
                        connection.Open();
                        updateCmd.Parameters.AddWithValue("@id", memberId);
                        updateCmd.Parameters.AddWithValue("@updatedBorrowedBooks", updatedBorrowedBooks);
                        updateCmd.ExecuteNonQuery();
                        Console.WriteLine("Book with ISBN {0} has been successfully returned by Member ID {1}.", bookISBN, memberId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating member information: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Members_Details membersDetailsForm = new Members_Details();
            membersDetailsForm.ShowDialog();
        }
    }
}
