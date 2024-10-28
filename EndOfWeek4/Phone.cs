using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfWeek4
{
    internal class Phone: Devices //Devices sınıfından miras alındı.
    {

        public Phone() //Constructor sayesinde üretim tarihini atıyoruz
        {
            productionTime = DateTime.Now;
        }

        public override void getInfo() //Devices sınıfındaki getInfo metodu override edildi.
        {
            base.getInfo();
            Console.WriteLine("Üretim Tarihi: " + productionTime);
        }

        public override void getName() //Devices sınıfındaki getName metodu override edildi.
        {
            Console.WriteLine("Telefonunuzun adı ------> " + this.manufacturer);
        }

    }
}
