using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task3.V28.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] a = new int[,] { { -9, 8, 9, 16, -18 },
                                { -13, -11, -20, -15, 9 },
                                { 18, 13, -12, -15, -11 },
                                { 10, -2, 19, -4 , -10 },
                                {  6, -20, -4, 13, -14} };
    
        private void FormMain_Load(object sender, EventArgs e)
        {
            int row = a.GetUpperBound(0) + 1;
            int col = a.Length / row;
            dataGridViewResult_SMA.ColumnCount = col;
            dataGridViewResult_SMA.RowCount = row;

            for (int i = 0; i < col; i++) dataGridViewResult_SMA.Columns[i].Width = 30;
            for(int i = 0; i<row;i++)
            {
                for (int j =0; j<col;j++)
                {
                    dataGridViewResult_SMA.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {
            int row = a.GetUpperBound(0) + 1;
            int col = a.Length / row;
            int[,] res = ds.Calculate(a);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewResult_SMA.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб 23-1 Сорокин Михаил Анатольевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
