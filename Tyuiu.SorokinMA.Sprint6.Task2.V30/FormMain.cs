using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task2.V30.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб 23-1 Сорокин Михаил Анатольевич", "Сообщение", MessageBoxButtons.OK);
        }
        private void textBoxVarStart_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }
        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {

            try
            {
                this.dataGridViewResult_SMA.Rows.Clear();
                this.chartFunction_SMA.Titles.Clear();
                this.chartFunction_SMA.Series[0].Points.Clear();
                int start = Convert.ToInt32(textBoxVarStart_SMA.Text);
                int stop = Convert.ToInt32(textBoxVarStop_SMA.Text);
                int l = stop - start + 1;
                double[] a = ds.GetMassFunction(start, stop);

                this.chartFunction_SMA.Titles.Add("График функции");
                this.chartFunction_SMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SMA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < l; i++)
                {
                    this.dataGridViewResult_SMA.Rows.Add(Convert.ToString(start), Convert.ToString(a[i]));
                    this.chartFunction_SMA.Series[0].Points.AddXY(start, a[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены  неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResult_SMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SMA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SMA.BackColor = Color.Red;
        }

        private void buttonDone_SMA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SMA.BackColor = Color.Green;
        }

        private void buttonDone_SMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SMA.BackColor = Color.Blue;
        }
    }
}
