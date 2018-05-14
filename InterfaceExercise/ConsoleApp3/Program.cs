using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the variables to hold instances of each object
            //employee 1
            string firstName = "Damian";
            string lastName = "Smith";
            int phone = 456544544;
            decimal salary = 5000m;
            int vacationDays = 10;

            FullTime newEmp = new FullTime(firstName, lastName, phone, salary, vacationDays);

            string firstName2 = "Marian";
            string lastName2 = "Welll";
            int phone2 = 45642224;
            decimal rate = 16.00m;

            PartTime newPT = new PartTime(firstName2, lastName2, phone2, rate);
             
            //What exactly does it means?
            //New list of objects 
            List<Employee> lists = new List<Employee>();
            //adding newly created instances 
            lists.Add(newEmp);
            lists.Add(newPT);

            foreach (Employee emp in lists)
            {
                Console.WriteLine(emp.ToString());
            }

            IPayable[] payableObjects = new IPayable[4];
            payableObjects[0] = new Invoice("222", "Socks", 10, 9.99M);
            payableObjects[1] = new Invoice("223", "Socksssss", 10, 9.99M);
            payableObjects[2] = new Invoice("224", "Sockszzzzzz", 10, 9.99M);
            payableObjects[3] = new Invoice("225", "Sockzzzzzs", 10, 9.99M);

            foreach(var currentPayable in payableObjects)
            {
                Console.WriteLine("Payment due: { 0:C}", currentPayable.GetPaymentAmount());
            } 
        }

    }
}
