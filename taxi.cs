using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugastaxi
{
    public class taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        private string yesno()
        {
            return onduty ? "Yes" : "No";
        }

        public void taxiinfo()
        {
            Console.WriteLine("Driver Name : {0}", drivername);
            Console.WriteLine("On Duty : {0} ", yesno());
            Console.WriteLine("Number of Passenger : {0}", numpassenger);
        }

        public void pickuppassenger()
        {
            Console.WriteLine(Environment.NewLine+"{0} Sedang Menjemput penumpang", drivername);
        }

        public void dropoffpassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", drivername);
        }
    }
}
