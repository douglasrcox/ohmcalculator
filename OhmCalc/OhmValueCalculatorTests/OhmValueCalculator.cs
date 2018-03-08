using Microsoft.VisualStudio.TestTools.UnitTesting;
using OhmCalc.Classes;

namespace OhmValueCalculatorTests
{
    [TestClass]
    public class OhmValueCalculator
    {
        [TestMethod]
        public void NoArgs()
        {
            var ohmValCalc = new OhmCalc.Classes.OhmValueCalculator();

            Assert.AreEqual(ohmValCalc.CalculateOhmValue(string.Empty, string.Empty, string.Empty, string.Empty), 0);
        }

        [TestMethod]
        public void WorkingValue()
        {
            var ohmValCalc = new OhmCalc.Classes.OhmValueCalculator();

            Assert.AreEqual(ohmValCalc.CalculateOhmValue("violet", "blue", "green", "yellow"), 7980000);
        }
    }
}
