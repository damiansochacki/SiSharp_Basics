using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Bicycle : ICarbonFootPrint
    {
        public void CalcCarbonFootPrint()
        {
            Console.WriteLine("A bicycle has zero carbon footprint");
        }
    }
}
