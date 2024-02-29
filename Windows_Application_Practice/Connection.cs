using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Windows_Application_Practice
{
    internal class Connection
    {
        public static MySqlConnection connection()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost; database=database; uID=root; pwd=123456;");
                con.Open();
                string query = "CREATE TABLE Employee_VS (Id INT PRIMARY KEY, FirstName VARCHAR(50),LastName VARCHAR(50),  Email VARCHAR(100),    Gender VARCHAR(10),    Password VARCHAR(100))";
                SqlCommand command = new SqlCommand(query);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
    }
}
