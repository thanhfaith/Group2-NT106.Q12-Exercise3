using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Server
{
    internal class DatabaseHelper
    {
        private static string connStr = "Data Source=LAPTOP-EDR1OHEC;Initial Catalog=UserDB;Integrated Security=True";

        public static string GetAllUsers()
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username, Email FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result += $"{reader["Username"]} - {reader["Email"]}\n";
                }
            }
            return result;
        }
        public static bool IsUsernameExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @e", conn);
                cmd.Parameters.AddWithValue("@e", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool RegisterUser(string fullname, string password, string email, string phone, string birthdayStr)
        {
            if (IsUsernameExists(email))
                return false;

            DateTime birthday;
            if (!DateTime.TryParse(birthdayStr, out birthday))
                birthday = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO Users (FullName, Username, Password, Email, Birthday) VALUES (@n, @u, @p, @e, @b)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", fullname);
                cmd.Parameters.AddWithValue("@u", email);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@b", birthday);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        public static bool CheckLogin(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @e AND Password = @p";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", password);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


    }
}
