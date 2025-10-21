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
            DialogResult result = MessageBox.Show("? Successfully Log in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            frmBooking booking = new frmBooking();
            booking.ShowDialog();
        }
    }
}
