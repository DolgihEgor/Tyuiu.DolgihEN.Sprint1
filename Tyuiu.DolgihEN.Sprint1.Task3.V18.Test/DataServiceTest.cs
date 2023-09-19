using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint1.Task3.V18.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 4;
            double c = 4;
            double wait = 0.5;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
