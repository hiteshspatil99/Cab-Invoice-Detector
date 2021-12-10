using NUnit.Framework;

namespace CabInvoiceGenaratorTestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(5.0, 2);
            double result = invoice.CalculateFare();
            Assert.AreEqual(result, 52);
        }
    }
}