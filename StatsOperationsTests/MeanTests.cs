using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class MeanTests
    {
         private readonly double[] ArrayList = {1,2,3,4,5,6,7,8,9,10 };
        
        [TestMethod()]
        public void meanTest()
        {
            Assert.AreEqual(5, StatsOperations.Mean.mean(ArrayList));
        }
    }
}