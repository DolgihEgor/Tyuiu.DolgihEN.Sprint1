using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint1.Task6.V16.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет!?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
