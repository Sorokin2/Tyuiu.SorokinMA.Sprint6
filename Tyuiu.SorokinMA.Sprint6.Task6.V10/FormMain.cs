using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint6.Task6.V10.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_SMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMA.ShowDialog();
            openFilePath = openFileDialogTask_SMA.FileName;
            textBoxInPut_SMA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SMA.Text = groupBoxInPut_SMA.Text + " " + openFileDialogTask_SMA.FileName;
            buttonDone_SMA.Enabled = true;
        }

        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {
            string str = "w";
            textBoxResult_SMA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
