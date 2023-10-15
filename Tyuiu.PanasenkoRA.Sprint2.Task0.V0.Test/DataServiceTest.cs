using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint2.Task0.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint2.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1000;
            int y = 900;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, true, true, true };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
