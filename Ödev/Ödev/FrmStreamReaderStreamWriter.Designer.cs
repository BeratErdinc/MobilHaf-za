
namespace Ödev
{
    partial class FrmStreamReaderStreamWriter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnaç = new System.Windows.Forms.Button();
            this.btnfarklıkayet = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 188);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnaç
            // 
            this.btnaç.Location = new System.Drawing.Point(206, 34);
            this.btnaç.Name = "btnaç";
            this.btnaç.Size = new System.Drawing.Size(75, 23);
            this.btnaç.TabIndex = 2;
            this.btnaç.Text = "Aç";
            this.btnaç.UseVisualStyleBackColor = true;
            this.btnaç.Click += new System.EventHandler(this.btnaç_Click);
            // 
            // btnfarklıkayet
            // 
            this.btnfarklıkayet.Location = new System.Drawing.Point(178, 265);
            this.btnfarklıkayet.Name = "btnfarklıkayet";
            this.btnfarklıkayet.Size = new System.Drawing.Size(89, 23);
            this.btnfarklıkayet.TabIndex = 3;
            this.btnfarklıkayet.Text = "Farklı Kaydet";
            this.btnfarklıkayet.UseVisualStyleBackColor = true;
            this.btnfarklıkayet.Click += new System.EventHandler(this.btnfarklıkayet_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(36, 265);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // FrmStreamReaderStreamWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnfarklıkayet);
            this.Controls.Add(this.btnaç);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmStreamReaderStreamWriter";
            this.Text = "FrmStreamReaderStreamWriter";
            this.Load += new System.EventHandler(this.FrmStreamReaderStreamWriter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnaç;
        private System.Windows.Forms.Button btnfarklıkayet;
        private System.Windows.Forms.Button btnkaydet;
    }
}