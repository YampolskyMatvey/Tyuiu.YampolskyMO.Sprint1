using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint1.Task7.V18.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double y = 0.0;
            double res = ds.Calculate(x, y);
            double wait = 0.5;
            Assert.AreEqual(wait, res);
        }
    }
}