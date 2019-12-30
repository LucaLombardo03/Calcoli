using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1() 
        {
            double rad = Calc.RadQ(4);
            Assert.AreEqual(rad, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double rad = Calc.RadQ(-1);
            Assert.AreEqual(rad, double.NaN);
        }
    }
}
