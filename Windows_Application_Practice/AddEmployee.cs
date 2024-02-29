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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=123456;database=emsdb";

            string firstName = txtEmpFirstName.Text;
            string middleName = txtEmpMiddleName.Text;
            string lastName = txtEmpLastName.Text;
            string gender = txtEmpGender.Text;
            string dob = txtEmpDob.Text;
            string mobileNo = txtEmpMobileNo.Text;
            string personalEmail = txtEmpPersonalEmail.Text;
            string address = txtEmpAddress.Text;
            long empId = Convert.ToInt64(txtEmpEmployeeId.Text);
            string workEmail = txtEmpWorkEmail.Text;
            string department = txtEmpDept.Text;
            string hireDate = txtEmpHireDate.Text;
            

           
            string sqlCommand = "INSERT INTO EMPLOYEE (first_name, middle_name, last_name, gender, dob, mobile_no, personal_email, address, emp_id, work_email, department, hire_date) " +
                        "VALUES (@firstName, @middleName, @lastName, @gender, @dob, @mobileNo, @personalEmail, @address, @empId, @workEmail, @department, @hireDate )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@middleName", middleName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@mobileNo", mobileNo);
                command.Parameters.AddWithValue("@personalEmail", personalEmail);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@empId", empId);
                command.Parameters.AddWithValue("@workEmail", workEmail);
                command.Parameters.AddWithValue("@department", department);
                command.Parameters.AddWithValue("hireDate", hireDate);
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
                    txtEmpFirstName.Text = "";
                    txtEmpMiddleName.Text = "";
                    txtEmpLastName.Text = "";
                    txtEmpGender.Text = "";
                    txtEmpDob.Text = "";
                    txtEmpMobileNo.Text = "";
                    txtEmpPersonalEmail.Text = "";
                    txtEmpAddress.Text = "";
                    txtEmpEmployeeId.Text = "";
                    txtEmpWorkEmail.Text = "";
                    txtEmpDept.Text = "";
                    txtEmpHireDate.Text = "";
                   
                }
            }
        }
    }
}
