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
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
            this.Show();
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

                    // ? Retrieve role from Register table
                    string query = "SELECT role FROM Register WHERE username=@username AND password=@password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        string role = roleObj.ToString();

                        MessageBox.Show($"Welcome, {role}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        if (role == "Admin")
                        {
                            // ?? Go to Admin Dashboard
                            frmAdminDashboard adminForm = new frmAdminDashboard();
                            adminForm.ShowDialog();
                        }
                        else
                        {
                            // ?? Go to Booking Form (User Dashboard)
                            frmBooking booking = new frmBooking();
                            booking.ShowDialog();
                        }

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
