
namespace Ödev
{
    partial class FrmFileInfoSınıfıveMetotları
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
            this.lstinfo = new System.Windows.Forms.ListBox();
            this.btngöster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstinfo
            // 
            this.lstinfo.FormattingEnabled = true;
            this.lstinfo.Location = new System.Drawing.Point(12, 12);
            this.lstinfo.Name = "lstinfo";
            this.lstinfo.Size = new System.Drawing.Size(480, 342);
            this.lstinfo.TabIndex = 0;
            // 
            // btngöster
            // 
            this.btngöster.Location = new System.Drawing.Point(180, 360);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(89, 23);
            this.btngöster.TabIndex = 1;
            this.btngöster.Text = "Göster";
            this.btngöster.UseVisualStyleBackColor = true;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // FrmFileInfoSınıfıveMetotları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngöster);
            this.Controls.Add(this.lstinfo);
            this.Name = "FrmFileInfoSınıfıveMetotları";
            this.Text = "FileInfoSınıfıveMetotları";
            this.Load += new System.EventHandler(this.FrmFileInfoSınıfıveMetotları_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstinfo;
        private System.Windows.Forms.Button btngöster;
    }
}