using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Январь", ds.FindMonthName(1999,1));
            Assert.AreEqual("Февраль", ds.FindMonthName(1999,2));
            Assert.AreEqual("Март", ds.FindMonthName(1999,3));
            Assert.AreEqual("Апрель", ds.FindMonthName(1999,4));
            Assert.AreEqual("Май", ds.FindMonthName(1999,5));
            Assert.AreEqual("Июнь", ds.FindMonthName(1999,6));
            Assert.AreEqual("Июль", ds.FindMonthName(1999,7));
            Assert.AreEqual("Август", ds.FindMonthName(1999,8));
            Assert.AreEqual("Сентябрь", ds.FindMonthName(1999,9));
            Assert.AreEqual("Октябрь", ds.FindMonthName(1999,10));
            Assert.AreEqual("Ноябрь", ds.FindMonthName(1999,11));
            Assert.AreEqual("Декабрь", ds.FindMonthName(1999,12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(1999, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(1999, 13);
            });
        }
    }
}
