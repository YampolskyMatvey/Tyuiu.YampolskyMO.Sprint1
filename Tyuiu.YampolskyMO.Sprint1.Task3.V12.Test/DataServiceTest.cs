using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint1.Task3.V12.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double res = ds.TriangleArea(x, y);
            double wait = 3.0;
            Assert.AreEqual(wait, res);
        }
    }
}