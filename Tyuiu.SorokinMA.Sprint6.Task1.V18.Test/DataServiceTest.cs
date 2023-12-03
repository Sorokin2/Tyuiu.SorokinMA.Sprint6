using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int a = -3;
            int b = 3;
            int l = b - a+1;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(a, b);
            double[] wait = new double[l];
            wait[0] = 41.05;
            wait[1] = 27.96;
            wait[2] = 15.48;
            wait[3] = 1.00;
            wait[4] = -13.06;
            wait[5] = - 28.16;
            wait[6] = - 42.96;
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
