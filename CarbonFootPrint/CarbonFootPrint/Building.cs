using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Building : ICarbonFootPrint
    {
        public Building(int squareFeet)
        {
            SquareFeet = squareFeet;
        }

        private int sqft;
        public int SquareFeet
        {
            //get returns field === sqft 
            get
            {
                return sqft;
            }
            set
            {
                if (value >= 0)
                {
                    sqft = value;
                }
            }

        }
        public void CalcCarbonFootPrint()
        {
            Console.WriteLine("Carbon footprint for a building of {0} square feet is:", SquareFeet, SquareFeet * 134);
        }


    }
}
