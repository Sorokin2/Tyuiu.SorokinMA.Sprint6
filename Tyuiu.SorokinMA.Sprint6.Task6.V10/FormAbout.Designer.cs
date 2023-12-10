
namespace Tyuiu.SorokinMA.Sprint6.Task6.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxPictureOfMe_SMA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_SMA = new System.Windows.Forms.TextBox();
            this.buttonOk_SMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureOfMe_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPictureOfMe_SMA
            // 
            this.pictureBoxPictureOfMe_SMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPictureOfMe_SMA.Image")));
            this.pictureBoxPictureOfMe_SMA.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxPictureOfMe_SMA.Name = "pictureBoxPictureOfMe_SMA";
            this.pictureBoxPictureOfMe_SMA.Size = new System.Drawing.Size(168, 208);
            this.pictureBoxPictureOfMe_SMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPictureOfMe_SMA.TabIndex = 0;
            this.pictureBoxPictureOfMe_SMA.TabStop = false;
            // 
            // textBoxInfo_SMA
            // 
            this.textBoxInfo_SMA.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_SMA.Location = new System.Drawing.Point(186, 3);
            this.textBoxInfo_SMA.Multiline = true;
            this.textBoxInfo_SMA.Name = "textBoxInfo_SMA";
            this.textBoxInfo_SMA.ReadOnly = true;
            this.textBoxInfo_SMA.Size = new System.Drawing.Size(323, 168);
            this.textBoxInfo_SMA.TabIndex = 0;
            this.textBoxInfo_SMA.TabStop = false;
            this.textBoxInfo_SMA.Text = resources.GetString("textBoxInfo_SMA.Text");
            // 
            // buttonOk_SMA
            // 
            this.buttonOk_SMA.Location = new System.Drawing.Point(420, 183);
            this.buttonOk_SMA.Name = "buttonOk_SMA";
            this.buttonOk_SMA.Size = new System.Drawing.Size(77, 28);
            this.buttonOk_SMA.TabIndex = 2;
            this.buttonOk_SMA.Text = "Ок";
            this.buttonOk_SMA.UseVisualStyleBackColor = true;
            this.buttonOk_SMA.Click += new System.EventHandler(this.buttonOk_SMA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 217);
            this.Controls.Add(this.buttonOk_SMA);
            this.Controls.Add(this.textBoxInfo_SMA);
            this.Controls.Add(this.pictureBoxPictureOfMe_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureOfMe_SMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPictureOfMe_SMA;
        private System.Windows.Forms.TextBox textBoxInfo_SMA;
        private System.Windows.Forms.Button buttonOk_SMA;
    }
}