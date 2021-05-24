using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CabInvoiceGenerator;


namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Distance_TIme_Return_TotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double Expected = 25;
            double Actual = invoiceGenerator.CalculateFare(distance, time);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
