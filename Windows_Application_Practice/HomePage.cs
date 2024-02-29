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
    public partial class Form1 : Form
    {
        private const string connectionString = "server=localhost;uid=root;pwd=123456;database=emsdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteSqlCommand(string sqlCommand)
        {
            using(MySqlConnection  connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sqlCommand , connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} rows affected.", "Connected to database", MessageBoxButtons.OK);
                }catch (Exception ex)
                {
                    MessageBox.Show($"Error executing the SQL command:  {ex.Message}", "Error", MessageBoxButtons.OKCancel);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sqlCommand = "CREATE TABLE admin_details ( first_name varchar(255), last_name varchar(255), email varchar(255), gender varchar(255), password varchar(255),confirm_password varchar(255), company_code int, PRIMARY KEY(email) )";
            ExecuteSqlCommand(sqlCommand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            AdminRegistration adminRegistration = new AdminRegistration();
            adminRegistration.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            EmployeeLogin empLogin = new EmployeeLogin();
            empLogin.Show();
        }
    }
}
