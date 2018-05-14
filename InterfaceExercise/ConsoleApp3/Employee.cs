using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Employee : IPayable
    {
        private string first;
        private string last;
        private int phone;

        public Employee (string first, string last, int phone)
        {
            FirstName = first;
            LastName = last;
            PhoneNo = phone;
        }
        //property nie odnoszą się do pół (w ciele), dlaczego tak jest?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public decimal Salary { get; set; }

        public decimal GetPaymentAmount()
        {
            return Salary;
        }

      //  public abstract void RunPayroll();
    }
}
