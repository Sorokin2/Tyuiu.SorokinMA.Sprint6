using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string str = "**";
            string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint6\Tyuiu.SorokinMA.Sprint6.Task6.V10\bin\Debug\test.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(str, path);
            string wait = "qwer**r wet** ew**sf wqs** ";
            Assert.AreEqual(wait, res);
        }
    }
}
