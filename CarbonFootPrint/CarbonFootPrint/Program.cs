using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarbonFootPrint[] list = new ICarbonFootPrint[3];
            list[0] = new Bicycle();
            list[1] = new Building(2500);
            list[2] = new Car(50);

            foreach(ICarbonFootPrint element in list)
            {
                element.CalcCarbonFootPrint();
            }
        }
    }
}
