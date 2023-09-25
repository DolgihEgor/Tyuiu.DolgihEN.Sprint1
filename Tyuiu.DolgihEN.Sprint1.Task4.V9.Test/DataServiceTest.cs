using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint1.Task4.V9.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double wait = -5.288;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
