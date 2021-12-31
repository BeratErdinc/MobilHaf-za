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
    public partial class FrmDriveInfoSnıfıveMetotları : Form
    {
        public FrmDriveInfoSnıfıveMetotları()
        {
            InitializeComponent();
        }

        private void FrmDriveInfoSnıfıveMetotları_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        // DriveInfo:Bir sürücüdeki bilgilere erişim sağlar.
        //DriveFormat: Sürücünün dosya sistem tipini belirtmektedir. NTFS ya da FAT32 gibi.
       // DriveType: Sürücünün tipini belirtmektedir.CDRom, HDD gibi.
        //IsReady: Sürücünün kullanım için hazır olup olmadığı hakkında bilgi vermektedir.
       //Name: Sürücü harfini belirtmektedir.
       //TotalFreeSpace: Sürücü üzerinde kullanılabilecek toplam boş depolama alanını belirtmektedir.
       //otalSize: Sürücünün toplam depolama alanını belirtmektedir.
         //VolumeLabel: Sürücünün etiket adını belirtmektedir. Aynı zamanda set edilebilmektedir
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (var d in allDrives)
            {
                listBox1.Items.Add("Drive {0}" + d.Name);
                listBox1.Items.Add("  Drive type: {0}"+ d.DriveType);
                if (d.IsReady == true)
                {
                    listBox1.Items.Add("  Volume label: {0}"+ d.VolumeLabel);
                    listBox1.Items.Add("  File system: {0}"+ d.DriveFormat);
                    listBox1.Items.Add(
                        "  Available space to current user:"+
                        d.AvailableFreeSpace);
                    
                    listBox1.Items.Add(
                        "  Total available space:         "+
                        d.TotalFreeSpace);

                    listBox1.Items.Add(
                        "  Total size of drive:             "+
                        d.TotalSize);
                }
            }
        }
    }
}
