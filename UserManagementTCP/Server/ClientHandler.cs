using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ClientHandler
    {
        private TcpClient client;
        private JwtHelper jwtHelper; 
        private Form1 serverForm;  
        private NetworkStream stream;

        public ClientHandler(TcpClient client, JwtHelper jwtHelper, Form1 serverForm)
        {
            this.client = client;
            this.jwtHelper = jwtHelper;
            this.serverForm = serverForm;

            this.stream = client.GetStream();
        }

        public void Process()
        {
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while (Program.isRunning && (bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    serverForm.Log($"Nhận từ {client.Client.RemoteEndPoint}: {request}");

                    string response = HandleMessage(request);

                    byte[] responseData = Encoding.UTF8.GetBytes(response + "\n");
                    stream.Write(responseData, 0, responseData.Length);
                    serverForm.Log($"Gửi cho {client.Client.RemoteEndPoint}: {response}");
                }
            }
            catch (IOException)
            {
                serverForm.Log($"Client {client.Client.RemoteEndPoint} đã ngắt kết nối.");
            }
            catch (Exception ex)
            {
               
                serverForm.Log($"Lỗi từ {client.Client.RemoteEndPoint}: {ex.Message}");
            }
            finally
            {
                client.Close();
                
                serverForm.Invoke(new Action(() =>
                    serverForm.RemoveClientFromList(client.Client.RemoteEndPoint.ToString())
                ));
            }
        }

        private string HandleMessage(string message)
        {
            try
            {
                string[] parts = message.Split('|');
                string command = parts[0];

                if (command == "LOGIN")
                {
                    string email = parts[1];
                    string hashedPassword = parts[2];

                    bool isAuthenticated = DatabaseHelper.Authenticate(email, hashedPassword);
                    if (isAuthenticated)
                    {
                        int userId = DatabaseHelper.GetUserIdByEmail(email);
                        if (userId == -1) return "LOGIN_FAIL|Lỗi không tìm thấy UserId";

                        string jwtToken = jwtHelper.GenerateToken(email, userId);
                        return $"LOGIN_SUCCESS|{jwtToken}";
                    }
                    else
                    {
                        return "LOGIN_FAIL|Sai email hoặc mật khẩu";
                    }
                }

                if (command == "REGISTER")
                {
                    string regFull = parts[1];
                    string regPassHashed = parts[2];
                    string regEmail = parts[3];
                    string regBdayStr = parts[4];

                    bool regSuccess = DatabaseHelper.RegisterUser(regFull, regPassHashed, regEmail, regBdayStr);

                    if (regSuccess)
                    {
                        return "REGISTER_SUCCESS";
                    }
                    else
                    {
                        return "REGISTER_FAIL|Email đã tồn tại";
                    }
                }

                if (parts.Length < 2)
                {
                    return "ERROR|Yêu cầu không hợp lệ (thiếu token)";
                }

                string token = parts[1];

                ClaimsPrincipal claims = jwtHelper.ValidateToken(token);
                if (claims == null)
                {
                    return "ERROR|Token không hợp lệ hoặc đã hết hạn";
                }
                 string emailFromToken = claims.Identity.Name;

                switch (command)
                {
                    case "GET_INFO":
           
                        var details = DatabaseHelper.GetUserDetails(emailFromToken);
                        if (details.Count == 0) return "ERROR|Không tìm thấy thông tin user";

                        return $"USER_INFO|{details["Email"]}|{details["FullName"]}|{details["Birthday"]}";

                    case "LOGOUT":
                   
                        return "LOGOUT_SUCCESS";

                    default:
                        return "ERROR|Lệnh không được hỗ trợ";
                }
            }
            catch (Exception ex)
            {
                serverForm.Log($"Lỗi xử lý tin nhắn: {ex.Message}");
                return $"ERROR|Server gặp lỗi: {ex.Message}";
            }
        }
    }
}
