using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        
        private const string JWT_SECRET_KEY = "DayLaKhoaBiMatSieuCapViProCuaToi_32_KyTu_TroLen";

        private static JwtHelper jwtHelper;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            jwtHelper = new JwtHelper(JWT_SECRET_KEY);

            Form1 mainForm = new Form1();

            Task.Run(() => StartServer(mainForm));

            Application.Run(mainForm);
        }

        static void StartServer(Form1 mainForm)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 8888);
            try
            {
                server.Start();
                isRunning = true;
                mainForm.Log("Server started. Waiting for connections...");

                while (isRunning)
                {
                    TcpClient client = server.AcceptTcpClient();

                    ClientHandler clientHandler = new ClientHandler(client, jwtHelper, mainForm);
                    Thread clientThread = new Thread(new ThreadStart(clientHandler.Process));
                    clientThread.Start();
                }
            }
            catch (SocketException)
            {
               
            }
            finally
            {
                server.Stop();
                mainForm.Log("Server stopped.");
            }
        }
    }
}
