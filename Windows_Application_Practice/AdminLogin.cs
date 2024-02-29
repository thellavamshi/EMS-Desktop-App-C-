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

namespace Windows_Application_Practice
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=emsdb";

            string email = adminUsername.Text;
            string password = adminPassword.Text;

            string sqlCommand = "select * from admin_details where email='" + this.adminUsername.Text + "' and password='" + this.adminPassword.Text + "'";



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Username and Password . . . is Correct", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password is Not Correct . . . Please try again", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
