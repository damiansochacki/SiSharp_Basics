using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Report
    {

        private string name;
        private string date;
        private string type;

        public Report(string name, string date, string type)
        {
            Name = name;
            Date = date;
            Type = type;
        }
        public void ReportType()
        {
            Console.WriteLine("To jest moja testowa strona {0}", Type);
        }
        public string CreateReport()
        {
            return string.Format("I am creating the {0} Report", Name);
        }
        public void ReportCount(int number)
        {
            Console.WriteLine("There are {0} lines in the report", number);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }





    }
}
