using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinMA.Sprint6.Task2.V30.Lib
{
    public class DataService: ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] a = new double[l];
            int q = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 3) == 0) a[q] = 0;
                else a[q] = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x)), 2);
                q++;
            }
            return a;
        }
        
    }
}
