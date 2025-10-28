namespace UserManagementTCP
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            llbQMK = new LinkLabel();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            label4 = new Label();
            llbDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(184, 44);
            label1.Name = "label1";
            label1.Size = new Size(479, 46);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(115, 154);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(115, 240);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // llbQMK
            // 
            llbQMK.AutoSize = true;
            llbQMK.BackColor = Color.Transparent;
            llbQMK.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbQMK.LinkBehavior = LinkBehavior.NeverUnderline;
            llbQMK.LinkColor = Color.IndianRed;
            llbQMK.Location = new Point(566, 319);
            llbQMK.Name = "llbQMK";
            llbQMK.Size = new Size(165, 26);
            llbQMK.TabIndex = 3;
            llbQMK.TabStop = true;
            llbQMK.Text = "Quên mật khẩu?";
            llbQMK.LinkClicked += llbQMK_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(320, 141);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(411, 46);
            txtEmail.TabIndex = 4;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(320, 227);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(411, 46);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 128, 128);
            btnDangNhap.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(338, 398);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(228, 58);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(115, 312);
            label4.Name = "label4";
            label4.Size = new Size(230, 33);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản?";
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.BackColor = Color.Transparent;
            llbDangKy.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangKy.LinkBehavior = LinkBehavior.NeverUnderline;
            llbDangKy.LinkColor = Color.IndianRed;
            llbDangKy.Location = new Point(360, 319);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(112, 26);
            llbDangKy.TabIndex = 8;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "[Đăng Ký]";
            llbDangKy.LinkClicked += llbDangKy_LinkClicked;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_10_14_184430;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 552);
            Controls.Add(llbDangKy);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(llbQMK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormDangNhap";
            Text = "Form2";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel llbQMK;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Label label4;
        private LinkLabel llbDangKy;
    }
}