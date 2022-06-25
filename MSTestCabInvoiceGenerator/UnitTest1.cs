global using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerators;
using System.Threading;
namespace MSTestCabInvoiceGenerator
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerators invoiceGenerator = null;

        //UC1 Calculate total fare
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerators(RideTypes.NORMAL);

            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
    }
}