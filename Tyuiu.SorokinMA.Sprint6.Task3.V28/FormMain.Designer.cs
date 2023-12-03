
namespace Tyuiu.SorokinMA.Sprint6.Task3.V28
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
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.dataGridViewResult_SMA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(18, 12);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(212, 199);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие:";
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_SMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SMA.Location = new System.Drawing.Point(91, 218);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(139, 54);
            this.buttonDone_SMA.TabIndex = 2;
            this.buttonDone_SMA.Text = "Выполнить";
            this.buttonDone_SMA.UseVisualStyleBackColor = false;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_SMA.Location = new System.Drawing.Point(18, 218);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(67, 54);
            this.buttonHelp_SMA.TabIndex = 3;
            this.buttonHelp_SMA.Text = "Справка";
            this.buttonHelp_SMA.UseVisualStyleBackColor = false;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            // 
            // dataGridViewResult_SMA
            // 
            this.dataGridViewResult_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SMA.Location = new System.Drawing.Point(260, 43);
            this.dataGridViewResult_SMA.Name = "dataGridViewResult_SMA";
            this.dataGridViewResult_SMA.RowHeadersVisible = false;
            this.dataGridViewResult_SMA.Size = new System.Drawing.Size(224, 207);
            this.dataGridViewResult_SMA.TabIndex = 4;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(200, 162);
            this.textBoxTask_SMA.TabIndex = 0;
            this.textBoxTask_SMA.TabStop = false;
            this.textBoxTask_SMA.Text = "Дан массив 5 на 5 элементов.\r\n  -9   8   9  16 -18\r\n\r\n -13 -11 -20 -15   9\r\n\r\n  1" +
    "8  13 -12 -15 -11\r\n\r\n  10  -2  19  -4 -10\r\n\r\n   6 -20  -4  13 -14\r\nЗаменить четн" +
    "ые значения в четвертой строке на 0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 289);
            this.Controls.Add(this.dataGridViewResult_SMA);
            this.Controls.Add(this.buttonHelp_SMA);
            this.Controls.Add(this.buttonDone_SMA);
            this.Controls.Add(this.groupBoxTask_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 | Сорокин М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMA;
    }
}

