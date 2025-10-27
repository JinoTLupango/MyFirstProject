using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class frmDashboard : Form
    {
        string connectionString = "Data Source=DESKTOP-64BENGS\\SQLEXPRESS;Initial Catalog=MyFirstProject;Integrated Security=True;TrustServerCertificate=True;";

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations(string searchTerm = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // If search box is empty, show all data
                    string query = @"SELECT * FROM Reservation 
                                     WHERE first_name LIKE @search 
                                     OR last_name LIKE @search 
                                     OR city LIKE @search 
                                     OR phone_no LIKE @search 
                                     OR email_address LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvDashboard.DataSource = table;

                    // Format table for better view
                    dgvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvDashboard.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnxSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            LoadReservations(searchValue);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Optional: auto-search as you type
            LoadReservations(txtSearch.Text.Trim());
        }

        private void btnxDelete_Click(object sender, EventArgs e)
        {
            if (dgvDashboard.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = dgvDashboard.SelectedRows[0];

            // Make sure there's an ID column
            if (selectedRow.Cells["reservation_id"] == null)
            {
                MessageBox.Show("Invalid record selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reservation_id = Convert.ToInt32(selectedRow.Cells["reservation_id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM Reservation WHERE reservation_id = @reservation_id";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@reservation_id", reservation_id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReservations(); // Refresh the grid after deletion
                        }
                        else
                        {
                            MessageBox.Show("Record not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting reservation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
