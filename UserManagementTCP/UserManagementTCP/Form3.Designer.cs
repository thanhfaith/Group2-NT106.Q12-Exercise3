namespace UserManagementTCP
{
    partial class Form3
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
            label4 = new Label();
            label5 = new Label();
            lblht = new Label();
            lblsdt = new Label();
            lble = new Label();
            lblns = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(143, 43);
            label1.Name = "label1";
            label1.Size = new Size(496, 46);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(120, 128);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(120, 205);
            label3.Name = "label3";
            label3.Size = new Size(163, 33);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(120, 285);
            label4.Name = "label4";
            label4.Size = new Size(89, 33);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(120, 365);
            label5.Name = "label5";
            label5.Size = new Size(127, 33);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // lblht
            // 
            lblht.AutoSize = true;
            lblht.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblht.ForeColor = Color.Black;
            lblht.Location = new Point(342, 128);
            lblht.Name = "lblht";
            lblht.Size = new Size(92, 33);
            lblht.TabIndex = 5;
            lblht.Text = "_ _ _ _";
            // 
            // lblsdt
            // 
            lblsdt.AutoSize = true;
            lblsdt.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsdt.ForeColor = Color.Black;
            lblsdt.Location = new Point(342, 205);
            lblsdt.Name = "lblsdt";
            lblsdt.Size = new Size(92, 33);
            lblsdt.TabIndex = 6;
            lblsdt.Text = "_ _ _ _";
            // 
            // lble
            // 
            lble.AutoSize = true;
            lble.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble.ForeColor = Color.Black;
            lble.Location = new Point(342, 285);
            lble.Name = "lble";
            lble.Size = new Size(92, 33);
            lble.TabIndex = 7;
            lble.Text = "_ _ _ _";
            // 
            // lblns
            // 
            lblns.AutoSize = true;
            lblns.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblns.ForeColor = Color.Black;
            lblns.Location = new Point(342, 365);
            lblns.Name = "lblns";
            lblns.Size = new Size(92, 33);
            lblns.TabIndex = 8;
            lblns.Text = "_ _ _ _";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_10_14_184430;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblns);
            Controls.Add(lble);
            Controls.Add(lblsdt);
            Controls.Add(lblht);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblht;
        private Label lblsdt;
        private Label lble;
        private Label lblns;
    }
}