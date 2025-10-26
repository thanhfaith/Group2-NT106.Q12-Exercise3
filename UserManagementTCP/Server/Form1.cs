using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                isRunning = true;
                lb_status.Text = "🟢 Server đang chạy...";
                Thread thread = new Thread(ListenForClients);
                thread.Start();
            }
        }
        private void ListenForClients()
        {
            while (isRunning)
            {
                TcpClient client = listener.AcceptTcpClient();
                string clientInfo = client.Client.RemoteEndPoint.ToString();
                Invoke(new Action(() => lstClients.Items.Add(clientInfo)));
                Thread thread = new Thread(() => HandleClient(client, clientInfo));
                thread.Start();
            }
        }

        private void HandleClient(TcpClient client, string clientInfo)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[2048];
                int byteCount = stream.Read(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, byteCount);
                string response = "";

                Log($"Từ {clientInfo}: {request}");

                if (request.StartsWith("REGISTER|"))
                {
                    string[] parts = request.Split('|');
                    if (parts.Length == 6)
                    {
                        string name = parts[1];
                        string phone = parts[2];
                        string email = parts[3];
                        string birthday = parts[4];
                        string password = parts[5];

                        bool success = DatabaseHelper.RegisterUser(name, password, email, phone, birthday);
                        response = success ? "Đăng ký thành công!" : "Tài khoản đã tồn tại!";
                    }
                    else response = "Dữ liệu không hợp lệ.";
                }
                else if (request.StartsWith("LOGIN|"))
                {
                    string[] parts = request.Split('|');
                    if (parts.Length == 3)
                    {
                        string username = parts[1];
                        string password = parts[2];

                        bool ok = DatabaseHelper.CheckLogin(username, password);
                        response = ok ? "Đăng nhập thành công!" : "Sai tài khoản hoặc mật khẩu!";
                    }
                    else response = "Dữ liệu không hợp lệ.";
                }
                else
                {
                    response = "Lệnh không hợp lệ.";
                }

                byte[] responseData = Encoding.UTF8.GetBytes(response);
                Log($"→ Gửi phản hồi tới {clientInfo}: {response}");
                stream.Write(responseData, 0, responseData.Length);
            }
            catch (Exception ex)
            {
                Log($"Lỗi từ {clientInfo}: {ex.Message}");
            }
            finally
            {
                client.Close();
                Invoke(new Action(() => lstClients.Items.Remove(clientInfo)));
                Log($"{clientInfo} đã ngắt kết nối.");
            }

        }

        private void Log(string message)
        {
            Invoke(new Action(() =>
            {
                tb_log.AppendText(message + Environment.NewLine);
            }));
        }
    }
}
