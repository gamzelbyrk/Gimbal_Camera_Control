using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Client;

namespace Gimbal_Camera_Control.Forms
{
    public partial class AdvancedForm : Form
    {
        Client_Class client_Class;

        public byte[] enablefollow= new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x50, 0x00, 0x00, 0x00, 0x22 };
        public byte[] disablefollow = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x50, 0x00, 0x00, 0x00, 0x2B };
        public byte[] motoron = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20 };
        public byte[] motoroff = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20 };
        public byte[] eodzoomon = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3A };
        public byte[] eodzoomoff = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3B };
        public byte[] temalarm = new byte[] {0x55, 0xAA, 0xDC, 0x05, 0x2A, 0x02, 0x00, 0x2D };
        public byte[] eodzoomMax1 = new byte[] {0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x0A, 0x28};
        public byte[] eodzoomMax2 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x14, 0x36 };
        public byte[] eodzoomMax3 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x1E, 0x3C };
        public byte[] eodzoomMax4 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x28, 0x0A };
        public byte[] eodzoomMax5 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x32, 0x10 };
        public byte[] eodzoomMax6 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x3C, 0x1E };
        public byte[] eodzoomMax7 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x46, 0x64 };
        public byte[] eodzoomMax8 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x50, 0x72 };
        public byte[] eodzoomMax9 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x5A, 0x78 };
        public byte[] eodzoomMax10 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x64, 0x46 };
        public byte[] eodzoomMax11 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x6E, 0x4C };
        public byte[] eodzoomMax12 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x78, 0x5A };
        public byte[] eodzoomMax13 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x82, 0xA0 };
        public byte[] eodzoomMax14 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x8C, 0xAE };
        public byte[] eodzoomMax15 = new byte[] { 0x55, 0xAA, 0xDC, 0x06, 0x2C, 0x08, 0x00, 0x96, 0xB4 };



        public byte[] defogon = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x2B };
        public byte[] defogoff = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x2A };
        public byte[] Irdzoomon = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x06, 0x00, 0x00, 0x06, 0xD0, 0x00, 0x00, 0x00, 0xF8 };
        public byte[] Irdzoomoff = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x06, 0x00, 0x00, 0x07, 0x10, 0x00, 0x00, 0x00, 0x39 };
        public byte[] adup = new byte[] { 0x08, 0x55, 0xAA, 0xDC, 0x05, 0x2A, 0x01, 0x64, 0x4A };
        public byte[] adleft = new byte[] { 0x08, 0x55, 0xAA, 0xDC, 0x05, 0x2A, 0x02, 0x9C, 0xB1 };
        public byte[] adright = new byte[] { 0x08, 0x55, 0xAA, 0xDC, 0x05, 0x2A, 0x02, 0x64, 0x49 };
        public byte[] addown = new byte[] { 0x08, 0x55, 0xAA, 0xDC, 0x05, 0x2A, 0x01, 0x9C, 0xB2 };

        public byte[] gyro0= new byte[] {0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06 };
        public byte[] gyro1 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x03, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xED };
        public byte[] gyro2 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x07, 0xD0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD1};
        public byte[] gyro3 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x0B, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD1 };
        public byte[] gyro4 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x0F, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA9 };
        public byte[] gyro5 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x13, 0x88, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x9D };
        public byte[] gyro6 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x17, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x61 };
        public byte[] gyro7 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x1B, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x45 };
        public byte[] gyro8 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x1B, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x59 };
        public byte[] gyro9 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x23, 0x28, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0D };
        public byte[] gyro10 = new byte[] { 0x55, 0xAA, 0xDC, 0x0C, 0x1A, 0x10, 0x27, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31 };




        byte[] header = new byte[2] { 0xEB, 0x90 };        
        public AdvancedForm()
        {
            InitializeComponent();
            LoadTheme();
            client_Class = new Client_Class();
            numericDMAX.Minimum = 1;
            numericDMAX.Maximum = 15;

            numericG.Minimum = 0;
            numericG.Maximum = 10;

            trackBarG.Minimum = 0;
            trackBarG.Maximum = 10;
        }
        private void AdvancedForm_Load(object sender, EventArgs e)
        {
            LoadTheme();

        
        }
        private void LoadTheme() //mevcut temanin renkerini uyguluyoruz.
        {
            foreach (System.Windows.Forms.Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblIRDigitalZoom.ForeColor = ThemeColor.SecondaryColor;
            lblStep.ForeColor = ThemeColor.PrimaryColor;
            lblTemAlarm.ForeColor = ThemeColor.PrimaryColor;
            lblIat.ForeColor = ThemeColor.PrimaryColor;
            lblIng.ForeColor = ThemeColor.PrimaryColor;
            lblM.ForeColor = ThemeColor.PrimaryColor;
        }
        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnEnableFollow_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(enablefollow, header);
        }
        private void btnDisableFollow_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(disablefollow, header);
        }
        private void btnMotorOn_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(motoron, header);
        }
        private void btnMotorOff_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(motoroff, header);
        }
        private void btnEODzmOn_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(eodzoomon, header);
        }
        private void EODzmOff_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(eodzoomoff, header);
        }
        private void btnDefogOn_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(defogon, header);
        }
        private void btnDefogOff_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(defogoff, header);
        }
        private void btnIrDzoomOn_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(Irdzoomon, header);
        }
        private void btnIrDzoomOff_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(Irdzoomoff, header); 
        }
        private void btnTemAlarm_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(temalarm, header);
        }
        private void btnDzoomMax_Click(object sender, EventArgs e)
        {
            if (numericDMAX.Value == 1)
            {
                client_Class.SendMessage(eodzoomMax1,header);
            }
            else if (numericDMAX.Value == 2)
            {
                client_Class.SendMessage(eodzoomMax2, header);
            }
            else if (numericDMAX.Value == 3)
            {
                client_Class.SendMessage(eodzoomMax3, header);
            }
            else if (numericDMAX.Value == 4)
            {
                client_Class.SendMessage(eodzoomMax4, header);
            }
            else if (numericDMAX.Value == 5)
            {
                client_Class.SendMessage(eodzoomMax5, header);
            }
            else if (numericDMAX.Value == 6)
            {
                client_Class.SendMessage(eodzoomMax6, header);
            }
            else if (numericDMAX.Value == 7)
            {
                client_Class.SendMessage(eodzoomMax7, header);
            }
            else if (numericDMAX.Value == 8)
            {
                client_Class.SendMessage(eodzoomMax8, header);
            }
            else if (numericDMAX.Value == 9)
            {
                client_Class.SendMessage(eodzoomMax9, header);
            }
            else if (numericDMAX.Value == 10)
            {
                client_Class.SendMessage(eodzoomMax10, header);
            }
            else if (numericDMAX.Value == 11)
            {
                client_Class.SendMessage(eodzoomMax11, header);
            }
            else if (numericDMAX.Value == 12)
            {
                client_Class.SendMessage(eodzoomMax12, header);
            }
            else if (numericDMAX.Value == 13)
            {
                client_Class.SendMessage(eodzoomMax13, header);
            }
            else if (numericDMAX.Value == 14)
            {
                client_Class.SendMessage(eodzoomMax14, header);
            }
            else if (numericDMAX.Value == 15)
            {
                client_Class.SendMessage(eodzoomMax15, header);
            }
           
        }
        private void button35_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(adup, header);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(adleft, header);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(adright, header);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(addown, header);
        }
        private void button39_Click(object sender, EventArgs e)
        {


            //int values = 6000;

            //byte[] temp = BitConverter.GetBytes(values);

            //MessageBox.Show(temp[0].ToString(), temp[1].ToString());




            if (numericG.Value == 0)
            {
                client_Class.SendMessage(gyro0, header);
            }
            else if (numericG.Value == 1)
            {
                client_Class.SendMessage(gyro1, header);
            }
            else if (numericG.Value == 2)
            {
                client_Class.SendMessage(gyro2, header);
            }
            else if (numericG.Value == 3)
            {
                client_Class.SendMessage(gyro3, header);
            }
            else if (numericG.Value == 4)
            {
                client_Class.SendMessage(gyro4, header);
            }
            else if (numericG.Value == 5)
            {
                client_Class.SendMessage(gyro5, header);
            }
            else if (numericG.Value == 6)
            {
                client_Class.SendMessage(gyro6, header);
            }
            else if (numericG.Value == 7)
            {
                client_Class.SendMessage(gyro7, header);
            }
            else if (numericG.Value == 8)
            {
                client_Class.SendMessage(gyro8, header);
            }
            else if (numericG.Value == 9)
            {
                client_Class.SendMessage(gyro9, header);
            }
            else if (numericG.Value == 10)
            {
                client_Class.SendMessage(gyro10, header);
            }
            
        }

        private void numericDMAX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericG_ValueChanged(object sender, EventArgs e)
        {

            trackBarG.Value = Convert.ToInt32(numericG.Value);

            //if(trackBarG.Value == 0)
            //{
            //    numericG.Value = 0;
            //}
            //else if(trackBarG.Value ==1)
            //{
            //    numericG.Value = 1;
            //}
            //else if (trackBarG.Value==2)
            //{
            //    numericG.Value = 2;
            //}
            //else if(trackBarG.Value == 3)
            //{
            //    numericG.Value = 3;
            //}
            //else if (trackBarG.Value == 4)
            //{
            //    numericG.Value = 4;
            //}
            //else if (trackBarG.Value == 5)
            //{
            //    numericG.Value = 5;
            //}
            //else if (trackBarG.Value == 6)
            //{
            //    numericG.Value = 6;
            //}
            //else if (trackBarG.Value == 7)
            //{
            //    numericG.Value = 7;
            //}
            //else if (trackBarG.Value == 8)
            //{
            //    numericG.Value = 8;
            //}
            //else if (trackBarG.Value == 9)
            //{
            //    numericG.Value = 9;
            //}
            //else if (trackBarG.Value == 10)
            //{
            //    numericG.Value = 10;
            //}



        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            numericG.Value = trackBarG.Value;
        }
        void trackBarG_ValueChanged(object sender, EventArgs e)
{
    // Sync up the spinbox with the value just set on the trackbar
             
}
    }
}
