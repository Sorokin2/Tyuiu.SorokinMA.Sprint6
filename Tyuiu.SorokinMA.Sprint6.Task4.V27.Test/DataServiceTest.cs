using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task4.V27.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -3, stop = 3;
            double[] a = new double[stop - start + 1];
            a[0] = -7.22;
            a[1] = -5.04;
            a[2] = 0.00;
            a[3] = -0.30;
            a[4] = 2.57;
            a[5] = 6.40;
            a[6] = 10.04;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(a, res);
        }
    }
}
