using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.SorokinMA.Sprint6.Task1.V18
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
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб 23-1 Сорокин Михаил Анатольевич", "Сообщение", MessageBoxButtons.OK);
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
                int start = Convert.ToInt32(textBoxVarStart_SMA.Text);
                int stop = Convert.ToInt32(textBoxVarStop_SMA.Text);
                string line;
                int l = stop - start + 1;
                double[] a = ds.GetMassFunction(start, stop);
                textBoxResult_SMA.Text = "";
                textBoxResult_SMA.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_SMA.AppendText("+    X     +    f(x)    +" + Environment.NewLine);
                textBoxResult_SMA.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i < l; i++)
                {
                    line = String.Format("|{0,5:d}     |  {1, 7:f2}   | ", start, a[i]);
                    textBoxResult_SMA.AppendText(line + Environment.NewLine);
                    start++;
                }
                textBoxResult_SMA.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены  неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarStart_SMA_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
