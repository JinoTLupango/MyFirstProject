namespace MyFirstProject
{
    partial class frmRegister
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtFirstname);
            panel1.Controls.Add(txtLastname);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 336);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 234);
            label5.Name = "label5";
            label5.Size = new Size(49, 14);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 184);
            label4.Name = "label4";
            label4.Size = new Size(71, 14);
            label4.TabIndex = 9;
            label4.Text = "Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 135);
            label3.Name = "label3";
            label3.Size = new Size(57, 14);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleTurquoise;
            btnRegister.Location = new Point(51, 262);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(185, 24);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(51, 57);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(185, 23);
            txtFirstname.TabIndex = 5;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(51, 109);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(185, 23);
            txtLastname.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 23);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 1;
            label1.Text = "Sign Up";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(431, 432);
            Controls.Add(panel1);
            Name = "frmRegister";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}