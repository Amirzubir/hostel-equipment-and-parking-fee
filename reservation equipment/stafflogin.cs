using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assgmnttttt_oop
{
    public partial class stafflogin : Form
    {
        public stafflogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string staffID = (txtstaffID.Text);
            if (staffID == "ADMIN" || staffID == "admin")
            {
                this.Hide();
                menustaff menustff = new menustaff();
                menustff.Show();
            }
            else
            {
                MessageBox.Show("OOPS WRONG ID");
                txtstaffID.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
