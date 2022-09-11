using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Gimbal_Camera_Control.Services
{
    public sealed class LoggerTemplate
    {
        private LoggerTemplate() { }
        private static LoggerTemplate instance = null;
        public static LoggerTemplate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggerTemplate();
                }
                return instance;
            } //bu yap� sayesinde bir kez kal�t�m yap�lacak ayn� nesneyi s�rekli
              //yeniden olu�turmadan farkl� formlarda bellekten kullanabilece�iz
        }
        private string logFile = "";
        private string logFolder = Application.StartupPath.ToString() + @"\Log";
        private string fileName = "logFile_Template_";
        private string fileExt = ".csv";
        private string headers = "";
        private Thread logFileWriter;
        private bool logStatus = false;
        private int frequencyMilliSecond = 200;
        private StringBuilder dataBuilder;
        private string datas = "";
        public string Sendlog_text = "";
        public string Receivedlog_text = "";

        public float log_test_1;
        public Int16 log_test_2; //baslatmak istedigimiz deger olursa degistirebiliriz.

        public void startLog(int frequencyMilliSecond)
        {                   //toplam milisaniyede gecen 
            this.frequencyMilliSecond = frequencyMilliSecond;
            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }
            logFile = string.Empty + logFolder + @"\" + fileName + DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss").ToString() + fileExt; //isimlendirme kullan�lacak

            //basliklar
            headers =
                "System Date:" + "   " +
                "System Time:" + "       " +
                "Sent:" + "                                      " +
                //"Received:" + "    " +
                Environment.NewLine;

            File.WriteAllText(logFile, headers, Encoding.UTF8);
            logStatus = true;
            logFileWriter = new Thread(new ThreadStart(logFileWriter_DoWork)); //arka planda paralelde calismasini thread ile sagladik

            logFileWriter.Start();
        }
        public void stopLog()
        {
            logStatus = false;
        }

        public void logFileWriter_DoWork()
        {
            do
            {
                dataBuilder = new StringBuilder();

                datas =  //yazim sekli
                    DateTime.Now.ToString("dd.MM.yyyy") + ";" + "    " +
                    DateTime.Now.ToString("HH:mm:ss:ff") + ";" + "              " +
                    Sendlog_text + ";" + "                                    " +
                    //Receivedlog_text + ";" + "                                    " +
                    //log_test_2.ToString() + ";" + "     " + 
                    Environment.NewLine;

                dataBuilder.Append(datas);
                File.AppendAllText(logFile, dataBuilder.ToString(), Encoding.UTF8); //dosyayi acip belirtilenleri dosyaya ekler

                Sendlog_text = "";
                //Receivedlog_text = "";

                Thread.Sleep(frequencyMilliSecond); //Thread sinifina ait sleep(); komutunu kullanmak, ge�erli i� par�ac���n�n milisaniye veya y�nteme ge�irdi�iniz zaman aral��� i�in hemen engellemesine neden olur ve zaman diliminin geri kalan�n� ba�ka bir i� par�ac���na verir. Bu aral�k ge�tikten sonra, uyku i� par�ac��� y�r�tmeyi s�rd�r�r.

            } while (logStatus);
        }
    }
}
