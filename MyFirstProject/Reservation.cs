using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            cmbCheckinTime.Items.Add("8:00 AM");
            cmbCheckinTime.Items.Add("9:00 AM");
            cmbCheckinTime.Items.Add("10:00 AM");
            cmbCheckinTime.Items.Add("11:00 AM");
            cmbCheckinTime.Items.Add("12:00 PM");
            cmbCheckinTime.Items.Add("1:00 PM");
            cmbCheckinTime.Items.Add("2:00 PM");
            cmbCheckinTime.Items.Add("3:00 PM");
            cmbCheckinTime.Items.Add("4:00 PM");
            cmbCheckinTime.Items.Add("5:00 PM");

            cmbCheckoutTime.Items.Add("8:00 AM");
            cmbCheckoutTime.Items.Add("9:00 AM");
            cmbCheckoutTime.Items.Add("10:00 AM");
            cmbCheckoutTime.Items.Add("11:00 AM");
            cmbCheckoutTime.Items.Add("12:00 PM");
            cmbCheckoutTime.Items.Add("1:00 PM");
            cmbCheckoutTime.Items.Add("2:00 PM");
            cmbCheckoutTime.Items.Add("3:00 PM");
            cmbCheckoutTime.Items.Add("4:00 PM");
            cmbCheckoutTime.Items.Add("5:00 PM");

        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtAddress1.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text))
                //string.IsNullOrWhiteSpace(cmbRoomPreference.Text))
            {
                MessageBox.Show("Please fill out all required fields (*).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-64BENGS\\SQLEXPRESS;Initial Catalog=MyFirstProject;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Reservation 
                                    (first_name, Last_name, address1, address2, city, state, zip_code, phone_no, email_address, 
                                     check_in_date, check_in_time, check_out_date, check_out_time, adults, children)
                                     VALUES
                                    (@first_name, @last_name, @address1, @address2, @city, @state, @zip_code, @phone_no, @email_address,
                                     @check_in_date, @check_in_time, @check_out_date, @check_out_time, @adults, @children)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@first_name", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@address1", txtAddress1.Text);
                    cmd.Parameters.AddWithValue("@address2", txtAddress2.Text);
                    cmd.Parameters.AddWithValue("@city", txtCity.Text);
                    cmd.Parameters.AddWithValue("@state", txtState.Text);
                    cmd.Parameters.AddWithValue("@zip_code", txtZipcode.Text);
                    cmd.Parameters.AddWithValue("@phone_no", txtPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@email_address", txtEmailaddress.Text);
                    cmd.Parameters.AddWithValue("@check_in_date", dtpCheckinDate.Value);
                    cmd.Parameters.AddWithValue("@check_in_time", cmbCheckinTime.Text);
                    cmd.Parameters.AddWithValue("@check_out_date", dtpCheckoutDate.Value);
                    cmd.Parameters.AddWithValue("@check_out_time", cmbCheckoutTime.Text);
                    cmd.Parameters.AddWithValue("@adults", cmbAdults.Text);
                    cmd.Parameters.AddWithValue("@children", cmbChildren.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation successfully booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm(); // Optional: Clear form after successful booking
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //frmDashboard dashboard = new frmDashboard();
                //dashboard.ShowDialog();
            }
        }

        private string GetRoomPreference()
        {
            if (ckbStandard.Checked) return "Standard";
            if (ckbDeluxe.Checked) return "Deluxe";
            if (ckbSuite.Checked) return "Suite";
            return "";
        }

        private void ClearForm()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipcode.Clear();
            txtPhoneNo.Clear();
            txtEmailaddress.Clear();
            cmbCheckinTime.SelectedIndex = -1;
            cmbCheckoutTime.SelectedIndex = -1;
            cmbAdults.SelectedIndex = -1;
            cmbChildren.SelectedIndex = -1;
            ckbStandard.Checked = false;
            ckbDeluxe.Checked = false;
            ckbSuite.Checked = false;
        }
    


        private void BtnX_Click(object sender, EventArgs e)
        {
           // frmBooking book = new frmBooking();
           // book.ShowDialog();
        }
    }
}
