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
using System.Diagnostics;

namespace assgmnttttt_oop
{
    public partial class stdntregister : Form
    {

        string filepath = @"C:\\Users\\Asus\\Desktop\\New folder\\studentID";
        student aStudent = new student ();
        public stdntregister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student aStudent = new student();

            aStudent.StudentID = txtstdntID.Text;
            aStudent.StudentName = txtstdnName.Text;
            aStudent.Course = txtCourse.Text;
            aStudent.Password = txtPass.Text;

            saveToFile(filepath);

            MessageBox.Show("your registration is sucessfully");
            this.Hide();
            logstdnt log = new logstdnt();
            log.Show();
        }

        bool saveToFile(string FilePath)
        {
            if (!File.Exists(filepath))
            {
                //create a file to write to.
                using (StreamWriter file = File.CreateText(filepath + txtstdntID .Text + ".txt"))
                {
                    string Line = StudentToLine(aStudent);
                    file.WriteLine(Line); //write to file.
                }
            }
            else
            {
                //this text is always added, making the file longer over time
                //if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = StudentToLine(aStudent);
                    file.WriteLine(Line);
                }
            }

            //file.close();
            return true;
        }

        string StudentToLine(student aStudent)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(aStudent.StudentID);
            sb.Append(Environment.NewLine);
            sb.Append(aStudent.StudentName);
            sb.Append(Environment.NewLine);
            sb.Append(aStudent.Course);
            sb.Append(Environment.NewLine);
            sb.Append(aStudent.Password);

            Debug.WriteLine(sb.ToString());

            return sb.ToString(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            stdntregister NewForm = new stdntregister();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var logstdnt = new logstdnt();
            logstdnt.Closed += (s, args) => this.Close();
            logstdnt.Show();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
