using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PartTime: Employee
    {
        public PartTime(string first, string last, int phone, decimal rate) : base(first, last, phone)
        {
            HourlyRate = rate;
        }
        //field is not created 
        public decimal HourlyRate { get; set; }

       // public override void RunPayroll()
       // {
       // }
    }
}
