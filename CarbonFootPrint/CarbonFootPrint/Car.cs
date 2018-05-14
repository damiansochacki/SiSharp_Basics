using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Car : ICarbonFootPrint
    {
        public Car(double gals)
        {
            Gallons = gals;
        }
        private double gallons;
        public double Gallons
        {
            get
            {
                return gallons;
            }
            set
            {
                if(value >= 0)
                {
                    //What exactly "value" is? Represents the potentially 
                    gallons = value;
                }
            }
        }
        public void CalcCarbonFootPrint()
        {
            Console.WriteLine("The carbon footprint for a car that {0}", Gallons, Gallons * 20);
        }

    }
}
