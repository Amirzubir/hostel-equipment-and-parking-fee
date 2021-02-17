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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logstdnt = new logstdnt ();
            logstdnt.Closed += (s, args) => this.Close();
            logstdnt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stafflogin = new stafflogin();
            stafflogin.Closed += (s, args) => this.Close();
            stafflogin.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
