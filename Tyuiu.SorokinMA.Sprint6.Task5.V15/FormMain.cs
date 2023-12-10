using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task5.V15.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint6\Tyuiu.SorokinMA.Sprint6.Task5.V15\bin\Debug\InPutFileTask5V15.txt";
        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_SMA.ColumnCount = 2;
                dataGridViewResult_SMA.Columns[0].Width = 20;
                dataGridViewResult_SMA.Columns[1].Width = 50;
                this.chartDiag_SMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiag_SMA.ChartAreas[0].AxisY.Title = "Ось Y";
                chartDiag_SMA.Series[0].Points.Clear();
                double[] a = ds.LoadFromDataFile(path);
                for (int i = 0; i < a.Length; i++)
                {
                    dataGridViewResult_SMA.Rows.Add(Convert.ToString(i), Convert.ToString(a[i]));
                    chartDiag_SMA.Series[0].Points.AddXY(i, a[i]);
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так с файлом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_SMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб 23-1 Сорокин Михаил Анатольевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
