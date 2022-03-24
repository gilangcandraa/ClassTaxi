using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drivertaksi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi=new taxi();

            taxi.DriverTaksi = "Saeb";
            taxi.OnDuty = true;
            taxi.NumPassenger = 2;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
