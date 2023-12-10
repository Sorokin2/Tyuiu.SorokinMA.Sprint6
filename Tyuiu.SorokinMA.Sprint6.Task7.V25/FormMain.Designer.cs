
namespace Tyuiu.SorokinMA.Sprint6.Task7.V25
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_SMA = new System.Windows.Forms.Panel();
            this.panelTask_SMA = new System.Windows.Forms.Panel();
            this.panelInPut_SMA = new System.Windows.Forms.Panel();
            this.panelOutPut_SMA = new System.Windows.Forms.Panel();
            this.splitterInPutAndOutPutPanels_SMA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile_SMA = new System.Windows.Forms.Button();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonSave_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.dataGridViewLoadFromFile_SMA = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_SMA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SMA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_SMA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButtons_SMA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_SMA.SuspendLayout();
            this.panelTask_SMA.SuspendLayout();
            this.panelInPut_SMA.SuspendLayout();
            this.panelOutPut_SMA.SuspendLayout();
            this.groupBoxTask_SMA.SuspendLayout();
            this.groupBoxInPut_SMA.SuspendLayout();
            this.groupBoxOutPut_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadFromFile_SMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_SMA
            // 
            this.panelButtons_SMA.Controls.Add(this.buttonHelp_SMA);
            this.panelButtons_SMA.Controls.Add(this.buttonSave_SMA);
            this.panelButtons_SMA.Controls.Add(this.buttonDone_SMA);
            this.panelButtons_SMA.Controls.Add(this.buttonOpenFile_SMA);
            this.panelButtons_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SMA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SMA.Name = "panelButtons_SMA";
            this.panelButtons_SMA.Size = new System.Drawing.Size(784, 87);
            this.panelButtons_SMA.TabIndex = 0;
            // 
            // panelTask_SMA
            // 
            this.panelTask_SMA.Controls.Add(this.groupBoxTask_SMA);
            this.panelTask_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SMA.Location = new System.Drawing.Point(0, 87);
            this.panelTask_SMA.Name = "panelTask_SMA";
            this.panelTask_SMA.Size = new System.Drawing.Size(784, 84);
            this.panelTask_SMA.TabIndex = 0;
            // 
            // panelInPut_SMA
            // 
            this.panelInPut_SMA.Controls.Add(this.groupBoxInPut_SMA);
            this.panelInPut_SMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_SMA.Location = new System.Drawing.Point(0, 171);
            this.panelInPut_SMA.Name = "panelInPut_SMA";
            this.panelInPut_SMA.Size = new System.Drawing.Size(388, 290);
            this.panelInPut_SMA.TabIndex = 0;
            // 
            // panelOutPut_SMA
            // 
            this.panelOutPut_SMA.Controls.Add(this.groupBoxOutPut_SMA);
            this.panelOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_SMA.Location = new System.Drawing.Point(388, 171);
            this.panelOutPut_SMA.Name = "panelOutPut_SMA";
            this.panelOutPut_SMA.Size = new System.Drawing.Size(396, 290);
            this.panelOutPut_SMA.TabIndex = 0;
            // 
            // splitterInPutAndOutPutPanels_SMA
            // 
            this.splitterInPutAndOutPutPanels_SMA.Location = new System.Drawing.Point(388, 171);
            this.splitterInPutAndOutPutPanels_SMA.Name = "splitterInPutAndOutPutPanels_SMA";
            this.splitterInPutAndOutPutPanels_SMA.Size = new System.Drawing.Size(3, 290);
            this.splitterInPutAndOutPutPanels_SMA.TabIndex = 1;
            this.splitterInPutAndOutPutPanels_SMA.TabStop = false;
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(784, 84);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие:";
            // 
            // groupBoxInPut_SMA
            // 
            this.groupBoxInPut_SMA.Controls.Add(this.dataGridViewLoadFromFile_SMA);
            this.groupBoxInPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_SMA.Name = "groupBoxInPut_SMA";
            this.groupBoxInPut_SMA.Size = new System.Drawing.Size(388, 290);
            this.groupBoxInPut_SMA.TabIndex = 0;
            this.groupBoxInPut_SMA.TabStop = false;
            this.groupBoxInPut_SMA.Text = "Ввод:";
            // 
            // groupBoxOutPut_SMA
            // 
            this.groupBoxOutPut_SMA.Controls.Add(this.dataGridViewResult_SMA);
            this.groupBoxOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(396, 290);
            this.groupBoxOutPut_SMA.TabIndex = 0;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // buttonOpenFile_SMA
            // 
            this.buttonOpenFile_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SMA.Image")));
            this.buttonOpenFile_SMA.Location = new System.Drawing.Point(12, 4);
            this.buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            this.buttonOpenFile_SMA.Size = new System.Drawing.Size(93, 77);
            this.buttonOpenFile_SMA.TabIndex = 0;
            this.toolTipButtons_SMA.SetToolTip(this.buttonOpenFile_SMA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SMA.Click += new System.EventHandler(this.buttonOpenFile_SMA_Click);
            this.buttonOpenFile_SMA.MouseEnter += new System.EventHandler(this.buttonOpenFile_SMA_MouseEnter);
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.Enabled = false;
            this.buttonDone_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SMA.Image")));
            this.buttonDone_SMA.Location = new System.Drawing.Point(111, 4);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(93, 77);
            this.buttonDone_SMA.TabIndex = 0;
            this.toolTipButtons_SMA.SetToolTip(this.buttonDone_SMA, "Выполнить обработку данных");
            this.buttonDone_SMA.UseVisualStyleBackColor = true;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            this.buttonDone_SMA.MouseEnter += new System.EventHandler(this.buttonDone_SMA_MouseEnter);
            // 
            // buttonSave_SMA
            // 
            this.buttonSave_SMA.Enabled = false;
            this.buttonSave_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SMA.Image")));
            this.buttonSave_SMA.Location = new System.Drawing.Point(210, 4);
            this.buttonSave_SMA.Name = "buttonSave_SMA";
            this.buttonSave_SMA.Size = new System.Drawing.Size(93, 77);
            this.buttonSave_SMA.TabIndex = 0;
            this.toolTipButtons_SMA.SetToolTip(this.buttonSave_SMA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_SMA.UseVisualStyleBackColor = true;
            this.buttonSave_SMA.Click += new System.EventHandler(this.buttonSave_SMA_Click);
            this.buttonSave_SMA.MouseEnter += new System.EventHandler(this.buttonSave_SMA_MouseEnter);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SMA.Image")));
            this.buttonHelp_SMA.Location = new System.Drawing.Point(679, 4);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(93, 77);
            this.buttonHelp_SMA.TabIndex = 0;
            this.toolTipButtons_SMA.SetToolTip(this.buttonHelp_SMA, "Сведение о программе");
            this.buttonHelp_SMA.UseVisualStyleBackColor = true;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            this.buttonHelp_SMA.MouseEnter += new System.EventHandler(this.buttonHelp_SMA_MouseEnter);
            // 
            // dataGridViewLoadFromFile_SMA
            // 
            this.dataGridViewLoadFromFile_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadFromFile_SMA.ColumnHeadersVisible = false;
            this.dataGridViewLoadFromFile_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoadFromFile_SMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLoadFromFile_SMA.Name = "dataGridViewLoadFromFile_SMA";
            this.dataGridViewLoadFromFile_SMA.ReadOnly = true;
            this.dataGridViewLoadFromFile_SMA.RowHeadersVisible = false;
            this.dataGridViewLoadFromFile_SMA.Size = new System.Drawing.Size(382, 271);
            this.dataGridViewLoadFromFile_SMA.TabIndex = 0;
            // 
            // dataGridViewResult_SMA
            // 
            this.dataGridViewResult_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SMA.Name = "dataGridViewResult_SMA";
            this.dataGridViewResult_SMA.ReadOnly = true;
            this.dataGridViewResult_SMA.RowHeadersVisible = false;
            this.dataGridViewResult_SMA.Size = new System.Drawing.Size(390, 271);
            this.dataGridViewResult_SMA.TabIndex = 0;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(778, 65);
            this.textBoxTask_SMA.TabIndex = 0;
            this.textBoxTask_SMA.TabStop = false;
            this.textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // openFileDialogTask_SMA
            // 
            this.openFileDialogTask_SMA.FileName = "openFileDialog1";
            // 
            // toolTipButtons_SMA
            // 
            this.toolTipButtons_SMA.IsBalloon = true;
            this.toolTipButtons_SMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_SMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitterInPutAndOutPutPanels_SMA);
            this.Controls.Add(this.panelOutPut_SMA);
            this.Controls.Add(this.panelInPut_SMA);
            this.Controls.Add(this.panelTask_SMA);
            this.Controls.Add(this.panelButtons_SMA);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 25 | Сорокин М.А.";
            this.panelButtons_SMA.ResumeLayout(false);
            this.panelTask_SMA.ResumeLayout(false);
            this.panelInPut_SMA.ResumeLayout(false);
            this.panelOutPut_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            this.groupBoxInPut_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadFromFile_SMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.Button buttonSave_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.Button buttonOpenFile_SMA;
        private System.Windows.Forms.Panel panelTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.Panel panelInPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SMA;
        private System.Windows.Forms.DataGridView dataGridViewLoadFromFile_SMA;
        private System.Windows.Forms.Panel panelOutPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMA;
        private System.Windows.Forms.Splitter splitterInPutAndOutPutPanels_SMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SMA;
        private System.Windows.Forms.ToolTip toolTipButtons_SMA;
    }
}

