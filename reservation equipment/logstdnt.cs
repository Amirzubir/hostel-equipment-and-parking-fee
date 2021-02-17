using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assgmnttttt_oop
{
    public partial class logstdnt : Form
    {
        public static string studentID;
        public logstdnt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var stdntregister = new stdntregister();
            stdntregister .Closed += (s, args) => this.Close();
            stdntregister.Show();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\Asus\\Desktop\\New folder\\studentID" + txtmatrixnm .Text + ".txt";
            if (File.Exists(filepath)) //&& !File.Exists(filepath)
            {
                this.Hide();
                menu buka = new menu();
                
                buka.Show();

            }
            studentID = txtmatrixnm.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
