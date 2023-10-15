using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint2.Task1.V0.Lib;
// (True, False, True, False, True, False), при a = 325, b = 325, c = 242, d = 324
namespace Tyuiu.PanasenkoRA.Sprint2.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
