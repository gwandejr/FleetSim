using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FleetSim.Objects
{
    public class Car : Vehicle, ICar
    {
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string vehColor { get; set; }

        //Overload constructor 1
        void SetCarDesc(int year, string make, string model)
        {
            int Year = year;
            string Make = make;
            string Model = model;
        }

        //Overload constructor 2
        void SetCarProp(int year, string make, string model, string vehColor)
        {
            int Year = year;
            string Make = make;
            string Model = model;
            string VehColor = vehColor;
        }

    }
}
