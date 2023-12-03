
namespace Tyuiu.SorokinMA.Sprint6.Task0.V1
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
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelVarX = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelVarX);
            this.groupBoxInPut.Controls.Add(this.textBoxVarX);
            this.groupBoxInPut.Location = new System.Drawing.Point(21, 215);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(209, 82);
            this.groupBoxInPut.TabIndex = 0;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных:";
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.labelResult);
            this.groupBoxOutPut.Controls.Add(this.textBoxResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(252, 215);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(205, 82);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных:";
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.Location = new System.Drawing.Point(360, 303);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(97, 38);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(30, 39);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX.TabIndex = 0;
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(36, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(112, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(302, 303);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 38);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Location = new System.Drawing.Point(21, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(436, 188);
            this.groupBoxTask.TabIndex = 1;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие:";
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.Location = new System.Drawing.Point(27, 23);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(81, 13);
            this.labelVarX.TabIndex = 1;
            this.labelVarX.Text = "Переменная X";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(33, 23);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(245, 119);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Вычислить значение выражения.\r\nОкруглить до трёх знаков после запятой.\r\nВводить м" +
    "ожно только целые.";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(300, 31);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(115, 54);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxInPut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 1 | Сорокин М.А.";
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBox1;
    }
}

