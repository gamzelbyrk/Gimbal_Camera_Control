using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Class_Client;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace Gimbal_Camera_Control.Forms
{
    public partial class Form_ControlMenu : Form
    {
        Client_Class client_Class;
        public byte[] stop = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20 };

        public byte[] home = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x04, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x13 };

        public byte[] left1 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xFA, 0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFE };
        public byte[] left2 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xFE, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xAE };
        public byte[] left3 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xFE, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD2 };
        public byte[] left4 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xFD, 0xA8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x75 };
        public byte[] left5 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xF8, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8 };

        public byte[] right1 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x01, 0xF4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD5 };
        public byte[] right2 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x03, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCB };
        public byte[] right3 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x05, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31 };
        public byte[] right4 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x05, 0xDC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF9 };
        public byte[] right5 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x07, 0xD0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF7 };

        public byte[] up1 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x01, 0xF4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD5 };
        public byte[] up2 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x03, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCB };
        public byte[] up3 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x05, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31 };
        public byte[] up4 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x05, 0xDC,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF9 };
        public byte[] up5 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x07, 0xD0,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF7 };

        public byte[] down1 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xFE, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD2 };
        public byte[] down2 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xFC, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC4 };
        public byte[] down3 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xFA, 0xEC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36 };
        public byte[] down4 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xFA, 0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFE };
        public byte[] down5 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xF8, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8 };

        public byte[] HandS1 = new byte[] { 0xEB, 0x90, 0x07, 0x55, 0xAA, 0xDC, 0x44, 0x14, 0xF5, 0xA5, 0xCD };

        

        byte[] header = new byte[2] { 0xEB, 0x90 };

        Services.LoggerTemplate template_logger = Services.LoggerTemplate.Instance;

        public Form_ControlMenu()
        {
            InitializeComponent();
            LoadTheme();
      
        }
      
        private void FormOrders_Load(object sender, EventArgs e)
        {
            client_Class = new Client_Class();
            LoadTheme();

            trackBarM.Minimum = 1;
            trackBarM.Maximum = 5;

            numericUpDownYAW.Increment = 1M;
            numericUpDownYAW.DecimalPlaces = 1;
            numericUpDownYAW.Minimum = -100M;
            numericUpDownYAW.Maximum = 100M;

            numericUpDownPITCH.Increment = 1M;
            numericUpDownPITCH.DecimalPlaces = 1;
            numericUpDownPITCH.Minimum = -100M;
            numericUpDownPITCH.Maximum = 100M;

        }
        private void LoadTheme()
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
            lblPitch.ForeColor = ThemeColor.SecondaryColor;
            lblYaw.ForeColor = ThemeColor.PrimaryColor;
            lblSpeed.ForeColor = ThemeColor.PrimaryColor;
        }
        private void ImageMenuButton_Click(object sender, EventArgs e)
        {
            panelislem.Controls.Clear();
            FormImage f1 = new FormImage();
            f1.TopLevel = false;
            panelislem.Controls.Add(f1);
            f1.Show();
            f1.Dock = DockStyle.Top;
            f1.BringToFront();
        }
        private void TrackMenuButton_Click_1(object sender, EventArgs e)
        {
            panelislem.Controls.Clear();
            TrackForm f2 = new TrackForm();
            f2.TopLevel = false;
            panelislem.Controls.Add(f2);
            f2.Show();
            f2.Dock = DockStyle.Top;
            f2.BringToFront();
        }

        public async void btnHome_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(home, header);
        }
        private void AdvancedMenuButton_Click_1(object sender, EventArgs e)
        {
            panelislem.Controls.Clear();
            AdvancedForm f3 = new AdvancedForm();
            f3.TopLevel = false;
            panelislem.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Top;
            f3.BringToFront();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(trackBarM.Value == 1)
            {
                client_Class.SendMessage(left1, header);
                client_Class.SendMessage(stop, header);
            }
            else if(trackBarM.Value == 2)
            {
                client_Class.SendMessage(left2, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 3)
            {
                client_Class.SendMessage(left3, header);
                client_Class.SendMessage(stop, header);
            }
            else if(trackBarM.Value==4)
            {
                client_Class.SendMessage(left4, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 5)
            {
                client_Class.SendMessage(left5, header);
                client_Class.SendMessage(stop, header);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (trackBarM.Value == 1)
            {
                client_Class.SendMessage(right1, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 2)
            {
                client_Class.SendMessage(right2, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 3)
            {
                client_Class.SendMessage(right3, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 4)
            {
                client_Class.SendMessage(right4, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 5)
            {
                client_Class.SendMessage(right5, header);
                client_Class.SendMessage(stop, header);
            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {

            if (trackBarM.Value == 1)
            {
                client_Class.SendMessage(down1, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 2)
            {
                client_Class.SendMessage(down2, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 3)
            {
                client_Class.SendMessage(down3, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 4)
            {
                client_Class.SendMessage(down4, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 5)
            {
                client_Class.SendMessage(down5, header);
                client_Class.SendMessage(stop, header);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (trackBarM.Value == 1)
            {
                client_Class.SendMessage(up1, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 2)
            {
                client_Class.SendMessage(up2, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 3)
            {
                client_Class.SendMessage(up3, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 4)
            {
                client_Class.SendMessage(up4, header);
                client_Class.SendMessage(stop, header);
            }
            else if (trackBarM.Value == 5)
            {
                client_Class.SendMessage(up5, header);
                client_Class.SendMessage(stop, header);
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

            vlcControl1.SetMedia("rtsp://192.168.2.119:554", new List<string>() { "network-caching=350", "rtsp-tcp=true", "clock-synchro=1", "netsync-master=1", "input-record-native" }.ToArray());

            if (btnPlay.Text == "Play")
            {
                vlcControl1.Play();
                btnPlay.Text = "Pause";
            }
            else if (btnPlay.Text == "Pause")
            {
                vlcControl1.Stop();
                btnPlay.Text = "Play";
            }
        }
        
       private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLeft.PerformClick();

        }
        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnRight.PerformClick();
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Start();
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnUp.PerformClick();
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            timer4.Start();
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            timer4.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            btnDown.PerformClick();
        }
        private void pictureBoxCamera_Click(object sender, EventArgs e)
        {

        }
        private void Form_ControlMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void label29_Click(object sender, EventArgs e)
        {

        }
        private void btnTurn_Click(object sender, EventArgs e)
        {
            client_Class.sendPackageYP(numericUpDownYAW.Value, numericUpDownPITCH.Value);
        }


    }
}
