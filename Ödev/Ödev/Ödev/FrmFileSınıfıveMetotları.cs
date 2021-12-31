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
    public partial class FrmFileSınıfıveMetotları : Form
    {
        public FrmFileSınıfıveMetotları()
        {
            InitializeComponent();
        }

        private void FrmFile_SınıfıveMetotları_Load(object sender, EventArgs e)
        {
            // Dosya oluşturma,kopyalama,taşıma ve silme gibi işlemleri gerçekleştirmek için
            // File sınıfını kullanırız.File sınıfı static bir sınıftır.Bu sınıfı kullanabilmek
            // için System.IO namespaceini projemize eklememiz gerekmektedir.Şimdi File sınıfının metodlarını inceleyelim.
        }
        public string DosyaYolu= @"C:\Users\elaku\Desktop\Ödev\Ödev\DosyaKlasorİşlemleri\berat.txt";
        public string Dosya= @"C:\Users\elaku\Desktop\Ödev\Ödev\DosyaKlasorİşlemleri\deneme.txt";
        private void button1_Click(object sender, EventArgs e)
        {
         //           Create Metodu

        //Yeni bir dosya oluşturmak için kullanılır. Bu metot ile C#’ ta istenilen dizine dosya oluşturabilir.
        //Yapılması gereken, dosyanın hangi isimle nerede oluşturulacağını yazılmasıdır. 
            File.Create(DosyaYolu);


            File.Create(Environment.CurrentDirectory +"\\ berat.txt");
            if (File.Exists(Environment.CurrentDirectory 
                + "\\ berat.txt"))
            {
                MessageBox.Show("Klasor var");
            }
            else
            {
                MessageBox.Show("Klasor Yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AppendAllText Metodu

          // Mevcut bir text(metin) dosyasına bir satır eklenmek için kullanılır.
          // Bu metodun şöyle bir özelliği var: Eğer yolu belirtilen dosya varsa dosya açılır,
          // gönderilen değer içerisine eklenir. Dosya içerisinde herhangi bir veri varsa bunlar silinmez, sadece gönderilen değer dosyaya eklenir.
          // Diğer bir özelliği ise, eğer belirtilen yolda böyle bir dosya yoksa exception(istisna) verilmez; çünkü eğer böyle bir dosya yoksa metot kendisi oluşturup,
          // içerisine gönderilen veri yazılacaktır.


            string eklenecekYazi = "berat";
            eklenecekYazi += Environment.NewLine;
            File.AppendAllText(DosyaYolu , eklenecekYazi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Copy Metodu

           // C# ta bir dizinden başka bir dizine dosya kopyalamak için kullanılır.
           // Eğer belirtilen kaynak dosya yoksa dosyanın olmadığına dair istisna alınır.
           // Aynı şekilde hedef dizinde aynı isimle bir dosya varsa uygulama yine hataya düşecektir.
           // Bunun için bu işlemi yapmadan önce File.Exists metodu ile dosyanın olup olmadığı kontrol edilebilir.
            
            File.Copy("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİşlemleri\\berat.txt", "D:\\berat.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CreateText Metodu

           // Bu metot ile içerisine yazılmak için bir dosya açılır.
           // Geriye StreamWriter(Akış Yazıcı) nesnesi döner.
           // Bu metot kullanılacaksa içerisine veri girmek için StreamWriter nesnesi kullanılabilir.

           
            using (StreamWriter sw = File.CreateText("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİşlemleri\\berat.txt"))
            {
                sw.WriteLine("1");
                sw.WriteLine("2");
                sw.WriteLine("3");
            }


        }

        private void button5_Click(object sender, EventArgs e)

        {
            //Delete Metodu

             //Bu metot kullanılarak parametre olarak verilen dosya silinebilir.
             //Ancak dosya kullanılıyorsa veya belirtilen dosya yoksa istisna alınır.

            File.Delete("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİşlemleri\\berat.txt");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //GetCreationTime ve GetCreationTimeUtc Metotları

            //GetCreationTime metodu kullanılarak parametre olarak verilen dosyanın oluşturulma zamanı alınabilir.
            //GetCreationTimeUtc metodu ise evrensel saate göre oluşturulma zamanı getirilir.

            string dosya = "C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİşlemleri\\berat.txt";
            DateTime olusturmaZamani = File.GetCreationTime(dosya);
            MessageBox.Show(olusturmaZamani.ToString());
        }
    }
}
