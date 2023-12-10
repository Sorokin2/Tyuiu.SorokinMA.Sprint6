
namespace Tyuiu.SorokinMA.Sprint6.Task5.V15
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInPut_SMA = new System.Windows.Forms.Panel();
            this.panelOutPut_SMA = new System.Windows.Forms.Panel();
            this.panelDiag_SMA = new System.Windows.Forms.Panel();
            this.splitterOutPutAndDiagPanels_SMA = new System.Windows.Forms.Splitter();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.dataGridViewResult_SMA = new System.Windows.Forms.DataGridView();
            this.chartDiag_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.panelInPut_SMA.SuspendLayout();
            this.panelOutPut_SMA.SuspendLayout();
            this.panelDiag_SMA.SuspendLayout();
            this.groupBoxOutPut_SMA.SuspendLayout();
            this.groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInPut_SMA
            // 
            this.panelInPut_SMA.Controls.Add(this.buttonHelp_SMA);
            this.panelInPut_SMA.Controls.Add(this.buttonOpenFile_SMA);
            this.panelInPut_SMA.Controls.Add(this.buttonDone_SMA);
            this.panelInPut_SMA.Controls.Add(this.groupBoxTask_SMA);
            this.panelInPut_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.panelInPut_SMA.Name = "panelInPut_SMA";
            this.panelInPut_SMA.Size = new System.Drawing.Size(784, 95);
            this.panelInPut_SMA.TabIndex = 0;
            // 
            // panelOutPut_SMA
            // 
            this.panelOutPut_SMA.Controls.Add(this.groupBoxOutPut_SMA);
            this.panelOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_SMA.Location = new System.Drawing.Point(0, 95);
            this.panelOutPut_SMA.Name = "panelOutPut_SMA";
            this.panelOutPut_SMA.Size = new System.Drawing.Size(183, 366);
            this.panelOutPut_SMA.TabIndex = 0;
            // 
            // panelDiag_SMA
            // 
            this.panelDiag_SMA.Controls.Add(this.chartDiag_SMA);
            this.panelDiag_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiag_SMA.Location = new System.Drawing.Point(183, 95);
            this.panelDiag_SMA.Name = "panelDiag_SMA";
            this.panelDiag_SMA.Size = new System.Drawing.Size(601, 366);
            this.panelDiag_SMA.TabIndex = 0;
            // 
            // splitterOutPutAndDiagPanels_SMA
            // 
            this.splitterOutPutAndDiagPanels_SMA.Location = new System.Drawing.Point(183, 95);
            this.splitterOutPutAndDiagPanels_SMA.Name = "splitterOutPutAndDiagPanels_SMA";
            this.splitterOutPutAndDiagPanels_SMA.Size = new System.Drawing.Size(3, 366);
            this.splitterOutPutAndDiagPanels_SMA.TabIndex = 1;
            this.splitterOutPutAndDiagPanels_SMA.TabStop = false;
            // 
            // groupBoxOutPut_SMA
            // 
            this.groupBoxOutPut_SMA.Controls.Add(this.dataGridViewResult_SMA);
            this.groupBoxOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(183, 366);
            this.groupBoxOutPut_SMA.TabIndex = 0;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(492, 86);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие";
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SMA.Location = new System.Drawing.Point(520, 12);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(80, 67);
            this.buttonDone_SMA.TabIndex = 1;
            this.buttonDone_SMA.Text = "Выполнить";
            this.buttonDone_SMA.UseVisualStyleBackColor = false;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            // 
            // buttonOpenFile_SMA
            // 
            this.buttonOpenFile_SMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_SMA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenFile_SMA.Location = new System.Drawing.Point(606, 12);
            this.buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            this.buttonOpenFile_SMA.Size = new System.Drawing.Size(80, 67);
            this.buttonOpenFile_SMA.TabIndex = 1;
            this.buttonOpenFile_SMA.Text = "Открыть файл";
            this.buttonOpenFile_SMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SMA.Click += new System.EventHandler(this.buttonOpenFile_SMA_Click);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_SMA.Location = new System.Drawing.Point(692, 12);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(80, 67);
            this.buttonHelp_SMA.TabIndex = 1;
            this.buttonHelp_SMA.Text = "Справка";
            this.buttonHelp_SMA.UseVisualStyleBackColor = false;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            // 
            // dataGridViewResult_SMA
            // 
            this.dataGridViewResult_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SMA.Name = "dataGridViewResult_SMA";
            this.dataGridViewResult_SMA.RowHeadersVisible = false;
            this.dataGridViewResult_SMA.Size = new System.Drawing.Size(177, 347);
            this.dataGridViewResult_SMA.TabIndex = 0;
            // 
            // chartDiag_SMA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag_SMA.ChartAreas.Add(chartArea4);
            this.chartDiag_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartDiag_SMA.Legends.Add(legend4);
            this.chartDiag_SMA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SMA.Name = "chartDiag_SMA";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiag_SMA.Series.Add(series4);
            this.chartDiag_SMA.Size = new System.Drawing.Size(601, 366);
            this.chartDiag_SMA.TabIndex = 0;
            this.chartDiag_SMA.Text = "chart1";
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(486, 67);
            this.textBoxTask_SMA.TabIndex = 0;
            this.textBoxTask_SMA.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в dataGridVeiw значения " +
    "от 2 до 7 и посторить диограмму по этим значениям.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitterOutPutAndDiagPanels_SMA);
            this.Controls.Add(this.panelDiag_SMA);
            this.Controls.Add(this.panelOutPut_SMA);
            this.Controls.Add(this.panelInPut_SMA);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 15 | Сорокин М.А.";
            this.panelInPut_SMA.ResumeLayout(false);
            this.panelOutPut_SMA.ResumeLayout(false);
            this.panelDiag_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInPut_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.Button buttonOpenFile_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Panel panelOutPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMA;
        private System.Windows.Forms.Panel panelDiag_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SMA;
        private System.Windows.Forms.Splitter splitterOutPutAndDiagPanels_SMA;
    }
}

