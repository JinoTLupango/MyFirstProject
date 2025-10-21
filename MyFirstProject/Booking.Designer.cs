namespace MyFirstProject
{
    partial class frmBooking
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
            btnBookNow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(76, 89);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 0;
            label1.Text = "Now Accepting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(59, 120);
            label2.Name = "label2";
            label2.Size = new Size(284, 73);
            label2.TabIndex = 1;
            label2.Text = "Bookings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(59, 212);
            label3.Name = "label3";
            label3.Size = new Size(258, 22);
            label3.TabIndex = 2;
            label3.Text = "Book today and enjoy exclusive";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 236);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(59, 243);
            label5.Name = "label5";
            label5.Size = new Size(162, 22);
            label5.TabIndex = 4;
            label5.Text = "perks and benefits!";
            //label5.Click += label5_Click;
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.DarkTurquoise;
            btnBookNow.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = SystemColors.ControlLightLight;
            btnBookNow.Location = new Point(124, 313);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(124, 51);
            btnBookNow.TabIndex = 5;
            btnBookNow.Text = "BOOK NOW!";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += this.btnBookNow_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(393, 473);
            Controls.Add(btnBookNow);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBooking";
            Text = "BOOKING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBookNow;
    }
}