using LibrarySystem.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.FORMS
{
    public partial class Manage_Books : Form
    {
        public Manage_Books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;
            string author = textBox_author.Text;
            string publisher = textBox_publisher.Text;
            string genre = textBox_genre.Text;
            string language = textBox_language.Text;

            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(publisher) || string.IsNullOrWhiteSpace(genre) || string.IsNullOrWhiteSpace(language))
            {
                MessageBox.Show("Please fill all text fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Library libraryInstance = new Library();
                if (!libraryInstance.isIsbnExists(isbn))
                {
                    if (!libraryInstance.isTitleExists(title))
                    {
                        Library bookInstance = new Library();
                        if (bookInstance.addBook(isbn, title, author, publisher, genre, language))
                        {
                            MessageBox.Show("Added successfully", "New book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView_books.DataSource = libraryInstance.BookList();
                        }
                        else
                        {
                            MessageBox.Show("Not added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This book Title already exists", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This book ISBN already exists", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isbn = Convert.ToString(textBox_isbn.Text);
            string title = textBox_title.Text;
            string author = textBox_author.Text;
            string publisher = textBox_publisher.Text;
            string genre = textBox_genre.Text;
            string language = textBox_language.Text;

            if (isbn.Trim().Equals(""))
            {
                MessageBox.Show("Enter isbn", "Empty book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Library bookInstance = new Library();
                if (bookInstance.editBook(isbn, title, author, publisher, genre, language))
                {
                    MessageBox.Show("Updated successfully", "Edit book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Library libraryInstance = new Library();
                    dataGridView_books.DataSource = libraryInstance.BookList();
                }
                else
                {
                    MessageBox.Show("Not updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isbn = Convert.ToString(textBox_isbn.Text);
            string title = textBox_title.Text;
            string author = textBox_author.Text;
            string publisher = textBox_publisher.Text;
            string genre = textBox_genre.Text;
            string language = textBox_language.Text;

            Library bookInstance = new Library();
            if (bookInstance.removeBook(isbn, title, author, publisher, genre, language))
            {
                MessageBox.Show("Deleted successfully", "Delete book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_isbn.Text = isbn;
                textBox_title.Text = title;
                textBox_author.Text = author;
                textBox_publisher.Text = publisher;
                textBox_genre.Text = genre;
                textBox_language.Text = language;

                Library libraryInstance = new Library();
                dataGridView_books.DataSource = libraryInstance.BookList();
            }
            else
            {
                MessageBox.Show("Not deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Manage_Books_Load(object sender, EventArgs e)
        {
            Library libraryInstance = new Library();
            dataGridView_books.DataSource = libraryInstance.BookList();
            dataGridView_books.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dataGridView_books.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_books.EnableHeadersVisualStyles = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }
        }

        private void button_searchByIsbn_Click(object sender, EventArgs e)
        {
            string isbn = textBox_isbn.Text;
            Library libraryInstance = new Library();
            DataTable data = libraryInstance.searchbookBy_Isbn(isbn);
            if (data.Rows.Count > 0)
            {
                textBox_isbn.Text = data.Rows[0][0].ToString();
                textBox_title.Text = data.Rows[0][1].ToString();
                textBox_author.Text = data.Rows[0][2].ToString();
                textBox_publisher.Text = data.Rows[0][3].ToString();
                textBox_genre.Text = data.Rows[0][4].ToString();
                textBox_language.Text = data.Rows[0][5].ToString();
            }
            else
            {
                MessageBox.Show("ISBN doesn't exist", "Exist-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm2 = new Home();
            frm2.ShowDialog();
        }
    }
}
