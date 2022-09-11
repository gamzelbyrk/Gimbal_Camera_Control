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
using Excelapp = Microsoft.Office.Interop.Excel;
using Class_Client;

namespace Gimbal_Camera_Control.Forms
{
    public partial class FormLogDosyalari : Form
    {
        Client_Class client_Class;
        public FormLogDosyalari()
        {
            InitializeComponent();
            LoadTheme();
        }


        Services.LoggerTemplate template_logger = Services.LoggerTemplate.Instance;

        //Services.LoggerTemplate template_logger = new Services.LoggerTemplate();

        private void FormLogDosyalari_Load(object sender, EventArgs e)
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
            labelSayac.ForeColor = ThemeColor.SecondaryColor;
            lblLogOp.ForeColor = ThemeColor.PrimaryColor;
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string DosyaYolu;
            string DosyaAdi;
            DataTable dt;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel File | *.xls; *.xlsx; *.xlsm; *.csv"; //dosya uzanti filtrelemesi

            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;// sectigimiz dosyanin konumu
                DosyaAdi = file.SafeFileName;// sectigimiz dosyanin adi.

                Excelapp.Application excelapp = new Excelapp.Application();
                if (excelapp == null)
                { //Excel var mı yok mu.
                    MessageBox.Show("Excel is not installed.");
                    return;
                }
                //Excel aciyoruz.
                Excelapp.Workbook excelBook = excelapp.Workbooks.Open(DosyaYolu);

                Excelapp._Worksheet excelSheet = excelBook.Sheets[1];

                Excelapp.Range excelRange = excelSheet.UsedRange;
                int satirSayisi = excelRange.Rows.Count; //Sayfanın satır sayısını alır.
                int sutunSayisi = excelRange.Columns.Count;//Sayfanın sütun sayısını alır.
                dt = ToDataTable(excelRange, satirSayisi, sutunSayisi);
                dataGridV.DataSource = dt;
                dataGridV.Refresh();
                //Okuduktan Sonra Excel Uygulamasını Kapatıyoruz.
                excelapp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp);
            }
            else
            {
                MessageBox.Show("File not selected!");
            }
        }

        public DataTable ToDataTable(Excelapp.Range range, int rows, int cols)
        {
            DataTable table = new DataTable();
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                { // ilk satiri sutun adi olarak kullandıgı icin bunlari sutun adi seklinde kaydediyoruz
                  
                    for (int j = 1; j <= cols; j++)
                    {
                        //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            table.Columns.Add(range.Cells[i, j].Value2.ToString());
                        else //Boş olduğunda Kaçınsı Sutünsa Adı veriliyor.
                            table.Columns.Add(j.ToString() + ".Column");
                    }
                    continue;
                }
                // okunan verileri yan yana siralamak için
                var yeniSatir = table.NewRow();
                for (int j = 1; j <= cols; j++)
                {
                    //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                    else // null hucrede hatayi onlemek icin
                        yeniSatir[j - 1] = String.Empty;
                }
                table.Rows.Add(yeniSatir);
            }
            return table;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            template_logger.startLog(1000); //loglamayı baslattık
            
            //dataBuilder.AppendLine(client_Class.SendMessage(,));
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            template_logger.stopLog(); //loglamayi bitirdik.
            timer1.Stop();
        }

        int sayac = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = sayac;  //zamanlayiciyi olusturduk

            labelSayac.Text = sayac.ToString();
            sayac++;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSayac_Click(object sender, EventArgs e)
        {

        }
    }
    }

