using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open the Register form
            frmRegister register = new frmRegister();
            register.ShowDialog();

            // After Register form is closed, show the login form again
            this.Show();

            this.Hide(); // hides the current form
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection
            string connectionString = "Data Source=DESKTOP-64BENGS\\SQLEXPRESS;Initial Catalog=MyFirstProject;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM [User] WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Logged In!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frmBooking booking = new frmBooking();
                        booking.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

    }
}
