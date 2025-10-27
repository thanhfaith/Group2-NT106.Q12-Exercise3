namespace Server
{
    partial class Form1
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(38, 32);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(155, 69);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(302, 144);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(60, 16);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "lb_status";
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(444, 41);
            this.lstClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(190, 84);
            this.lstClients.TabIndex = 2;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(248, 212);
            this.tb_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(375, 22);
            this.tb_log.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_Start);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.TextBox tb_log;
    }
}

