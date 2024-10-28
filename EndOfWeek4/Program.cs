using System.Numerics;

namespace EndOfWeek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            do
            {
                Console.WriteLine("Telefon Üretmek için 1 , Bilgisayar üretmek için 2 ye tıklayınız.");
                int.TryParse(Console.ReadLine(), out int choose);//1 seçilirse telefon 2 seçilirse bilgisayar üretilecek.Onun dışında seçimler hata vericek.
                if (choose == 1)//Telefon üretimi
                {
                    Phone phone = new Phone();//Phone sınıfından bir nesne oluşturuldu.
                    phone.serialNumber = "123456";//Seri numarası kullanıcıdan alınamayacağı için sistemde işlendi
                    Console.WriteLine("İşletim Sistemi giriniz:");
                    phone.operatingSystem = Console.ReadLine();//İşletim sistemi alındı
                    Console.WriteLine("Marka Giriniz:");
                    phone.manufacturer = Console.ReadLine();//Markası alındı
                    Console.WriteLine("Model Giriniz:");
                    phone.description = Console.ReadLine();//Açıklama olarak modeli alındı
                    phone.getName();//Telefonun adını yazdırmak için getName metodu çağrıldı.
                    phone.getInfo();//Telefonun bilgilerini yazdırmak için getInfo metodu çağrıldı.
                    Console.WriteLine("--------------------");

                }
                else if (choose == 2)//Bilgisayar üretimi
                {
                    Computer computer = new Computer();//Computer sınıfından bir nesne oluşturuldu.
                    computer.serialNumber = "654321";//Seri numarası kullanıcıdan alınamayacağı için sistemde işlendi
                    Console.WriteLine("İşletim Sistemi giriniz:");
                    computer.operatingSystem = Console.ReadLine();//İşletim sistemi alındı
                    Console.WriteLine("Marka Giriniz:");
                    computer.manufacturer = Console.ReadLine();//Markası alındı
                    Console.WriteLine("Model Giriniz:");
                    computer.description = Console.ReadLine();//Açıklama olarak modeli alındı
                    Console.WriteLine("Kaç usb portu olsun ? (2 veya 4 olabilir)");
                    computer.usbPorts = int.TryParse(Console.ReadLine(), out int usbPorts) ? usbPorts : -1;//Usb port sayısı alındı. 2 veya 4 değilse -1 olarak işlendi.
                    Console.WriteLine("Bluetooth olsun mu? (evet için \"e\")");
                    computer.hasBluetooth = Console.ReadLine().ToLower() == "e" ? true : false;//Bluetooth olup olmadığı alındı.
                    computer.getName();
                    computer.getInfo();
                    Console.WriteLine("--------------------");

                }else
                    Console.WriteLine("Hatalı giriş yaptınız.");

                Console.WriteLine("Tekrar Üretmek ister misiniz ? (evet için \"e\")");
                isContinue = Console.ReadLine().ToLower() == "e" ? true : false;
            }
            while (isContinue);



           

            

            

        }
    }
}
