using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint6\Tyuiu.SorokinMA.Sprint6.Task5.V15\bin\Debug\Test.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 2, 3, 4, 5, 6, 7 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
