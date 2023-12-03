
namespace Tyuiu.SorokinMA.Sprint6.Task2.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SMA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_SMA = new System.Windows.Forms.Label();
            this.groupBoxInPut_SMA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_SMA = new System.Windows.Forms.Label();
            this.labelVarStart_SMA = new System.Windows.Forms.Label();
            this.textBoxVarStop_SMA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_SMA = new System.Windows.Forms.TextBox();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.chartFunction_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOutPut_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).BeginInit();
            this.groupBoxInPut_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.pictureBox1);
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(12, 13);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(512, 315);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SMA.Location = new System.Drawing.Point(18, 42);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(472, 132);
            this.textBoxTask_SMA.TabIndex = 2;
            this.textBoxTask_SMA.TabStop = false;
            this.textBoxTask_SMA.Text = "Вывести таблицу значений функци на заданном диапазоне [-5, 5]\r\nЗначения округлить" +
    " до двух знаков после запятой";
            // 
            // groupBoxOutPut_SMA
            // 
            this.groupBoxOutPut_SMA.Controls.Add(this.dataGridViewResult_SMA);
            this.groupBoxOutPut_SMA.Controls.Add(this.labelResult_SMA);
            this.groupBoxOutPut_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(545, 13);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(243, 425);
            this.groupBoxOutPut_SMA.TabIndex = 1;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SMA
            // 
            this.dataGridViewResult_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_SMA.Location = new System.Drawing.Point(18, 42);
            this.dataGridViewResult_SMA.Name = "dataGridViewResult_SMA";
            this.dataGridViewResult_SMA.RowHeadersVisible = false;
            this.dataGridViewResult_SMA.Size = new System.Drawing.Size(159, 361);
            this.dataGridViewResult_SMA.TabIndex = 2;
            this.dataGridViewResult_SMA.TabStop = false;
            this.dataGridViewResult_SMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_SMA_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // labelResult_SMA
            // 
            this.labelResult_SMA.AutoSize = true;
            this.labelResult_SMA.Location = new System.Drawing.Point(25, 23);
            this.labelResult_SMA.Name = "labelResult_SMA";
            this.labelResult_SMA.Size = new System.Drawing.Size(78, 16);
            this.labelResult_SMA.TabIndex = 1;
            this.labelResult_SMA.Text = "Результат";
            // 
            // groupBoxInPut_SMA
            // 
            this.groupBoxInPut_SMA.Controls.Add(this.labelVarStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.labelVarStart_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxVarStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxVarStart_SMA);
            this.groupBoxInPut_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_SMA.Location = new System.Drawing.Point(12, 348);
            this.groupBoxInPut_SMA.Name = "groupBoxInPut_SMA";
            this.groupBoxInPut_SMA.Size = new System.Drawing.Size(305, 90);
            this.groupBoxInPut_SMA.TabIndex = 2;
            this.groupBoxInPut_SMA.TabStop = false;
            this.groupBoxInPut_SMA.Text = "Ввод данных:";
            // 
            // labelVarStop_SMA
            // 
            this.labelVarStop_SMA.AutoSize = true;
            this.labelVarStop_SMA.Location = new System.Drawing.Point(161, 26);
            this.labelVarStop_SMA.Name = "labelVarStop_SMA";
            this.labelVarStop_SMA.Size = new System.Drawing.Size(123, 16);
            this.labelVarStop_SMA.TabIndex = 3;
            this.labelVarStop_SMA.Text = "Конец диопазона";
            // 
            // labelVarStart_SMA
            // 
            this.labelVarStart_SMA.AutoSize = true;
            this.labelVarStart_SMA.Location = new System.Drawing.Point(15, 26);
            this.labelVarStart_SMA.Name = "labelVarStart_SMA";
            this.labelVarStart_SMA.Size = new System.Drawing.Size(133, 16);
            this.labelVarStart_SMA.TabIndex = 2;
            this.labelVarStart_SMA.Text = "Начало диопазона";
            // 
            // textBoxVarStop_SMA
            // 
            this.textBoxVarStop_SMA.Location = new System.Drawing.Point(164, 45);
            this.textBoxVarStop_SMA.Name = "textBoxVarStop_SMA";
            this.textBoxVarStop_SMA.Size = new System.Drawing.Size(112, 22);
            this.textBoxVarStop_SMA.TabIndex = 1;
            this.textBoxVarStop_SMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_SMA_KeyPress);
            // 
            // textBoxVarStart_SMA
            // 
            this.textBoxVarStart_SMA.Location = new System.Drawing.Point(18, 45);
            this.textBoxVarStart_SMA.Name = "textBoxVarStart_SMA";
            this.textBoxVarStart_SMA.Size = new System.Drawing.Size(107, 22);
            this.textBoxVarStart_SMA.TabIndex = 0;
            this.textBoxVarStart_SMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_SMA_KeyPress);
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SMA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_SMA.Location = new System.Drawing.Point(411, 348);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(113, 89);
            this.buttonDone_SMA.TabIndex = 3;
            this.buttonDone_SMA.Text = "Выполнить";
            this.buttonDone_SMA.UseVisualStyleBackColor = false;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            this.buttonDone_SMA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SMA_MouseDown);
            this.buttonDone_SMA.MouseEnter += new System.EventHandler(this.buttonDone_SMA_MouseEnter);
            this.buttonDone_SMA.MouseLeave += new System.EventHandler(this.buttonDone_SMA_MouseLeave);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SMA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_SMA.Location = new System.Drawing.Point(323, 348);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(82, 90);
            this.buttonHelp_SMA.TabIndex = 4;
            this.buttonHelp_SMA.Text = "Справка";
            this.buttonHelp_SMA.UseVisualStyleBackColor = false;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            // 
            // chartFunction_SMA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SMA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_SMA.Legends.Add(legend1);
            this.chartFunction_SMA.Location = new System.Drawing.Point(794, 55);
            this.chartFunction_SMA.Name = "chartFunction_SMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SMA.Series.Add(series1);
            this.chartFunction_SMA.Size = new System.Drawing.Size(370, 360);
            this.chartFunction_SMA.TabIndex = 5;
            this.chartFunction_SMA.TabStop = false;
            this.chartFunction_SMA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 447);
            this.Controls.Add(this.chartFunction_SMA);
            this.Controls.Add(this.buttonHelp_SMA);
            this.Controls.Add(this.buttonDone_SMA);
            this.Controls.Add(this.groupBoxInPut_SMA);
            this.Controls.Add(this.groupBoxOutPut_SMA);
            this.Controls.Add(this.groupBoxTask_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 18 | Сорокин М.А.";
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).EndInit();
            this.groupBoxInPut_SMA.ResumeLayout(false);
            this.groupBoxInPut_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SMA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Label labelResult_SMA;
        private System.Windows.Forms.Label labelVarStop_SMA;
        private System.Windows.Forms.Label labelVarStart_SMA;
        private System.Windows.Forms.TextBox textBoxVarStop_SMA;
        private System.Windows.Forms.TextBox textBoxVarStart_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

