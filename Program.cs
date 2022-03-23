using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugastaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi1 = new taxi();

            taxi1.drivername = "Jono";
            taxi1.onduty = true;
            taxi1.numpassenger = 10;

            taxi1.taxiinfo();
            taxi1.pickuppassenger();
            taxi1.dropoffpassenger();

            Console.ReadKey();
        }
    }
}
