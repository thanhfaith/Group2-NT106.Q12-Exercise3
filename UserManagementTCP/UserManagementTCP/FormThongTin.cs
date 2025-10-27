using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;


namespace UserManagementTCP
{
    public partial class FormThongTin : Form
    {
        private string username;
        private string connectionString = "Data Source=LAPTOP-EDR1OHEC;Initial Catalog=UserDB;Integrated Security=True";
        public FormThongTin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName, Username, Email, Birthday FROM Users WHERE Username = @u";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtHoTen.Text = reader["FullName"].ToString();
                            txtSDT.Text = reader["Username"].ToString();
                            txtEmail.Text = reader["Email"].ToString();

                            if (DateTime.TryParse(reader["Birthday"].ToString(), out DateTime birthday))
                                txtNgaySinh.Text = birthday.ToString("dd/MM/yyyy");
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
