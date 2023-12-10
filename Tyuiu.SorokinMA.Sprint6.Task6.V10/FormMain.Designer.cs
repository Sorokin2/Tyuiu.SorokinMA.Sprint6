
namespace Tyuiu.SorokinMA.Sprint6.Task6.V10
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
            this.buttonOpenFile_SMA = new System.Windows.Forms.Button();
            this.buttonDone_SMA = new System.Windows.Forms.Button();
            this.buttonHelp_SMA = new System.Windows.Forms.Button();
            this.groupBoxTask_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SMA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_SMA = new System.Windows.Forms.TextBox();
            this.textBoxResult_SMA = new System.Windows.Forms.TextBox();
            this.textBoxTask_SMA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SMA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_SMA.SuspendLayout();
            this.panelTask_SMA.SuspendLayout();
            this.panelInPut_SMA.SuspendLayout();
            this.panelOutPut_SMA.SuspendLayout();
            this.groupBoxTask_SMA.SuspendLayout();
            this.groupBoxInPut_SMA.SuspendLayout();
            this.groupBoxOutPut_SMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_SMA
            // 
            this.panelButtons_SMA.Controls.Add(this.buttonHelp_SMA);
            this.panelButtons_SMA.Controls.Add(this.buttonDone_SMA);
            this.panelButtons_SMA.Controls.Add(this.buttonOpenFile_SMA);
            this.panelButtons_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SMA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SMA.Name = "panelButtons_SMA";
            this.panelButtons_SMA.Size = new System.Drawing.Size(784, 82);
            this.panelButtons_SMA.TabIndex = 0;
            // 
            // panelTask_SMA
            // 
            this.panelTask_SMA.Controls.Add(this.groupBoxTask_SMA);
            this.panelTask_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SMA.Location = new System.Drawing.Point(0, 82);
            this.panelTask_SMA.Name = "panelTask_SMA";
            this.panelTask_SMA.Size = new System.Drawing.Size(784, 83);
            this.panelTask_SMA.TabIndex = 0;
            // 
            // panelInPut_SMA
            // 
            this.panelInPut_SMA.Controls.Add(this.groupBoxInPut_SMA);
            this.panelInPut_SMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_SMA.Location = new System.Drawing.Point(0, 165);
            this.panelInPut_SMA.Name = "panelInPut_SMA";
            this.panelInPut_SMA.Size = new System.Drawing.Size(474, 296);
            this.panelInPut_SMA.TabIndex = 0;
            // 
            // panelOutPut_SMA
            // 
            this.panelOutPut_SMA.Controls.Add(this.groupBoxOutPut_SMA);
            this.panelOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_SMA.Location = new System.Drawing.Point(474, 165);
            this.panelOutPut_SMA.Name = "panelOutPut_SMA";
            this.panelOutPut_SMA.Size = new System.Drawing.Size(310, 296);
            this.panelOutPut_SMA.TabIndex = 0;
            // 
            // splitterInPutAndOutPutPanels_SMA
            // 
            this.splitterInPutAndOutPutPanels_SMA.Location = new System.Drawing.Point(474, 165);
            this.splitterInPutAndOutPutPanels_SMA.Name = "splitterInPutAndOutPutPanels_SMA";
            this.splitterInPutAndOutPutPanels_SMA.Size = new System.Drawing.Size(3, 296);
            this.splitterInPutAndOutPutPanels_SMA.TabIndex = 1;
            this.splitterInPutAndOutPutPanels_SMA.TabStop = false;
            // 
            // buttonOpenFile_SMA
            // 
            this.buttonOpenFile_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SMA.Image")));
            this.buttonOpenFile_SMA.Location = new System.Drawing.Point(7, 5);
            this.buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            this.buttonOpenFile_SMA.Size = new System.Drawing.Size(86, 67);
            this.buttonOpenFile_SMA.TabIndex = 0;
            this.toolTip_SMA.SetToolTip(this.buttonOpenFile_SMA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SMA.Click += new System.EventHandler(this.buttonOpenFile_SMA_Click);
            // 
            // buttonDone_SMA
            // 
            this.buttonDone_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SMA.Image")));
            this.buttonDone_SMA.Location = new System.Drawing.Point(99, 5);
            this.buttonDone_SMA.Name = "buttonDone_SMA";
            this.buttonDone_SMA.Size = new System.Drawing.Size(86, 67);
            this.buttonDone_SMA.TabIndex = 0;
            this.toolTip_SMA.SetToolTip(this.buttonDone_SMA, "Производит поиск слов с \"w\" и выводит их");
            this.buttonDone_SMA.UseVisualStyleBackColor = true;
            this.buttonDone_SMA.Click += new System.EventHandler(this.buttonDone_SMA_Click);
            // 
            // buttonHelp_SMA
            // 
            this.buttonHelp_SMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SMA.Image")));
            this.buttonHelp_SMA.Location = new System.Drawing.Point(686, 5);
            this.buttonHelp_SMA.Name = "buttonHelp_SMA";
            this.buttonHelp_SMA.Size = new System.Drawing.Size(86, 67);
            this.buttonHelp_SMA.TabIndex = 0;
            this.toolTip_SMA.SetToolTip(this.buttonHelp_SMA, "Сведение о программе");
            this.buttonHelp_SMA.UseVisualStyleBackColor = true;
            this.buttonHelp_SMA.Click += new System.EventHandler(this.buttonHelp_SMA_Click);
            // 
            // groupBoxTask_SMA
            // 
            this.groupBoxTask_SMA.Controls.Add(this.textBoxTask_SMA);
            this.groupBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            this.groupBoxTask_SMA.Size = new System.Drawing.Size(784, 83);
            this.groupBoxTask_SMA.TabIndex = 0;
            this.groupBoxTask_SMA.TabStop = false;
            this.groupBoxTask_SMA.Text = "Условие";
            // 
            // groupBoxInPut_SMA
            // 
            this.groupBoxInPut_SMA.Controls.Add(this.textBoxInPut_SMA);
            this.groupBoxInPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_SMA.Name = "groupBoxInPut_SMA";
            this.groupBoxInPut_SMA.Size = new System.Drawing.Size(474, 296);
            this.groupBoxInPut_SMA.TabIndex = 0;
            this.groupBoxInPut_SMA.TabStop = false;
            this.groupBoxInPut_SMA.Text = "Ввод:";
            // 
            // groupBoxOutPut_SMA
            // 
            this.groupBoxOutPut_SMA.Controls.Add(this.textBoxResult_SMA);
            this.groupBoxOutPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            this.groupBoxOutPut_SMA.Size = new System.Drawing.Size(310, 296);
            this.groupBoxOutPut_SMA.TabIndex = 0;
            this.groupBoxOutPut_SMA.TabStop = false;
            this.groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // textBoxInPut_SMA
            // 
            this.textBoxInPut_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInPut_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPut_SMA.Multiline = true;
            this.textBoxInPut_SMA.Name = "textBoxInPut_SMA";
            this.textBoxInPut_SMA.ReadOnly = true;
            this.textBoxInPut_SMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_SMA.Size = new System.Drawing.Size(468, 277);
            this.textBoxInPut_SMA.TabIndex = 0;
            this.textBoxInPut_SMA.TabStop = false;
            // 
            // textBoxResult_SMA
            // 
            this.textBoxResult_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_SMA.Multiline = true;
            this.textBoxResult_SMA.Name = "textBoxResult_SMA";
            this.textBoxResult_SMA.ReadOnly = true;
            this.textBoxResult_SMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SMA.Size = new System.Drawing.Size(304, 277);
            this.textBoxResult_SMA.TabIndex = 0;
            this.textBoxResult_SMA.TabStop = false;
            // 
            // textBoxTask_SMA
            // 
            this.textBoxTask_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SMA.Multiline = true;
            this.textBoxTask_SMA.Name = "textBoxTask_SMA";
            this.textBoxTask_SMA.ReadOnly = true;
            this.textBoxTask_SMA.Size = new System.Drawing.Size(778, 64);
            this.textBoxTask_SMA.TabIndex = 0;
            this.textBoxTask_SMA.TabStop = false;
            this.textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // openFileDialogTask_SMA
            // 
            this.openFileDialogTask_SMA.FileName = "openFileDialog1";
            // 
            // toolTip_SMA
            // 
            this.toolTip_SMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SMA.ToolTipTitle = "Подсказка";
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
            this.Text = "Спринт 6 | Таск 6 | Вариант 10 | Сорокин М.А.";
            this.panelButtons_SMA.ResumeLayout(false);
            this.panelTask_SMA.ResumeLayout(false);
            this.panelInPut_SMA.ResumeLayout(false);
            this.panelOutPut_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.ResumeLayout(false);
            this.groupBoxTask_SMA.PerformLayout();
            this.groupBoxInPut_SMA.ResumeLayout(false);
            this.groupBoxInPut_SMA.PerformLayout();
            this.groupBoxOutPut_SMA.ResumeLayout(false);
            this.groupBoxOutPut_SMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SMA;
        private System.Windows.Forms.Panel panelTask_SMA;
        private System.Windows.Forms.Panel panelInPut_SMA;
        private System.Windows.Forms.Panel panelOutPut_SMA;
        private System.Windows.Forms.Splitter splitterInPutAndOutPutPanels_SMA;
        private System.Windows.Forms.Button buttonHelp_SMA;
        private System.Windows.Forms.Button buttonDone_SMA;
        private System.Windows.Forms.Button buttonOpenFile_SMA;
        private System.Windows.Forms.GroupBox groupBoxTask_SMA;
        private System.Windows.Forms.TextBox textBoxTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SMA;
        private System.Windows.Forms.TextBox textBoxInPut_SMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SMA;
        private System.Windows.Forms.TextBox textBoxResult_SMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMA;
        private System.Windows.Forms.ToolTip toolTip_SMA;
    }
}

