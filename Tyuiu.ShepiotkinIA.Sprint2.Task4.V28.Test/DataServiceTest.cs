using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 40;
            double res = ds.Calculate(x, y);
            double wait = 7.366;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 40;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 7.839;
            Assert.AreEqual(wait, res);
        }
    }
}
