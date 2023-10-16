using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint2.Task5.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint2.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Месяц - Январь, время года - Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Месяц - Февраль, время года - Зима", ds.FindMonthSeason(2));
            Assert.AreEqual("Месяц - Март, время года - Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Месяц - Апрель, время года - Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Месяц - Май, время года - Весна", ds.FindMonthSeason(5));
            Assert.AreEqual("Месяц - Июнь, время года - Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Месяц - Июль, время года - Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Месяц - Август, время года - Лето", ds.FindMonthSeason(8));
            Assert.AreEqual("Месяц - Сентябрь, время года - Осень", ds.FindMonthSeason(9));
            Assert.AreEqual("Месяц - Октябрь, время года - Осень", ds.FindMonthSeason(10));
            Assert.AreEqual("Месяц - Ноябрь, время года - Осень", ds.FindMonthSeason(11));
            Assert.AreEqual("Месяц - Декабрь, время года - Зима", ds.FindMonthSeason(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });

        }
    }
}
