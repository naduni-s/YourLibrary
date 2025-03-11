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

namespace LibrarySystem.FORMS
{
    public partial class Available_Books : Form
    {
        public Available_Books()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView_available != null)
            {
                DataTable dataTable = GetAvailableBooksFromDatabase();
                dataGridView_available.DataSource = dataTable;
                CustomizeDataGridView();
            }
            else
            {
                MessageBox.Show("DataGridView is not initialized.");
            }
        }
        private DataTable GetAvailableBooksFromDatabase()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db"))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT ISBN, Title, Author, Available FROM books WHERE available = 1", connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving available books: " + ex.Message);
            }
            return dataTable;
        }
        private void CustomizeDataGridView()
        {
            dataGridView_available.DefaultCellStyle.Font = new Font("Arial", 12);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            dataGridView_available.ColumnHeadersDefaultCellStyle.Font = headerFont;

            dataGridView_available.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView_available.Columns["Title"].HeaderText = "Title";
            dataGridView_available.Columns["Author"].HeaderText = "Author";
            dataGridView_available.Columns["Available"].HeaderText = "Availability";

            dataGridView_available.Columns["ISBN"].Width = 100;
            dataGridView_available.Columns["Title"].Width = 200;
            dataGridView_available.Columns["Author"].Width = 150;
            dataGridView_available.Columns["Available"].Width = 120;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm2 = new Home();
            frm2.ShowDialog();
        }
    }
}
