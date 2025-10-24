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

                Log($"Từ {clientInfo}: {request}");
                string response = $"Server đã nhận: {request}";
                byte[] responseData = Encoding.UTF8.GetBytes(response);
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
