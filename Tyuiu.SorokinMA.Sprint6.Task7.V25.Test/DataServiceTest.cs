using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint6\Tyuiu.SorokinMA.Sprint6.Task7.V25\bin\Debug\test.csv";
            DataService ds = new DataService();
            int[,] res = ds.GetMatrix(path);
            int[,] wait = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 2, 9 }, { 1, 2, 3, 4, 5, 6, 7, 2, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
