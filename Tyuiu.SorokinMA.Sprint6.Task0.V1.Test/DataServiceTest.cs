using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task0.V1.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int x = 2;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            double wait =0.2;
            Assert.AreEqual(wait, res);
        }
    }
}
