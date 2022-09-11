using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;



namespace Gimbal_Camera_Control  
{
    public class res
    {
        public static Socket entitySocket { get; set; }

        //bir kez ilgili forma girip bağlantı yaptığımızda çıkıp geri geldiğimizde tekrar bağlanmaması için
        // yaptığımız bu bağlantının get set işlemiyle hafızamızda tutulmasını sağlamak için böyle bir yapı oluşturduk. 
        //Bu yapiyi baglanti kurarken ve mesaj gonderirken hafizada tutabilmek icin kullaniyoruz
    }
}
