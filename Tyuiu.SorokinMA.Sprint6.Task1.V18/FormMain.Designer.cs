
namespace Tyuiu.SorokinMA.Sprint6.Task1.V18
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
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.labelResult_SMA = new System.Windows.Forms.Label();
            this.textBoxResult_SMA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SMA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_SMA = new System.Windows.Forms.Label();
            this.labelVarStart_SMA = new System.Windows.Forms.Label();
            this.textBoxVarStop_SMA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_SMA = new System.Windows.Forms.TextBox();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOutPut_SMA.SuspendLayout();
            this.groupBoxInPut_SMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.pictureBox1);
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
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
            this.pictureBox1.Size = new System.Drawing.Size(307, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.groupBoxOutPut_SMA.Controls.Add(this.labelResult_SMA);
            this.groupBoxOutPut_SMA.Controls.Add(this.textBoxResult_SMA);
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(545, 13);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(243, 425);
            this.groupBoxOutPut_SMA.TabIndex = 1;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод данных:";
            // 
            // labelResult_SMA
            // 
            this.labelResult_SMA.AutoSize = true;
            this.labelResult_SMA.Location = new System.Drawing.Point(25, 23);
            this.labelResult_SMA.Name = "labelResult_SMA";
            this.labelResult_SMA.Size = new System.Drawing.Size(59, 13);
            this.labelResult_SMA.TabIndex = 1;
            this.labelResult_SMA.Text = "Результат";
            // 
            // textBoxResult_SMA
            // 
            this.textBoxResult_SMA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SMA.Location = new System.Drawing.Point(19, 42);
            this.textBoxResult_SMA.Multiline = true;
            this.textBoxResult_SMA.Name = "textBoxResult_SMA";
            this.textBoxResult_SMA.ReadOnly = true;
            this.textBoxResult_SMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SMA.Size = new System.Drawing.Size(208, 354);
            this.textBoxResult_SMA.TabIndex = 0;
            // 
            // groupBoxInPut_SMA
            // 
            this.groupBoxInPut_SMA.Controls.Add(this.labelVarStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.labelVarStart_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxVarStop_SMA);
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxVarStart_SMA);
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
            this.labelVarStop_SMA.Location = new System.Drawing.Point(166, 30);
            this.labelVarStop_SMA.Name = "labelVarStop_SMA";
            this.labelVarStop_SMA.Size = new System.Drawing.Size(95, 13);
            this.labelVarStop_SMA.TabIndex = 3;
            this.labelVarStop_SMA.Text = "Конец диопазона";
            // 
            // labelVarStart_SMA
            // 
            this.labelVarStart_SMA.AutoSize = true;
            this.labelVarStart_SMA.Location = new System.Drawing.Point(18, 30);
            this.labelVarStart_SMA.Name = "labelVarStart_SMA";
            this.labelVarStart_SMA.Size = new System.Drawing.Size(101, 13);
            this.labelVarStart_SMA.TabIndex = 2;
            this.labelVarStart_SMA.Text = "Начало диопазона";
            // 
            // textBoxVarStop_SMA
            // 
            this.textBoxVarStop_SMA.Location = new System.Drawing.Point(164, 45);
            this.textBoxVarStop_SMA.Name = "textBoxVarStop_SMA";
            this.textBoxVarStop_SMA.Size = new System.Drawing.Size(112, 20);
            this.textBoxVarStop_SMA.TabIndex = 1;
            this.textBoxVarStop_SMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_SMA_KeyPress);
            // 
            // textBoxVarStart_SMA
            // 
            this.textBoxVarStart_SMA.Location = new System.Drawing.Point(18, 45);
            this.textBoxVarStart_SMA.Name = "textBoxVarStart_SMA";
            this.textBoxVarStart_SMA.Size = new System.Drawing.Size(107, 20);
            this.textBoxVarStart_SMA.TabIndex = 0;
            this.textBoxVarStart_SMA.TextChanged += new System.EventHandler(this.textBoxVarStart_SMA_TextChanged);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_SMA);
            this.Controls.Add(this.buttonDone_SMA);
            this.Controls.Add(this.groupBoxInPut_SMA);
            this.Controls.Add(this.groupBoxOutPut_SMA);
            this.Controls.Add(this.groupBoxTask_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 18 | Сорокин М.А.";
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.PerformLayout();
            this.groupBoxInPut_SMA.ResumeLayout(false);
            this.groupBoxInPut_SMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SMA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Label labelResult_SMA;
        private System.Windows.Forms.TextBox textBoxResult_SMA;
        private System.Windows.Forms.Label labelVarStop_SMA;
        private System.Windows.Forms.Label labelVarStart_SMA;
        private System.Windows.Forms.TextBox textBoxVarStop_SMA;
        private System.Windows.Forms.TextBox textBoxVarStart_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
    }
}

