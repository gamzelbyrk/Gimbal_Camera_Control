using Class_Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 


namespace Gimbal_Camera_Control
{

    public partial class FormMainMenu : Form
    {

        public class Win32Exception : System.Runtime.InteropServices.ExternalException { }

        //Fields (Alanlar)
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor (yapı)
        private int borderSize;
        public FormMainMenu()
        {

            InitializeComponent();
            this.Padding = new Padding(borderSize);

            random = new Random();

            btnCloseChildForm.Visible = false;
            this.Text = string.Empty; //menunun textini kaldirdik.
            this.ControlBox = false; //ana formun kenarliklarini kaldirdik.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //menu boyunu max alana surukleyerek maximize ediyoruz.         
            //olusturdugumuz socket clienti uygulamanin arayuzunde calistirabilmek icin burada cagirdik

        }

        //formu tıklama ile surukleyebilmek icin bu kodu ekledik 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
         
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int v);


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);

            } //Renk zaten seçilmişse farklı bir renk seçmek için tekrar seçim işlemi 

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162)); //ilgili butona tikladigimizda o butonun fontu büyüyor.
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3); // logo panelinde değişen renklere göre title panelinin renklerini de degistiriyoruz.
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3); //Mevcut olan tema rengini kayit ediyoruz.
                    btnCloseChildForm.Visible = true;
                    //labelTitle.Text = btnCloseChildForm.Text;
                }
            }

        }
            private void DisableButton()
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(91,75,138);
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162)); //azaltildi

                    }
                }
            }
        

        Forms.Form_ControlMenu formControl = new Forms.Form_ControlMenu();
        Forms.FormLogDosyalari FormLogDosyalari = new Forms.FormLogDosyalari();

        //bu yapi yuzunden her form degistirdigimde servera tekrar baglaniyoruz
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text; //ust baslik yeni actigimiz formlarin adina gore degisecek.

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();  //açık olan formlari kapatmak icin sol kosede bir button

        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(97,167,173);
            panelLogo.BackColor = Color.FromArgb(101,93,138);
            currentButton = null; //gecerlibutton
            btnCloseChildForm.Visible = false; //resetlemek icin acik olan formlarin visiblenı false yaptık gorunmeyecek.
        }

        private void btnControl_Menu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_ControlMenu(), sender); //child menuleri cagiriyoruz ilgili click altina
        }
        private void btnLogger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLogDosyalari(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSetting(), sender);
        }

       private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                Application.Exit(); //uygulamadan cikis
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //tam ekran yapma

            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //ekran minimize
        }




    }
    }




