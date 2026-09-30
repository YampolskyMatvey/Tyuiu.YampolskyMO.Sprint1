using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint1.Task6.V9.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "текст";
            string res = ds.MoveLetterToStart(str);
            string wait = "ттекст";
            Assert.AreEqual(wait, res);
        }
    }
}
