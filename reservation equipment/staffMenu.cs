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
    public partial class staffMenu : Form
    {
        public staffMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Asus\Desktop\New folder\Apply\" + txtstudent.Text + ".txt";
            if(File .Exists (filepath))
            {
                string[] read = File.ReadAllLines(filepath);
                for(int i=0;i<read.Length;i++)
                {
                    listBox1.Items.Add(read[i]);
                }
            }
            else
            {
                MessageBox.Show("student ID not exist");
                txtstudent.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\Asus\\Desktop\\New folder\\apply\\" + txtstudent.Text + ".txt";//save in one folder
        
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                foreach (var item in listBox1 .Items)
                {
                    sw.WriteLine(item);
                }

                sw.WriteLine("Your registration get approval");
            }

            MessageBox.Show("The Student Approval is Succcessfully");

            using (StreamWriter az = File.AppendText(@"C:\\Users\\Asus\\Desktop\\New folder\\apply\\list.txt")) //save from 
            {
                az.WriteLine(txtstudent.Text);
                foreach (var asb in listBox1 .Items)
                {
                    az.WriteLine(asb);
                }
            }

            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menustaff menustff = new menustaff();
            menustff.Show();
        }
    }
}
