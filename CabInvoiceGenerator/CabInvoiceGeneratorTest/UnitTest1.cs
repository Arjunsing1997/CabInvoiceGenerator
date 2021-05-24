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

        //UC2
        [TestMethod]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            //initialising an instance
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            //passing values i.e distance and time through array 
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(2.0, 2),
                new Ride(4.0, 4),
                new Ride(3.0, 3)
            };
            double expected = 132;
            //Act
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, summary.totalFare);
        }
    }


}
