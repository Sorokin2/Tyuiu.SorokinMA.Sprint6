using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinMA.Sprint6.Task4.V27.Lib
{
    public class DataService : ISprint6Task4V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] a = new double[l];
            double y;
            int k = 0;
            for(int x = startValue; x<=stopValue; x++)
            {
                if (x + 1 == 0) y = 0;
                else y = Math.Round(Math.Cos(x)/(x+1) - Math.Cos(x) *1.3 +3*x,2);
                a[k] = y;
                k++;
            }
            return a;
        }
    }
}
