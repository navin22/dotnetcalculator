using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System;

namespace Tests
{
    [TestClass]
    public class CaculatorTests
    {
        Calculator _calc;
        public CaculatorTests()
        {
            _calc = new Calculator();
        }
        [TestMethod]
        public void shouldaddtwonumbers()
        {
            int res = _calc.Add(5, 3);
            Assert.AreEqual(res, 8);
        }
        [TestMethod]
        public void shouldsubstracttwonumbers()
        {
            int res = _calc.Sub(5, 3);
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        public void shouldmultiplytwonumbers()
        {
            int res = _calc.Multiply(3, 3);
            Assert.AreEqual(res, 9);
        }

        [TestMethod]
        public void shoulddividetwonumbers()
        {
            double res = _calc.Divide(8, 4);
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void divideshouldthrowexceptionwhendenomis0()
        {
            double res = _calc.Divide(8, 0);
        }
    }
}
