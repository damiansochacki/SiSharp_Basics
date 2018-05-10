using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "July Report";
            string date = "July";
            string type = "My type";

            Report myReport = new Report(name, date, type);
            myReport.ReportType();
            Console.WriteLine(myReport.CreateReport());
            myReport.ReportCount(8);

            //create an instance 
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.53M);
            Console.WriteLine("Original invoice information");

         }
    }
}
