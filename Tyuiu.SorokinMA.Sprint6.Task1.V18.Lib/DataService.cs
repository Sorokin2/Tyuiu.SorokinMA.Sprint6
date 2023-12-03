using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinMA.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue +1;
            double[] a = new double[l];
            int q = 0;
            for(int x = startValue; x<=stopValue;x++)
            {
                if ((3 * x - 1.2) == 0) a[q] = 0;
                else a[q] = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2), 2);
                q++;
            }
            return a;
        }
    }
}
