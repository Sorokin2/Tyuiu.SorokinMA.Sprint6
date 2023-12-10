using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string str, string path)
        {
            string res = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] a;
                while ((line=reader.ReadLine())!= null)
                {
                    a = line.Split(' ');
                    a = a.Where(x => x.Contains(str)).ToArray();
                    res += String.Join(" ", a)+" ";                    
                }
            }
            return res;
        }
    }
}
