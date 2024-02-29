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
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void adminSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=emsdb";

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string gender = txtGender.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            int companyCode = Convert.ToInt32(intCompanyCode.Text);

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlCommand = "INSERT INTO admin_details (first_name, last_name, email, gender, password, confirm_password, company_code) " +
                        "VALUES (@firstName, @lastName, @email, @gender, @password, @confirmPassword, @companyCode )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@confirmPassword", confirmPassword);
                command.Parameters.AddWithValue("@companyCode", companyCode);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} rows inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtGender.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    intCompanyCode.Text = "";
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            intCompanyCode.Text = "";
        }
    }
}
