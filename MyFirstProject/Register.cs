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

                    // Insert into Register table
                    string query = "INSERT INTO Register (first_name, last_name, username, password) VALUES (@first_name, @last_name, @username, @password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    int rows = cmd.ExecuteNonQuery();

                    // Insert also into User table
                    string insertUser = "INSERT INTO [User] (username, password) VALUES (@username, @password)";
                    using (SqlCommand cmd2 = new SqlCommand(insertUser, conn))
                    {
                        cmd2.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd2.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd2.ExecuteNonQuery();
                    }

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No rows inserted. Please check your query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
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

        }
    }
}
