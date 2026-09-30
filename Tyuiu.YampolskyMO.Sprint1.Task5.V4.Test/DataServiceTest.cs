using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint1.Task5.V4.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 13257;
            int res = ds.SecondsToHours(k);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}