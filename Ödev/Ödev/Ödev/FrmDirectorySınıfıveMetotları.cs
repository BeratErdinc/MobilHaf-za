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
    public partial class FrmDirectorySınıfıveMetotları : Form
    {
        public FrmDirectorySınıfıveMetotları()
        {
            InitializeComponent();
        }
        //Directory Sınıfı statik bir sınıftır ve klasörler ile ilgili işlemler yapmamızı sağlar.
        //Directory sınıfı metotlar ile işlemler yapar, özellikleri yoktur.
        //Directory sınıfının hiçbir özelliği yoktur, System.IO altında bulunur, sadece static metotlar içerir.


        private void button1_Click(object sender, EventArgs e)
        {
            string yol = Directory.GetParent(Application.StartupPath).Parent.FullName;
            if (Directory.Exists(yol + "\\DosyaKlasorİslemleri")) // Klasöe varmı yok mu
            {
                MessageBox.Show("Klasör var");
            }
            else
            {
                MessageBox.Show("Klasör yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // yol dızınınde dosya varmı yok mu kontrolu yoksa oluşturuyor.
            string yol = Directory.GetParent(Application.StartupPath).Parent.FullName;
            yol += "\\DosyaKlasorİslemleri";
            if (Directory.Exists(yol + "\\" + textBox1.Text))
            {
                MessageBox.Show("Bu ısımle oluşturulmuş bir klasör bulunmaktadır.");
            }
            else
            {
                Directory.CreateDirectory(yol + "\\" + textBox1.Text);
                MessageBox.Show("Klasor oluşturuldu");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // silme işlemi
            string yol = Directory.GetParent(Application.StartupPath).Parent.FullName;
            yol += "\\DosyaKlasorİslemleri";
            if (Directory.Exists(yol + "\\" + textBox1.Text))
            {

                Directory.Delete(yol + "\\" + textBox1.Text, true);
                MessageBox.Show("Girilen Klasör silindi");
            }
            else
            {
                MessageBox.Show("Gİrilen Klasor Mevcut Değil");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // taşıma işlemi
            Directory.Move("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİslemleri", "D:\\New folder");
        }

       

        private void FrmDirectorySınıfıveMetotları_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           DateTime date = Directory.GetLastAccessTime("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİslemleri");
            MessageBox.Show(date.ToString());
                        
        }
    }
}
