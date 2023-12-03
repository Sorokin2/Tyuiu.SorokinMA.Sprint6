using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinMA.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int row = matrix.GetUpperBound(0)+1;
            int col = matrix.Length/row;
            for(int i = 0;i<col; i++)
            {
                if (matrix[3, i] % 2 == 0) matrix[3, i] = 0;
            }
            return matrix;
        }
    }
}
