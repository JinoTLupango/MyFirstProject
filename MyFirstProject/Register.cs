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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyFirstProject
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-64BENGS\\SQLEXPRESS;Initial Catalog=MyFirstProject;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if username already exists
                    string checkUser = "SELECT COUNT(*) FROM Register WHERE username = @username";
                    SqlCommand checkCmd = new SqlCommand(checkUser, conn);
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert into Register table
                    string query = "INSERT INTO Register (first_name, last_name, username, password, role) VALUES (@first_name, @last_name, @username, @password, @role)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to login form
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        // Show success message
        DialogResult result = MessageBox.Show("✅ Successfully Signed Up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // If user clicks OK, go to Login Form
            if (result == DialogResult.OK)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }


        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("User");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; // Default role
        }
    }
}
