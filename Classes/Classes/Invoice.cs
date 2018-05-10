using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Invoice
    {
        //private variables
        private int quantity;
        private decimal price;

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        //constructor 
        public Invoice(string part, string desc, int qty, decimal price)
        {
            PartNumber = part;
            PartDescription = desc;
            Quantity = qty;
            Price = price;
        }
        public decimal GetInvoiceAmount()
        {
            return Quantity * Price;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                { quantity = value; }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
               if (value >= 0)
                { price = value; }
            }
        }


    }
}
