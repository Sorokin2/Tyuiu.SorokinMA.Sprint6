using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task7.V25.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            int[,] a = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    a[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return a;
        }

        private void buttonOpenFile_SMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMA.ShowDialog();
            openFilePath = openFileDialogTask_SMA.FileName;
            int[,] a = new int[rows, colums];
            a = LoadFromFileData(openFilePath);
            dataGridViewLoadFromFile_SMA.ColumnCount = colums;
            dataGridViewLoadFromFile_SMA.RowCount = rows;
            dataGridViewResult_SMA.ColumnCount = colums;
            dataGridViewResult_SMA.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewLoadFromFile_SMA.Columns[i].Width = 25;
                dataGridViewResult_SMA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewLoadFromFile_SMA.Rows[r].Cells[c].Value = a[r, c];
                }
            }
            a = ds.GetMatrix(openFilePath);
            buttonDone_SMA.Enabled = true;
        }

        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {
            int[,] a = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewResult_SMA.Rows[r].Cells[c].Value = a[r, c];
                }
            }
            buttonSave_SMA.Enabled = true;
        }

        private void buttonSave_SMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SMA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SMA.ShowDialog();
            string path = saveFileDialogMatrix_SMA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);
            int rows = dataGridViewResult_SMA.RowCount;
            int columns = dataGridViewResult_SMA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) str += dataGridViewResult_SMA.Rows[i].Cells[j].Value + ";";
                    else str += dataGridViewResult_SMA.Rows[i].Cells[j].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_SMA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_SMA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_SMA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_SMA.ToolTipTitle = "Справка";
        }
    }
}
