using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ödev
{
    public partial class FrmDirectoryInfoSınıfıveMetotları : Form
    {
        public FrmDirectoryInfoSınıfıveMetotları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yol = "C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİslemleri";
            DirectoryInfo b = new DirectoryInfo(yol);
            listBox1.Items.Add("Özellikler: " + b.Attributes);
            listBox1.Items.Add("Oluşturulma tarihi: " + b.CreationTime);
            listBox1.Items.Add("Var mı? " + b.Exists);
            listBox1.Items.Add("Uzantı: " + b.Extension);
            listBox1.Items.Add("Tam adres: " + b.FullName);
            listBox1.Items.Add("Son erişim zamanı: " + b.LastAccessTime);
            listBox1.Items.Add("Son değişiklik zamanı: " + b.LastWriteTime);
            listBox1.Items.Add("Klasör adı: " + b.Name);
         
            listBox1.Items.Add("Kök dizin: " + b.Root);
        }

        private void FrmDirectoryInfoSınıfıveMetotları_Load(object sender, EventArgs e)
        {

        }
    }
}
