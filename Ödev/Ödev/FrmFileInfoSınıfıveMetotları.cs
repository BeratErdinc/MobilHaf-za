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
    public partial class FrmFileInfoSınıfıveMetotları : Form
    {
        public FrmFileInfoSınıfıveMetotları()
        {
            InitializeComponent();
        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            FileInfo Dosya = new FileInfo("C:\\Users\\elaku\\Desktop\\Ödev\\Ödev\\DosyaKlasorİşlemleri\\berat.txt");
            lstinfo.Items.Add("Dosya var mı? : " + Dosya.Exists);
            //Exists özelliği ile FileInfo nesnesine yolu verilen dosyanın var olup olmadığı kontrol edilir.Eğer varsa True,yoksa False dönecektir.
            lstinfo.Items.Add("Oluşturulma tarihi : " + Dosya.CreationTime);
            //CreationTime özelliği ile FileInfo nesnesine yolu verilen dosyanın oluşturulma tarihini elde edebiliriz.
            lstinfo.Items.Add("Son yazma tarihi : " + Dosya.LastWriteTime);
            //LastWriteTime özelliği ile FileInfo nesnesine yolu verilen dosyanın son yazma tarihini elde edebiliriz.
            lstinfo.Items.Add("Dosyanın tam yolu : " + Dosya.FullName);
            //FullName özelliği ile FileInfo nesnesine yolu verilen dosyanın tam yoluna ulaşabiliriz.
            lstinfo.Items.Add("Bulunduğu klasör : " + Dosya.DirectoryName);
            //DirectoryName özelliği ile FileInfo nesnesine yolu verilen dosyanın bulunduğu klasörü elde edebiliriz.
            lstinfo.Items.Add("Dosya uzantısı : " + Dosya.Extension);
            //Extension özelliği ile FileInfo nesnesine yolu verilen dosyanın uzantısını öğrenebiliriz.
            lstinfo.Items.Add("Dosya boyutu : " + Dosya.Length);
            //Length özelliği ile FileInfo nesnesine yolu verilen dosyanın boyutunu öğrenebiliriz.
        }

        private void FrmFileInfoSınıfıveMetotları_Load(object sender, EventArgs e)
        {

        }
    }
}
