using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task2.V30.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int a = -3;
            int b = 3;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(a, b);
            double[] wait = new double[res.Length];
            wait[0] = -11.36;
            wait[1] = -8.00;
            wait[2] = - 2.62;
            wait[3] = 1.83;
            wait[4] = 4.49;
            wait[5] = 6.78;
            wait[6] = 10.58;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
