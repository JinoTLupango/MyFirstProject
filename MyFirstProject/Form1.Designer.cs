namespace MyFirstProject
{
    partial class frmLogin
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
            panel1 = new Panel();
            lnkClick = new LinkLabel();
            label4 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(lnkClick);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 327);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lnkClick
            // 
            lnkClick.AutoSize = true;
            lnkClick.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkClick.LinkColor = Color.Black;
            lnkClick.Location = new Point(151, 211);
            lnkClick.Name = "lnkClick";
            lnkClick.Size = new Size(58, 13);
            lnkClick.TabIndex = 8;
            lnkClick.TabStop = true;
            lnkClick.Text = "Click Here";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 212);
            label4.Name = "label4";
            label4.Size = new Size(99, 13);
            label4.TabIndex = 7;
            label4.Text = "Forgot Password?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleTurquoise;
            btnRegister.Location = new Point(55, 244);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 24);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(55, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 24);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(55, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(55, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "LOG IN NOW";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(403, 414);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "My App";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private LinkLabel lnkClick;
        private Label label4;
        private Button btnLogin;
        private Button btnRegister;
    }
}
