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
    public partial class FormSetting : Form
    {
        Client_Class client_Class;
        public byte[] down = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x00, 0x00, 0xF8, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8 };
        public byte[] home = new byte[] { 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x04, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x13 };  //düzenle
        byte[] header = new byte[2] { 0xEB, 0x90 };
        public FormSetting()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadTheme();
            client_Class = new Client_Class();
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
            lblPitchYaw.ForeColor = ThemeColor.PrimaryColor;
            lblCross.ForeColor = ThemeColor.PrimaryColor;
            lblDegree.ForeColor = ThemeColor.PrimaryColor;
            lblEnableOSD.ForeColor = ThemeColor.PrimaryColor;
            lblGPS.ForeColor = ThemeColor.PrimaryColor;
            lblTime.ForeColor = ThemeColor.PrimaryColor;
            lblVLMAG.ForeColor = ThemeColor.PrimaryColor;
            lblBigFont.ForeColor = ThemeColor.PrimaryColor;
            lblTimeInput.ForeColor = ThemeColor.PrimaryColor;
            lblGPSInput.ForeColor = ThemeColor.PrimaryColor;
            lblPYInput.ForeColor = ThemeColor.PrimaryColor;
            lblVLMAGInput.ForeColor = ThemeColor.PrimaryColor;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
