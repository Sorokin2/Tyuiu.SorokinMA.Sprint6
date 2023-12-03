using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task3.V28.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] a = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 2, 1, 4 }, };
            int[,] wait = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 0, 1, 0 }, };
            DataService ds = new DataService();

            CollectionAssert.AreEqual(wait, ds.Calculate(a));
        }
    }
}
