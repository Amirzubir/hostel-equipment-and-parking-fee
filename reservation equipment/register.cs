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
    public partial class register : Form
    {
        equipment thisEquipment = new equipment();

        public register()
        {
            InitializeComponent();
            label14.Text = logstdnt.studentID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register NewForm = new register();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Equipment
            double Iron, equipment;
            if (checkBoxIron.Checked)
            {
                Iron  = 4;
                listBox1.Items.Add("Iron : RM4");
            }
            else
            {
                Iron = 0;
            }

            double HairDryer;
            if (checkBoxHair.Checked)
            {
                HairDryer = 6;
                listBox1.Items.Add("Hair Dryer : RM6");
            }
            else
            {
                HairDryer = 0;
            }

            double IronBoard;
            if (checkBoxBoard.Checked)
            {
                IronBoard = 4;
                listBox1.Items.Add("Iron Board : RM4");
            }
            else
            {
                IronBoard = 0;
            }

            double WasherMachine;
            if (checkBoxWasher.Checked)
            {
                WasherMachine = 3;
                listBox1.Items.Add("Washer Machine : RM3");
            }
            else
            {
                WasherMachine = 0;
            }

            double WaterHeater;
            if (checkBoxWater.Checked)
            {
                WaterHeater = 2;
                listBox1.Items.Add("Water Heater : RM2");
            }
            else
            {
                WaterHeater = 0;
            }

            double RiceCooker;
            if (checkBoxRice .Checked )
            {
                RiceCooker = 5;
                listBox1.Items.Add("Rice Cooker : RM 5");
            }
            else
            {
                RiceCooker = 0;
            }

            equipment = Iron + HairDryer + IronBoard + WasherMachine + WaterHeater + RiceCooker;

            //vehicle
            double Motorcycle, vehicle;
            if (checkBoxMotor.Checked )
            {
                Motorcycle = 30;
                listBox1.Items.Add("Motorcycle : RM30");
            }
            else
            {
                Motorcycle = 0;
            }

            double car;
            if (checkBoxCar.Checked)
            {
                car = 5;
                listBox1.Items.Add("Car : RM50");
            }
            else
            {
                car = 0;
            }
            vehicle = Motorcycle + car;

            //vechile plate no
            thisEquipment.Noplate = txtPlateNo.Text;
            listBox1.Items.Add("Vehicle Plate Number Is : " + txtPlateNo.Text + Environment.NewLine);

            //vechile parking no
            thisEquipment.ParkingNo = int.Parse(txtParking.Text);
            listBox1.Items.Add("Vehicle Parking Number is : " + txtParking.Text + Environment.NewLine);

            //fee
            double fee = 0;
            fee = equipment + vehicle;
            thisEquipment.Fee = txtFee.Text;
            listBox1.Items.Add("Total Fee is : " + fee + Environment.NewLine);

            //display
            txtFee.Text = fee.ToString("N2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            equipment equip = new equipment(); 
            string filepath = @"C:\\Users\\Asus\\Desktop\\New folder\\apply\\" + label14.Text + ".txt";
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                foreach (var item in listBox1 .Items)
                {
                    sw.WriteLine(item);
                }
            }
            MessageBox.Show("your registration is successfully" + "\n "+"wait approval from staff");
            this.Hide();
            menu mne = new menu();
            mne.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mnu = new menu();
            mnu.Show();
        }
    }
}
