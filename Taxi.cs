using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectTaxi
{
    class Taxi
    {
        // PROPERTIES //
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo() // METHOD
        {
            Console.WriteLine("Driver Information\n");
            Console.WriteLine("Driver Name          : {0}", DriverName);
            Console.WriteLine("On Duty              : {0}", OnDuty);
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }

        public void PickUpPassenger() // METHOD
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        
        public void DropOffPassenger() // METHOD
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
