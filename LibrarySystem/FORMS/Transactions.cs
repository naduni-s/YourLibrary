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
using System.Transactions;
using System.Windows.Forms;

namespace LibrarySystem.FORMS
{
    public partial class Transactions : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;port=3306;username=root;password=;database=library_db";
        public Transactions()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        private void Transactions_Load(object sender, EventArgs e)
        {
            DataTable dataTable = GetAllTransactions();
            dataGridView_transactions.DataSource = dataTable;
            dataGridView_transactions.Columns["issued_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dataGridView_transactions.Columns["returned_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dataGridView_transactions.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView_transactions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            
        }
        private DataTable GetAllTransactions()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM transactions";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving transactions: " + ex.Message);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm2 = new Home();
            frm2.ShowDialog();
        }
    }
}
