using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class DataHelper
    {
        internal class DatabaseSetup
        {
            private static string connStr = "Data Source=DESKTOP-9Q6P0AS\\MSSQLSERVER01;Initial Catalog=UserDB;Integrated Security=True";

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
        }
    }
}

