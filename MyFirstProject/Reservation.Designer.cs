namespace MyFirstProject
{
    partial class frmReservation
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
            BtnX = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFirstname = new TextBox();
            txtAddress2 = new TextBox();
            txtAddress1 = new TextBox();
            txtLastname = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtPhoneNo = new TextBox();
            txtZipcode = new TextBox();
            txtEmailaddress = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress1 = new Label();
            lblAddress2 = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZipcode = new Label();
            lblPhoneNO = new Label();
            lblEmailAddress = new Label();
            dtpCheckinDate = new DateTimePicker();
            dtpCheckoutDate = new DateTimePicker();
            lblCheckinDate = new Label();
            lblCheckoutDate = new Label();
            cmbCheckinTime = new ComboBox();
            cmbCheckoutTime = new ComboBox();
            lblCheckinTime = new Label();
            lblCheckoutTime = new Label();
            label3 = new Label();
            ckbStandard = new CheckBox();
            ckbDeluxe = new CheckBox();
            ckbSuite = new CheckBox();
            cmbAdults = new ComboBox();
            cmbChildren = new ComboBox();
            lblAdults = new Label();
            lblChildren = new Label();
            btnBookNow = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(BtnX);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 77);
            panel1.TabIndex = 0;
            // 
            // BtnX
            // 
            BtnX.BackColor = Color.Red;
            BtnX.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnX.Location = new Point(586, 18);
            BtnX.Name = "BtnX";
            BtnX.Size = new Size(32, 29);
            BtnX.TabIndex = 37;
            BtnX.Text = "X";
            BtnX.UseVisualStyleBackColor = false;
            BtnX.Click += BtnX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(192, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 47);
            label1.TabIndex = 0;
            label1.Text = "RESERVATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 1;
            label2.Text = "Reservation Details";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(51, 159);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(233, 23);
            txtFirstname.TabIndex = 2;
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(334, 226);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(233, 23);
            txtAddress2.TabIndex = 3;
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(51, 226);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(233, 23);
            txtAddress1.TabIndex = 4;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(334, 159);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(233, 23);
            txtLastname.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(51, 291);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(189, 23);
            txtCity.TabIndex = 6;
            // 
            // txtState
            // 
            txtState.Location = new Point(301, 291);
            txtState.Name = "txtState";
            txtState.Size = new Size(122, 23);
            txtState.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(51, 347);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(233, 23);
            txtPhoneNo.TabIndex = 8;
            // 
            // txtZipcode
            // 
            txtZipcode.Location = new Point(445, 291);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(122, 23);
            txtZipcode.TabIndex = 9;
            // 
            // txtEmailaddress
            // 
            txtEmailaddress.Location = new Point(334, 347);
            txtEmailaddress.Name = "txtEmailaddress";
            txtEmailaddress.Size = new Size(233, 23);
            txtEmailaddress.TabIndex = 10;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(51, 141);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 15);
            lblFirstName.TabIndex = 11;
            lblFirstName.Text = "First Name*";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(334, 141);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 15);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "Last Name*";
            // 
            // lblAddress1
            // 
            lblAddress1.AutoSize = true;
            lblAddress1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress1.Location = new Point(51, 208);
            lblAddress1.Name = "lblAddress1";
            lblAddress1.Size = new Size(66, 15);
            lblAddress1.TabIndex = 13;
            lblAddress1.Text = "Address 1*";
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress2.Location = new Point(334, 208);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(66, 15);
            lblAddress2.TabIndex = 14;
            lblAddress2.Text = "Address 2*";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(51, 273);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(33, 15);
            lblCity.TabIndex = 15;
            lblCity.Text = "City*";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(301, 273);
            lblState.Name = "lblState";
            lblState.Size = new Size(42, 15);
            lblState.TabIndex = 16;
            lblState.Text = "State*";
            // 
            // lblZipcode
            // 
            lblZipcode.AutoSize = true;
            lblZipcode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZipcode.Location = new Point(445, 273);
            lblZipcode.Name = "lblZipcode";
            lblZipcode.Size = new Size(60, 15);
            lblZipcode.TabIndex = 17;
            lblZipcode.Text = "Zip Code*";
            // 
            // lblPhoneNO
            // 
            lblPhoneNO.AutoSize = true;
            lblPhoneNO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNO.Location = new Point(51, 329);
            lblPhoneNO.Name = "lblPhoneNO";
            lblPhoneNO.Size = new Size(66, 15);
            lblPhoneNO.TabIndex = 18;
            lblPhoneNO.Text = "Phone No*";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(333, 329);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(83, 15);
            lblEmailAddress.TabIndex = 19;
            lblEmailAddress.Text = "Email Address";
            // 
            // dtpCheckinDate
            // 
            dtpCheckinDate.Location = new Point(51, 407);
            dtpCheckinDate.Name = "dtpCheckinDate";
            dtpCheckinDate.Size = new Size(143, 23);
            dtpCheckinDate.TabIndex = 20;
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.Location = new Point(322, 407);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(140, 23);
            dtpCheckoutDate.TabIndex = 21;
            // 
            // lblCheckinDate
            // 
            lblCheckinDate.AutoSize = true;
            lblCheckinDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckinDate.Location = new Point(51, 389);
            lblCheckinDate.Name = "lblCheckinDate";
            lblCheckinDate.Size = new Size(90, 15);
            lblCheckinDate.TabIndex = 22;
            lblCheckinDate.Text = "Check-in Date*";
            // 
            // lblCheckoutDate
            // 
            lblCheckoutDate.AutoSize = true;
            lblCheckoutDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckoutDate.Location = new Point(322, 389);
            lblCheckoutDate.Name = "lblCheckoutDate";
            lblCheckoutDate.Size = new Size(99, 15);
            lblCheckoutDate.TabIndex = 23;
            lblCheckoutDate.Text = "Check-out Date*";
            // 
            // cmbCheckinTime
            // 
            cmbCheckinTime.FormattingEnabled = true;
            cmbCheckinTime.Location = new Point(206, 407);
            cmbCheckinTime.Name = "cmbCheckinTime";
            cmbCheckinTime.Size = new Size(89, 23);
            cmbCheckinTime.TabIndex = 24;
            // 
            // cmbCheckoutTime
            // 
            cmbCheckoutTime.FormattingEnabled = true;
            cmbCheckoutTime.Location = new Point(470, 407);
            cmbCheckoutTime.Name = "cmbCheckoutTime";
            cmbCheckoutTime.Size = new Size(97, 23);
            cmbCheckoutTime.TabIndex = 25;
            // 
            // lblCheckinTime
            // 
            lblCheckinTime.AutoSize = true;
            lblCheckinTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckinTime.Location = new Point(206, 389);
            lblCheckinTime.Name = "lblCheckinTime";
            lblCheckinTime.Size = new Size(91, 15);
            lblCheckinTime.TabIndex = 26;
            lblCheckinTime.Text = "Check-in Time*";
            // 
            // lblCheckoutTime
            // 
            lblCheckoutTime.AutoSize = true;
            lblCheckoutTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckoutTime.Location = new Point(470, 389);
            lblCheckoutTime.Name = "lblCheckoutTime";
            lblCheckoutTime.Size = new Size(100, 15);
            lblCheckoutTime.TabIndex = 27;
            lblCheckoutTime.Text = "Check-out Time*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 462);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 28;
            label3.Text = "Room Preference*";
            // 
            // ckbStandard
            // 
            ckbStandard.AutoSize = true;
            ckbStandard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbStandard.Location = new Point(60, 501);
            ckbStandard.Name = "ckbStandard";
            ckbStandard.Size = new Size(76, 19);
            ckbStandard.TabIndex = 29;
            ckbStandard.Text = "Standard";
            ckbStandard.UseVisualStyleBackColor = true;
            // 
            // ckbDeluxe
            // 
            ckbDeluxe.AutoSize = true;
            ckbDeluxe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbDeluxe.Location = new Point(139, 501);
            ckbDeluxe.Name = "ckbDeluxe";
            ckbDeluxe.Size = new Size(66, 19);
            ckbDeluxe.TabIndex = 30;
            ckbDeluxe.Text = "Deluxe";
            ckbDeluxe.UseVisualStyleBackColor = true;
            // 
            // ckbSuite
            // 
            ckbSuite.AutoSize = true;
            ckbSuite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbSuite.Location = new Point(217, 501);
            ckbSuite.Name = "ckbSuite";
            ckbSuite.Size = new Size(55, 19);
            ckbSuite.TabIndex = 31;
            ckbSuite.Text = "Suite";
            ckbSuite.UseVisualStyleBackColor = true;
            // 
            // cmbAdults
            // 
            cmbAdults.FormattingEnabled = true;
            cmbAdults.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
            cmbAdults.Location = new Point(334, 497);
            cmbAdults.Name = "cmbAdults";
            cmbAdults.Size = new Size(89, 23);
            cmbAdults.TabIndex = 32;
            // 
            // cmbChildren
            // 
            cmbChildren.FormattingEnabled = true;
            cmbChildren.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
            cmbChildren.Location = new Point(478, 497);
            cmbChildren.Name = "cmbChildren";
            cmbChildren.Size = new Size(89, 23);
            cmbChildren.TabIndex = 33;
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdults.Location = new Point(333, 479);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(47, 15);
            lblAdults.TabIndex = 34;
            lblAdults.Text = "Adults*";
            // 
            // lblChildren
            // 
            lblChildren.AutoSize = true;
            lblChildren.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildren.Location = new Point(478, 479);
            lblChildren.Name = "lblChildren";
            lblChildren.Size = new Size(58, 15);
            lblChildren.TabIndex = 35;
            lblChildren.Text = "Children*";
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.DarkTurquoise;
            btnBookNow.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = SystemColors.ControlLightLight;
            btnBookNow.Location = new Point(251, 539);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(124, 51);
            btnBookNow.TabIndex = 36;
            btnBookNow.Text = "BOOK NOW!";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 615);
            Controls.Add(btnBookNow);
            Controls.Add(lblChildren);
            Controls.Add(lblAdults);
            Controls.Add(cmbChildren);
            Controls.Add(cmbAdults);
            Controls.Add(ckbSuite);
            Controls.Add(ckbDeluxe);
            Controls.Add(ckbStandard);
            Controls.Add(label3);
            Controls.Add(lblCheckoutTime);
            Controls.Add(lblCheckinTime);
            Controls.Add(cmbCheckoutTime);
            Controls.Add(cmbCheckinTime);
            Controls.Add(lblCheckoutDate);
            Controls.Add(lblCheckinDate);
            Controls.Add(dtpCheckoutDate);
            Controls.Add(dtpCheckinDate);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblPhoneNO);
            Controls.Add(lblZipcode);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblAddress2);
            Controls.Add(lblAddress1);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtEmailaddress);
            Controls.Add(txtZipcode);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtLastname);
            Controls.Add(txtAddress1);
            Controls.Add(txtAddress2);
            Controls.Add(txtFirstname);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmReservation";
            Text = "Reservation";
            Load += frmReservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtFirstname;
        private TextBox txtAddress2;
        private TextBox txtAddress1;
        private TextBox txtLastname;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtPhoneNo;
        private TextBox txtZipcode;
        private TextBox txtEmailaddress;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress1;
        private Label lblAddress2;
        private Label lblCity;
        private Label lblState;
        private Label lblZipcode;
        private Label lblPhoneNO;
        private Label lblEmailAddress;
        private DateTimePicker dtpCheckinDate;
        private DateTimePicker dtpCheckoutDate;
        private Label lblCheckinDate;
        private Label lblCheckoutDate;
        private ComboBox cmbCheckinTime;
        private ComboBox cmbCheckoutTime;
        private Label lblCheckinTime;
        private Label lblCheckoutTime;
        private Label label3;
        private CheckBox ckbStandard;
        private CheckBox ckbDeluxe;
        private CheckBox ckbSuite;
        private ComboBox cmbAdults;
        private ComboBox cmbChildren;
        private Label lblAdults;
        private Label lblChildren;
        private Button btnBookNow;
        private Button BtnX;
    }
}