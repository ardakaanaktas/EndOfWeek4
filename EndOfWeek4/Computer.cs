using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfWeek4
{
    internal class Computer : Devices //Devices sınıfından miras alındı.
    {
        public int usbPorts { get; set; } //Usb port sayısı
        public bool hasBluetooth { get; set; } //Bluetooth var mı yok mu

        public Computer() // Constructor sayesinde üretim tarihini atıyoruz
        {
            productionTime = DateTime.Now;
        }


        public override void getInfo()//Devices sınıfındaki getInfo metodu override edildi.
        {
            base.getInfo();//Base classın getInfo metodu çağrıldı.
            if (usbPorts == 2 || usbPorts == 4)//Usb port sayısı 2 veya 4 olabilir.
            {
                Console.WriteLine("Usb port sayısı: " + usbPorts);
            }
            else
            {
                usbPorts = -1;
                Console.WriteLine("Usb port sayısı yanlış girilmiştir.");
            }
            if (hasBluetooth)//Bluetooth var mı yok mu kontrolü yapıldı.
            {
                Console.WriteLine("Bluetooth: Var");
            }else
            {
                Console.WriteLine("Bluetooth: Yok");
            }
            Console.WriteLine("Üretim Tarihi: "+productionTime);
        }

        public override void getName()//Devices sınıfındaki getName metodu override edildi.
        {
            Console.WriteLine("Bilgisayarınızın adı ------> " + this.manufacturer);
        }

    }
}
