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
    public partial class statusapproval : Form
    {
        public statusapproval()
        {
            InitializeComponent();
            label2.Text = logstdnt.studentID;
        }

        private void statusapproval_Load(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\Asus\\Desktop\\New folder\\apply\\" + label2.Text + ".txt";
            if(File.Exists (filepath ))
            {
                string[] read = File.ReadAllLines(filepath);
                for (int i = 0; i < read.Length; i++)
                {
                    listBox1.Items.Add(read[i]);
                }
            }
            else
            {
                listBox1.Items.Add("Your registration in progress");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
