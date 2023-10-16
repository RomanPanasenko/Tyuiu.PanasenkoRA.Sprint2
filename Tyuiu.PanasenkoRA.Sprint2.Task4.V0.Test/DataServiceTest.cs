using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint2.Task4.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint2.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 0.5;
            double res = ds.Calculate(x, y);
            double wait = 7;
            Assert.AreEqual(wait, res);

        }
    }
}
