using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfWeek4
{
    internal abstract class Devices //Abstract class oluşturuldu.
    {
        public string serialNumber;
        public DateTime productionTime;
        public string manufacturer;
        public string description;
        public string operatingSystem;

        public virtual void getInfo() //Virtual metot oluşturuldu.
        {
            Console.WriteLine("Serial Number: " + serialNumber);
            Console.WriteLine("Production Time: " + productionTime);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Operating System: " + operatingSystem);
        }

        public abstract void getName(); //Abstract metot oluşturuldu.
    }
}
