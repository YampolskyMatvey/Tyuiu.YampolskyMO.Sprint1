using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint1.Task2.V29.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 600;

            var res = ds.ConvertSecondsToHours(value);

            Assert.AreEqual(10, res);
        }
    }
}