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
    public partial class TrackForm : Form
    {

        Client_Class client_Class;

        public byte[] starttrck = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x24 }; //serial comm pdf
        public byte[] stoptrck = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x20 };
        public byte[] pointtrck = new byte[] { 0x55, 0xAA, 0xDC, 0x0D, 0x31, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0A, 0xFF, 0x88, 0x01, 0x18, 0X58 };
        public byte[] turnOnVehicle = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x01, 0x2A };
        public byte[] turnOffVehicle = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x2B };
        public byte[] recognitionToTracking = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x26 };
        public byte[] sizeAuto = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x28, 0x00, 0x07 };
        public byte[] size32 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x21, 0x00, 0x0E };
        public byte[] size64 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x22, 0x00, 0x0D };
        public byte[] size128 = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x23, 0x00, 0x0C };

        byte[] header = new byte[2] { 0xEB, 0x90 };

        public TrackForm()
        {
            InitializeComponent();
            LoadTheme();
            client_Class = new Client_Class();
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
            lblTrackTemplatesize.ForeColor = ThemeColor.SecondaryColor;
        }
        private void TrackForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void btnStrtTrck_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(starttrck, header);
        }

        private void btnStpTrck_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(stoptrck, header);
        }

        private void btnPointToTrack_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(pointtrck, header);
        }
        private void btnOnVehicle_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(turnOnVehicle, header);
        }
        private void btnOffVehicle_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(turnOffVehicle, header);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            client_Class.SendMessage(recognitionToTracking, header);
        }
        private void comboBoxTSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTSize.Text == "Auto")
            {
                client_Class.SendMessage(sizeAuto, header);
            }
            else if(comboBoxTSize.Text == "32")
            {
                client_Class.SendMessage(size32,header);
            }
            else if(comboBoxTSize.Text == "64")
            {
                client_Class.SendMessage(size64, header);
            }
            else if(comboBoxTSize.Text == "128")
            {
                client_Class.SendMessage(size64, header);
            }
        }
    }
}
