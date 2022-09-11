using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;

namespace Class_Client
{

    public class Client_Class
    {
       
        Thread socketProccess; //THREAD kullanarak arayuz calisirken paralelinde arka planda socketin calismasini sagladik. (islemi siraya almak yerine ayni anda calismalarini sagladik)

        Socket clientSocket;
        IPAddress ipAddr;
        IPEndPoint clientEndPoint;
        string message;
        byte[] bytess;

        Gimbal_Camera_Control.Services.LoggerTemplate template_logger;

        static int kontrol = 0; // kullanacagim yapi icin tanimladim

        public Client_Class()
        {

            template_logger = Gimbal_Camera_Control.Services.LoggerTemplate.Instance;

            if (kontrol == 1) // 1 se içine gir değilse elseye
            {
                kontrol = 1; // 1 se 1 olarak devam etsin
            }
            else //eger 0 ise alttaki methoda girsin
            {
                construct_method(); // aşşağıdaki methodu calistiriyoruz
                kontrol = 1; //  kontrolu tekrar 1 yapiyorum
            }
        }  //burasi constructor bu cs cagirildiginda otomatik önce bunun icine bakiyor

        //asagidaki methoda sadece 0 oldugunda girecek ve girdikten sonra 1 dondugu icin tekrar girmeyecek
        //bir daha girmedigi icin de sadece bir kez socket baglantisi baslamis olacak
        //ama her seferinde tekrar tekrar baglanmayacagi icin de bu baglantiyi hafizada tutmamiz gerekecek bu yüzden res.cs

        public void construct_method()
        {
            socketProccess = new Thread(new ThreadStart(Connect));
            socketProccess.Start();     
        }
        public void Connect()
        {
            //   Socket olusturuyoruz
            ipAddr = IPAddress.Parse("127.0.0.1");   //127.0.0.1 

            clientEndPoint = new System.Net.IPEndPoint(IPAddress.Loopback, 0);
            clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Bind(clientEndPoint);
            
            // Baglantilari yapiyoruz

            clientSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(ipAddr, 2000));

            Gimbal_Camera_Control.res.entitySocket = clientSocket; //olusturdugumuz res.csi burada kullanarak socketin baglantisinin hafizada kalmasini sagladik 
        }
        public byte[] sendZoomPackage(int zoomLevel)
        {
            zoomLevel *= 10;
            int index = 0;
            byte[] package = new byte[20];
            //eb 90 10 55 aa dc 0d 31 00 00 53 00 64 00 00 00 00 00 6f db
            package[index++] = 0xEB;
            package[index++] = 0x90;
            package[index++] = 0x10;
            package[index++] = 0x55;
            package[index++] = 0xAA;
            package[index++] = 0xDC;
            package[index++] = 0x0D;
            package[index++] = 0x31;
            package[index++] = 0x00;
            package[index++] = 0x00;
            package[index++] = 0x53;

            byte[] temp = BitConverter.GetBytes(zoomLevel);

            package[index++] = temp[1];//zoom
            package[index++] = temp[0];//zoom
            package[index++] = 0x00;
            package[index++] = 0x00;
            package[index++] = 0x00;
            package[index++] = 0x00;
            package[index++] = 0x00;

            byte CHK = package[6];
            for (int i = 7; i < 17; i++)
            {
                CHK ^= package[i];
            }
            package[index++] = CHK;
            package[index++] = generateChecksum(package);

            Gimbal_Camera_Control.res.entitySocket.Send(package);

            string test = "";
            for (int i = 0; i < package.Length; i++)
            {
                test += package[i].ToString("X2") + " ";
            }
            Console.WriteLine("Client sent message " + BitConverter.ToString(package));
            return package;
        } 

        //public  sendIRPackage(string command )
        //{

        //    int packageIndex = 0;
        //    byte[] package= new byte[24];
        //    package[packageIndex++] = 0xEB;
        //    package[packageIndex++] = 0x90;
        //    package[packageIndex++] = 0x14;
        //    package[packageIndex++] = 0x55;
        //    package[packageIndex++] = 0xAA;
        //    package[packageIndex++] = 0xDC;
        //    package[packageIndex++] = 0x11;
        //    package[packageIndex++] = 0x30;
        //    package[packageIndex++] = 0x0F;

        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;

        //    package[packageIndex++] = 0x03;
        //    package[packageIndex++] = 0x82;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0x00;
        //    package[packageIndex++] = 0xAF;
        //    package[packageIndex++] = 0x5F;
        //    yeni.res.entitySocket.sendIRPackage(package);
        //}

        byte[] anglePackage = new byte[24];
        decimal sabit2 = 65536 / 360;

        public void sendPackageYP(decimal pitchAngle, decimal yawAngle) //açı döndürme
        {   byte[] temp;
            int packageIndex = 0;

            anglePackage[packageIndex++] = 0xEB;//tcp header 1
            anglePackage[packageIndex++] = 0x90;//tcp header 1
            anglePackage[packageIndex++] = 0x14;//tcp header 1
            anglePackage[packageIndex++] = 0x55;//header 1
            anglePackage[packageIndex++] = 0xAA;//header 2
            anglePackage[packageIndex++] = 0xDC;//header 3
            anglePackage[packageIndex++] = 0x11;//lenght
            anglePackage[packageIndex++] = 0x30;//command
            anglePackage[packageIndex++] = 0x0B;//type

            int yaw = Convert.ToInt32(yawAngle * sabit2);
            temp = BitConverter.GetBytes(yaw);

            anglePackage[packageIndex++] = temp[1];//yaw command 
            anglePackage[packageIndex++] = temp[0];//yaw command

            int pitch = Convert.ToInt32(pitchAngle * sabit2);
            temp = BitConverter.GetBytes(pitch);

            anglePackage[packageIndex++] = temp[1];//yaw command 
            anglePackage[packageIndex++] = temp[0];//yaw command

            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;
            anglePackage[packageIndex++] = 0x00;

            byte CHK = anglePackage[6];
            for (int i = 7; i < 22; i++)
            {
                CHK ^= anglePackage[i];
            }
            anglePackage[packageIndex++] = CHK;//checksum body
            anglePackage[packageIndex++] = generateChecksum(anglePackage, 3);//checksum general
            Gimbal_Camera_Control.res.entitySocket.Send(anglePackage);
            Console.WriteLine("Client sent message " + BitConverter.ToString(anglePackage));
        }

        //gondermemiz gereken mesaj formatini olusturdum
        public void SendMessage(byte[] dataToSend, byte[] headerToSend)
        {
            Thread thread = new Thread(delegate () //fonksiyon adi yerine delegate kullanabiliyoruz fonksiyonumuzu temsil ediyor
            {
                byte[] bytesToSend = dataToSend; 
                int elemanSayisi;
                byte[] header = headerToSend;
 
                //checksum hesaplama
                byte arraySum = 0;
                foreach (var item in bytesToSend)
                {
                    arraySum += (byte)item;
                }
                var checksum = (arraySum & 0xff);
 
                elemanSayisi = bytesToSend.Length; //dizideki eleman sayisi
 
                string hexString = BitConverter.ToString(bytesToSend);// BitConverter.ToString(); komutu ile ustte byte cevirdigimiz mesaji simdi hex cevirdik
                string baslik = BitConverter.ToString(header);
                message = baslik + "-" + Convert.ToString(elemanSayisi, 16) + "-" + hexString + "-" + checksum.ToString("X2");
                //              HEADER          +          DATA LEN +               DATA BODY          +         CHECKSUM
 
                string[] message_split = message.Split('-');
                bytess = new byte[message_split.Length];
                for (int i = 0; i < message_split.Length; i++)
                {
                    bytess[i] = byte.Parse(message_split[i], NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                }


                Gimbal_Camera_Control.res.entitySocket.Send(bytess); 


                template_logger.Sendlog_text = message;

                Console.WriteLine("Client sent message " + BitConverter.ToString(bytess));


                byte[] buffer = new byte[1024];
 
                while (true)
                {                    
                    int numberOfBytesReceived = Gimbal_Camera_Control.res.entitySocket.Receive(buffer);

                    byte[] receivedBytes = new byte[numberOfBytesReceived];

                    Array.Copy(buffer, receivedBytes, numberOfBytesReceived); //datanin okundugu yer

                    string receivedMessage = Encoding.Default.GetString(receivedBytes);

                    template_logger.Receivedlog_text = receivedMessage;

                    Console.WriteLine("Client received message:" + receivedMessage); //received mesaji da ekranda gosteriyoruz.
 
                }
                Console.ReadLine();

            });
            thread.Start();
        }

        //public void Angle(byte[] dataToSend,)
        //{

        //    if (dataToSend.Length == 47)
        //    {

        //        msb = hex(data_from_socket[30])
        //        lsb = hex(data_from_socket[31])


        //        value = int(msb, 0) * 256 + int(lsb, 0)


        //        print("Value :", value)

        //    angle = value * 360 / 65536

        //    print("Received : {} * 360 / 65536 = {}".format(value, angle))

        //     }
        // }
         public byte generateChecksum(byte[] package, int start_index = 3)
        {
            byte checksum = 0;
            byte data_start_index = (byte)start_index;
            byte checksum_index = (byte)(data_start_index + package[2]);                           // byte checksum_index = 12; 
                                                                                                   // data_start_index = (byte)(packet.Length - 9);
            if (start_index == 3)
            {
                checksum_index = (byte)(package.Length - 1);
            }
            else
            {
                checksum_index = (byte)(package.Length - 2);
            }


            for (byte i = data_start_index; i < checksum_index; i++)
            {
                checksum += package[i];
            }

            return checksum;
        }
}
}


    

