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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menustaff ss = new menustaff();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\amirzubir\\Desktop\\New folder\\apply\\list.txt";
            if (File.Exists(filepath))
            {
                string[] read = File.ReadAllLines(filepath);
                for (int i = 0; i < read.Length; i++)
                {
                    listBox1.Items.Add(read[i]);
                }
            }
        }
    }
}
