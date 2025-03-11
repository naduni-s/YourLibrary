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
    public partial class Members_Details : Form
    {
        public Members_Details()
        {
            InitializeComponent();
        }
        private void Members_Details_Load(object sender, EventArgs e)
        {
            DisplayMemberDetails();
        }
        private void DisplayMemberDetails()
        {
            DataTable dataTable = GetMemberDetailsFromDatabase();
            dataGridView_members.DataSource = dataTable;
            CustomizeDataGridView();
        }
        private DataTable GetMemberDetailsFromDatabase()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db"))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id, name, phone_number, borrowed_books FROM members", connection))
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
                MessageBox.Show("Error retrieving member details: " + ex.Message);
            }
            return dataTable;
        }
        private void CustomizeDataGridView()
        {
            dataGridView_members.DefaultCellStyle.Font = new Font("Arial", 12);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            dataGridView_members.ColumnHeadersDefaultCellStyle.Font = headerFont;

            dataGridView_members.Columns["id"].HeaderText = "ID";
            dataGridView_members.Columns["name"].HeaderText = "Name";
            dataGridView_members.Columns["phone_number"].HeaderText = "Phone Number";
            dataGridView_members.Columns["borrowed_books"].HeaderText = "Borrowed Books";

            dataGridView_members.Columns["id"].Width = 100;
            dataGridView_members.Columns["name"].Width = 200;
            dataGridView_members.Columns["phone_number"].Width = 150;
            dataGridView_members.Columns["borrowed_books"].Width = 200;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm2 = new Home();
            frm2.ShowDialog();
        }
    }
}
