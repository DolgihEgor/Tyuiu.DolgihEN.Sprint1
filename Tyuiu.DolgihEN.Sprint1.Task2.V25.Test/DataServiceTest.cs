using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint1.Task2.V25.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(57, 59, res);
        }
    }
}
