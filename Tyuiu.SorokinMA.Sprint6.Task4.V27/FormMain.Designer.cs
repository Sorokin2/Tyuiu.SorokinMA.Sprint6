
namespace Tyuiu.SorokinMA.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInPut = new System.Windows.Forms.Panel();
            this.panelOutPut = new System.Windows.Forms.Panel();
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonSave_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.textBoxResult_SMA = new System.Windows.Forms.TextBox();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SMA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_SMA = new System.Windows.Forms.TextBox();
            this.textBoxStop_SMA = new System.Windows.Forms.TextBox();
            this.labelStart_SMA = new System.Windows.Forms.Label();
            this.labelStop_SMA = new System.Windows.Forms.Label();
            this.splitterOutPutAndFunctionPanels_SMA = new System.Windows.Forms.Splitter();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.chartFunction_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInPut.SuspendLayout();
            this.panelOutPut.SuspendLayout();
            this.groupBoxTask_SMA.SuspendLayout();
            this.groupBoxOutPut_SMA.SuspendLayout();
            this.groupBoxInPut_SMA.SuspendLayout();
            this.panelFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInPut
            // 
            this.panelInPut.Controls.Add(this.buttonHelp_SMA);
            this.panelInPut.Controls.Add(this.buttonSave_SMA);
            this.panelInPut.Controls.Add(this.buttonDone_SMA);
            this.panelInPut.Controls.Add(this.groupBoxInPut_SMA);
            this.panelInPut.Controls.Add(this.groupBoxTask_SMA);
            this.panelInPut.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInPut.Location = new System.Drawing.Point(0, 0);
            this.panelInPut.Name = "panelInPut";
            this.panelInPut.Size = new System.Drawing.Size(784, 94);
            this.panelInPut.TabIndex = 0;
            // 
            // panelOutPut
            // 
            this.panelOutPut.Controls.Add(this.groupBoxOutPut_SMA);
            this.panelOutPut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut.Location = new System.Drawing.Point(0, 94);
            this.panelOutPut.Name = "panelOutPut";
            this.panelOutPut.Size = new System.Drawing.Size(200, 367);
            this.panelOutPut.TabIndex = 0;
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(317, 85);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие";
            // 
            // groupBoxOutPut_SMA
            // 
            this.groupBoxOutPut_SMA.Controls.Add(this.textBoxResult_SMA);
            this.groupBoxOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(200, 367);
            this.groupBoxOutPut_SMA.TabIndex = 0;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SMA.Location = new System.Drawing.Point(544, 12);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(72, 68);
            this.buttonDone_SMA.TabIndex = 0;
            this.buttonDone_SMA.Text = "Выполнить";
            this.buttonDone_SMA.UseVisualStyleBackColor = false;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            // 
            // buttonSave_SMA
            // 
            this.buttonSave_SMA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SMA.Location = new System.Drawing.Point(622, 12);
            this.buttonSave_SMA.Name = "buttonSave_SMA";
            this.buttonSave_SMA.Size = new System.Drawing.Size(72, 68);
            this.buttonSave_SMA.TabIndex = 0;
            this.buttonSave_SMA.Text = "Сохранить";
            this.buttonSave_SMA.UseVisualStyleBackColor = false;
            this.buttonSave_SMA.Click += new System.EventHandler(this.buttonSave_SMA_Click);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SMA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_SMA.Location = new System.Drawing.Point(700, 12);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(72, 68);
            this.buttonHelp_SMA.TabIndex = 0;
            this.buttonHelp_SMA.Text = "Справка";
            this.buttonHelp_SMA.UseVisualStyleBackColor = false;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            // 
            // textBoxResult_SMA
            // 
            this.textBoxResult_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_SMA.Multiline = true;
            this.textBoxResult_SMA.Name = "textBoxResult_SMA";
            this.textBoxResult_SMA.ReadOnly = true;
            this.textBoxResult_SMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SMA.Size = new System.Drawing.Size(194, 348);
            this.textBoxResult_SMA.TabIndex = 0;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(311, 66);
            this.textBoxTask_SMA.TabIndex = 0;
            this.textBoxTask_SMA.Text = "Протабулировать функцию cos(x)/(x+1) -cos(x) * 1,3 + 3x на заданном диопазоне от " +
    "-5 до 5\r\nРезультат вывести в textBox, посторить график функции и сохранить в фай" +
    "л OutPutFileTask4.txt по нажатию кнопки";
            // 
            // groupBoxInPut_SMA
            // 
            this.groupBoxInPut_SMA.Controls.Add(this.labelStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.labelStart_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxStart_SMA);
            this.groupBoxInPut_SMA.Location = new System.Drawing.Point(326, 6);
            this.groupBoxInPut_SMA.Name = "groupBoxInPut_SMA";
            this.groupBoxInPut_SMA.Size = new System.Drawing.Size(203, 85);
            this.groupBoxInPut_SMA.TabIndex = 0;
            this.groupBoxInPut_SMA.TabStop = false;
            this.groupBoxInPut_SMA.Text = "Ввод данных";
            // 
            // textBoxStart_SMA
            // 
            this.textBoxStart_SMA.Location = new System.Drawing.Point(7, 42);
            this.textBoxStart_SMA.Name = "textBoxStart_SMA";
            this.textBoxStart_SMA.Size = new System.Drawing.Size(91, 20);
            this.textBoxStart_SMA.TabIndex = 0;
            // 
            // textBoxStop_SMA
            // 
            this.textBoxStop_SMA.Location = new System.Drawing.Point(104, 42);
            this.textBoxStop_SMA.Name = "textBoxStop_SMA";
            this.textBoxStop_SMA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStop_SMA.TabIndex = 0;
            // 
            // labelStart_SMA
            // 
            this.labelStart_SMA.AutoSize = true;
            this.labelStart_SMA.Location = new System.Drawing.Point(6, 26);
            this.labelStart_SMA.Name = "labelStart_SMA";
            this.labelStart_SMA.Size = new System.Drawing.Size(64, 13);
            this.labelStart_SMA.TabIndex = 1;
            this.labelStart_SMA.Text = "Старт шага";
            // 
            // labelStop_SMA
            // 
            this.labelStop_SMA.AutoSize = true;
            this.labelStop_SMA.Location = new System.Drawing.Point(101, 26);
            this.labelStop_SMA.Name = "labelStop_SMA";
            this.labelStop_SMA.Size = new System.Drawing.Size(66, 13);
            this.labelStop_SMA.TabIndex = 1;
            this.labelStop_SMA.Text = "Конец шага";
            // 
            // splitterOutPutAndFunctionPanels_SMA
            // 
            this.splitterOutPutAndFunctionPanels_SMA.Location = new System.Drawing.Point(200, 94);
            this.splitterOutPutAndFunctionPanels_SMA.Name = "splitterOutPutAndFunctionPanels_SMA";
            this.splitterOutPutAndFunctionPanels_SMA.Size = new System.Drawing.Size(3, 367);
            this.splitterOutPutAndFunctionPanels_SMA.TabIndex = 1;
            this.splitterOutPutAndFunctionPanels_SMA.TabStop = false;
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.chartFunction_SMA);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction.Location = new System.Drawing.Point(203, 94);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(581, 367);
            this.panelFunction.TabIndex = 2;
            // 
            // chartFunction_SMA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SMA.ChartAreas.Add(chartArea2);
            this.chartFunction_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_SMA.Legends.Add(legend2);
            this.chartFunction_SMA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_SMA.Name = "chartFunction_SMA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SMA.Series.Add(series2);
            this.chartFunction_SMA.Size = new System.Drawing.Size(581, 367);
            this.chartFunction_SMA.TabIndex = 0;
            this.chartFunction_SMA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.splitterOutPutAndFunctionPanels_SMA);
            this.Controls.Add(this.panelOutPut);
            this.Controls.Add(this.panelInPut);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Сорокин М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelInPut.ResumeLayout(false);
            this.panelOutPut.ResumeLayout(false);
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.PerformLayout();
            this.groupBoxInPut_SMA.ResumeLayout(false);
            this.groupBoxInPut_SMA.PerformLayout();
            this.panelFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInPut;
        private System.Windows.Forms.Panel panelOutPut;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.Button buttonSave_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.TextBox textBoxResult_SMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SMA;
        private System.Windows.Forms.Label labelStop_SMA;
        private System.Windows.Forms.Label labelStart_SMA;
        private System.Windows.Forms.TextBox textBoxStop_SMA;
        private System.Windows.Forms.TextBox textBoxStart_SMA;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Splitter splitterOutPutAndFunctionPanels_SMA;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SMA;
    }
}

