# 🧩 Group2-NT106.Q12-Exercise3 – Ứng dụng Quản lý Người Dùng

## 📘 Giới thiệu
- Ứng dụng quản lý người dùng (User Management App) viết bằng C# (Windows Forms), với tính năng đăng nhập và đăng ký sử dụng TCP Socket.
- Chương trình cho phép người dùng đăng ký, đăng nhập, xem thông tin cá nhân và đăng xuất, đồng thời lưu trữ dữ liệu trong SQL Server.
- Ứng dụng áp dụng đa luồng (multi-threading) để xử lý nhiều kết nối đồng thời, giúp hệ thống hoạt động ổn định và hiệu quả.
- Mật khẩu được mã hóa bằng SHA-256 nhằm đảm bảo an toàn thông tin người dùng.

## 👥 Thành viên nhóm
| STT | Họ và tên          | MSSV       | Username      | Nhiệm vụ                 |
|-----|--------------------|------------|---------------|--------------------------|
| 1   | Trần Phú Thành     | 24521641   | thanhfaith    | Tích hợp đăng ký/đăng nhập với server & hash |
| 2   | Võ Diệp Thành      | 24521644   | Vo-Thanh-06   | Tạo database, server nền |
| 3   | Nguyễn Tấn Vũ      | 24522038   | tanvu0909     | Viết module mã hóa |
| 4   | Nguyễn Phạm Yến Vy | 24522060   | npyvyy        | Thiết kế giao diện người dùng |
| 5   | Liên Ngọc Châu     | 24520209   | Jchaungocln   | Cấp phát token khi đăng nhập thành công |
