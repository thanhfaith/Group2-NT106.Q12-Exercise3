namespace UserManagementTCP
{
    partial class FormDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtNgaySinh = new TextBox();
            txtMatKhau = new TextBox();
            txtNLMK = new TextBox();
            label8 = new Label();
            llbDangNhap = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(184, 35);
            label1.Name = "label1";
            label1.Size = new Size(450, 45);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.ForeColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(116, 140);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F);
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(116, 207);
            label3.Name = "label3";
            label3.Size = new Size(163, 33);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(116, 273);
            label4.Name = "label4";
            label4.Size = new Size(89, 33);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16.2F);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(116, 341);
            label5.Name = "label5";
            label5.Size = new Size(127, 33);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 16.2F);
            label6.ForeColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(116, 410);
            label6.Name = "label6";
            label6.Size = new Size(121, 33);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 16.2F);
            label7.ForeColor = Color.FromArgb(255, 192, 192);
            label7.Location = new Point(116, 478);
            label7.Name = "label7";
            label7.Size = new Size(218, 33);
            label7.TabIndex = 6;
            label7.Text = "Nhập lại mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(255, 128, 128);
            btnDangKy.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = SystemColors.ControlText;
            btnDangKy.Location = new Point(447, 551);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(225, 58);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.ForeColor = Color.Black;
            txtHoTen.Location = new Point(382, 124);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(356, 49);
            txtHoTen.TabIndex = 8;
            txtHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSDT
            // 
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(382, 191);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(356, 49);
            txtSDT.TabIndex = 9;
            txtSDT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(382, 257);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 49);
            txtEmail.TabIndex = 10;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.ForeColor = Color.Black;
            txtNgaySinh.Location = new Point(382, 325);
            txtNgaySinh.Multiline = true;
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(356, 49);
            txtNgaySinh.TabIndex = 11;
            txtNgaySinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatKhau
            // 
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(382, 394);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(356, 49);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNLMK
            // 
            txtNLMK.ForeColor = Color.Black;
            txtNLMK.Location = new Point(382, 462);
            txtNLMK.Multiline = true;
            txtNLMK.Name = "txtNLMK";
            txtNLMK.PasswordChar = '*';
            txtNLMK.Size = new Size(356, 49);
            txtNLMK.TabIndex = 13;
            txtNLMK.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 16.2F);
            label8.ForeColor = Color.FromArgb(255, 192, 192);
            label8.Location = new Point(12, 576);
            label8.Name = "label8";
            label8.Size = new Size(202, 33);
            label8.TabIndex = 14;
            label8.Text = "Đã có tài khoản?";
            // 
            // llbDangNhap
            // 
            llbDangNhap.ActiveLinkColor = Color.Red;
            llbDangNhap.AutoSize = true;
            llbDangNhap.BackColor = Color.Transparent;
            llbDangNhap.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangNhap.LinkBehavior = LinkBehavior.NeverUnderline;
            llbDangNhap.LinkColor = Color.IndianRed;
            llbDangNhap.Location = new Point(220, 580);
            llbDangNhap.Name = "llbDangNhap";
            llbDangNhap.Size = new Size(134, 26);
            llbDangNhap.TabIndex = 15;
            llbDangNhap.TabStop = true;
            llbDangNhap.Text = "[Đăng Nhập]";
            llbDangNhap.VisitedLinkColor = Color.Firebrick;
            llbDangNhap.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_10_14_184430;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 655);
            Controls.Add(llbDangNhap);
            Controls.Add(label8);
            Controls.Add(txtNLMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormDangKy";
            Text = "Form1";
            Load += FormDangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtNgaySinh;
        private TextBox txtMatKhau;
        private TextBox txtNLMK;
        private Label label8;
        private LinkLabel llbDangNhap;
    }
}
