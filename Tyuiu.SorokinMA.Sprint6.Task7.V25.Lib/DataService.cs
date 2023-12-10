using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;
            int[,] a = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    a[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            for (int r = 0; r < rows; r++)
            {
                if (a[r, 7] % 5 == 0) a[r, 7] = 2;
            }
            return a;
        }
    }
}
