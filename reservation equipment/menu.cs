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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new register();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var statusapproval = new statusapproval();
            statusapproval.Closed += (s, args) => this.Close();
            statusapproval.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            logstdnt logstudent = new logstdnt();
            logstudent.Show();

        }
    }
}
