using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects
{

    public class Vehicle : IVehicle
    {

        public string vin { get; set; }
        public int mileage { get; set; }
        public string carColor { get; set; }
        public int lastServicedMileage { get; set; }
        public string lastServicedDate { get; set; }

        public void TuneUp()
        {
            if (mileage - lastServicedMileage >= 30000)
            {
                lastServicedMileage = mileage;
                lastServicedDate = DateTime.Today.ToShortDateString();
                Console.WriteLine($"Vehicle tuned up at {lastServicedMileage}");
            }

            if (mileage >= 100000)
            {
                RebuildEngine();
            }

        }

        public void RebuildEngine()
        {
            mileage = 0;
            lastServicedMileage = 0;
            lastServicedDate = DateTime.Today.ToShortDateString();
            Console.WriteLine($"Engine rebuilt on {lastServicedDate}");
        }

    }
}
