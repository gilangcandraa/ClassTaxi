using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drivertaksi
{
    public class taxi
    {
        public string DriverTaksi { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver name: {0}", DriverTaksi);
            Console.WriteLine("On duty: {0}", OnDuty);
            Console.WriteLine("Number of passanger: {0}", NumPassenger);
        }
        public void PickUpPassanger()
        {
            Console.Write(DriverTaksi);
            Console.WriteLine(" sedang menjemput penumpang");
        }
        public void DropOffPassanger()
        {
            Console.Write(DriverTaksi);
            Console.WriteLine(" selesai mengantar penumpang");
        }

    }
}
