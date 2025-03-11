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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Hp\OneDrive\Pictures\user.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (username.Equals("Admin") && password.Equals("Admin123"))
            {
                MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home frm2 = new Home();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password. Try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
