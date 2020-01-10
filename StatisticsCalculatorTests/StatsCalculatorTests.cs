using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;


namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatsCalculatorTests
    {
        private readonly double[] ArrayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        StatsCalculator mn = new StatsCalculator();

        [TestMethod()]
        public void MeanTest()
        {
            Assert.AreEqual(5, mn.Mean(ArrayList));
        }
    }
}