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
        private static string connStr = "Data Source=LAPTOP-EDR1OHEC;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True";

        public static string GetAllUsers()
        {
            StringBuilder result = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username, Email FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.AppendLine($"{reader["Username"]} - {reader["Email"]}");
                }
            }
            return result.ToString();
        }
        public static bool IsEmailExists(string email)
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
            if (IsEmailExists(email))
                return false;

            DateTime birthday;
            if (!DateTime.TryParse(birthdayStr, out birthday))
                birthday = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO Users (FullName, Username, Password, Email, Birthday, Phone) VALUES (@n, @u, @p, @e, @b, @ph)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", fullname);
                cmd.Parameters.AddWithValue("@u", email);
                cmd.Parameters.AddWithValue("@p", password);

                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@b", birthday);
                cmd.Parameters.AddWithValue("@ph", phone); 
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        public static bool Authenticate(string email, string password)
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

        public static int GetUserIdByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT UserId FROM Users WHERE Email = @e";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    return -1; 
                }
            }
        }

        public static Dictionary<string, string> GetUserDetails(string email)
        {
            var userDetails = new Dictionary<string, string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT FullName, Email, Birthday FROM Users WHERE Email = @e";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userDetails["FullName"] = reader["FullName"].ToString();
                            userDetails["Email"] = reader["Email"].ToString();

                            object birthdayObj = reader["Birthday"];
                            if (birthdayObj != DBNull.Value && birthdayObj != null)
                            {
                                userDetails["Birthday"] = ((DateTime)birthdayObj).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                userDetails["Birthday"] = "Chưa cập nhật";
                            }
                        }
                    }
                }
            }
            return userDetails;
        }
    }
}
