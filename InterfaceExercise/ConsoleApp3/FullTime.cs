using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FullTime : Employee
    {
        public FullTime(string first, string last, int phone, decimal salary, int vacation) : base(first, last, phone)
        {
            SalaryRate = salary;
            VacationDays = vacation;
        }
        public decimal SalaryRate { get; set; }
        public int VacationDays { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + "is part time";
        }

        //?
       // public override void RunPayroll()
      //  {
     //  }
    }
}
