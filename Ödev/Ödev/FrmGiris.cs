using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView Ders = new TreeView();
            Ders.Width = 500;
            Ders.Height = 500;
            Ders.BackColor = Color.LightSeaGreen;
            TreeNode ödevkonuları = new TreeNode("ÖdevKonuları");
            ödevkonuları.Nodes.Add("DateTimePicker", "DateTimePicker");
            ödevkonuları.Nodes.Add("FileSınıfıveMetorları", "FileSınıfıveMetorları");
            ödevkonuları.Nodes.Add("FileInfoSınıfıveMetotları", "FileInfoSınıfıveMetotları");
            ödevkonuları.Nodes.Add("DirectorySınıfıveMetotları", "DirectorySınıfıveMetotları");
            ödevkonuları.Nodes.Add("DirectoryInfoSınıfıveMetotları", "DirectoryInfoSınıfıveMetotları");
            ödevkonuları.Nodes.Add("DriveInfoSınıfıveMetotları", "DriveInfoSınıfıveMetotları");
            ödevkonuları.Nodes.Add("StreamReaderStreamWriter", "StreamReaderStreamWriter");
            Ders.Nodes.Add(ödevkonuları);
            Ders.ExpandAll();
            Ders.NodeMouseClick += Ders_NodeMouseClick;
            Label lblbilgi = new Label();
            lblbilgi.Size = new Size(300, 100);
            lblbilgi.Location = new Point(642, 222);
            lblbilgi.Text = "Ödev1";
            lblbilgi.ForeColor = Color.Blue;


            Controls.Add(lblbilgi);
            Controls.Add(Ders);
        }

        private void Ders_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "DateTimePicker":
                    FrmDatetimePicker datatimeformu = new FrmDatetimePicker();
                    datatimeformu.ShowDialog();
                    break;

                case "FileSınıfıveMetorları":
                    FrmFileSınıfıveMetotları filesınıfıformu = new FrmFileSınıfıveMetotları();
                    filesınıfıformu.ShowDialog();
                    break;

                case "FileInfoSınıfıveMetotları":
                    FrmFileInfoSınıfıveMetotları infoformu = new FrmFileInfoSınıfıveMetotları();
                    infoformu.ShowDialog();
                    break;


                case "DirectorySınıfıveMetotları":
                  FrmDirectorySınıfıveMetotları directoryformu = new FrmDirectorySınıfıveMetotları();
                    directoryformu.ShowDialog();
                    break;


                case "DirectoryInfoSınıfıveMetotları":
                    FrmDirectoryInfoSınıfıveMetotları directoryinfoformu = new FrmDirectoryInfoSınıfıveMetotları();
                    directoryinfoformu.ShowDialog();
                    break;


                case "DriveInfoSınıfıveMetotları":
                   FrmDriveInfoSnıfıveMetotları driveinfoformu = new FrmDriveInfoSnıfıveMetotları();
                    driveinfoformu.ShowDialog();
                    break;

               case "StreamReaderStreamWriter":
                    FrmStreamReaderStreamWriter frmStreamReaderStreamWriter = new FrmStreamReaderStreamWriter();
                    frmStreamReaderStreamWriter.ShowDialog();
                    break;
            }
        }
    }
}
