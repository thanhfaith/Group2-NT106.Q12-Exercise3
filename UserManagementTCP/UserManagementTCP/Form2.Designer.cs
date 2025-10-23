namespace UserManagementTCP
{
    partial class Form2
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
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
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
            label2.Location = new Point(134, 154);
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
            label3.Location = new Point(134, 240);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(622, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(165, 26);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 46);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 227);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 46);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(452, 410);
            button1.Name = "button1";
            button1.Size = new Size(227, 58);
            button1.TabIndex = 6;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(134, 331);
            label4.Name = "label4";
            label4.Size = new Size(230, 33);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.IndianRed;
            linkLabel2.Location = new Point(385, 331);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 26);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "[Đăng Ký]";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_10_14_184430;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 552);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel2;
    }
}