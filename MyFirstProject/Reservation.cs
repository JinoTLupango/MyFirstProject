using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
