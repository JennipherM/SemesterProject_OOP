using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;

namespace FINALPROJECT_inventory_
{
    internal class SqlActions
    {

        private string connectionString = @"Data Source = localhost; Initial Catalog = LoginSystem; User ID = LibraryUser; Password = LibraryLab123!; TrustServerCertificate = True";

        private SqlConnection currConnection;
        private string sqlStatement ="";

        public bool checkExisting(string username)
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            sqlStatement = "SELECT Username FROM UserLogins WHERE Username = @Username";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            myQuery.Parameters.AddWithValue("@Username", username);

            string usernameDB = (string)myQuery.ExecuteScalar();

            currConnection.Close();

            if (usernameDB == username)
            {
                return true; // User exists 
            }
            return false;
        }

        public bool checkPassword(string username, string password)
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            sqlStatement = "SELECT Password FROM UserLogins WHERE Username = @Username";


            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Username", username);


            string passwordDB = (string)myQuery.ExecuteScalar();
            currConnection.Close();

            if (passwordDB == password)
            {
                return true;
            }
            return false;

        }
    }
}
