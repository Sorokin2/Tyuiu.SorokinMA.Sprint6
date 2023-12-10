using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task4.V27.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб 23-1 Сорокин Михаил Анатольевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_SMA.Text);
                int stop = Convert.ToInt32(textBoxStop_SMA.Text);
                int l = ds.GetMassFunction(start, stop).Length;
                double[] a = ds.GetMassFunction(start,stop);
                this.chartFunction_SMA.Titles.Clear();
                this.chartFunction_SMA.Titles.Add("График функции");
                this.chartFunction_SMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SMA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SMA.Text = "";
                chartFunction_SMA.Series[0].Points.Clear();
                for (int i = 0; i < l; i++)
                {
                    this.chartFunction_SMA.Series[0].Points.AddXY(start, a[i]);
                    textBoxResult_SMA.AppendText(a[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены  неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SMA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
