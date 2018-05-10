using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace InvoiceTest
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void TestGetInvoiceAmount()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.53M);
            Assert.AreEqual(31.90M, invoice1.GetInvoiceAmount());
        }
    }
}
