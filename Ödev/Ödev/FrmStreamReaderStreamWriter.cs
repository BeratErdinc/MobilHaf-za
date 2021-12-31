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
using ApprovalUtilities.SimpleLogger.Writers;
using ICSharpCode.AvalonEdit.Utils;

namespace Ödev
{
    public partial class FrmStreamReaderStreamWriter : Form
    {
        public FrmStreamReaderStreamWriter()
        {
            InitializeComponent();
        }

        private void FrmStreamReaderStreamWriter_Load(object sender, EventArgs e)
        {

        }

       
        private void btnaç_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "(*.txt)|*.txt"; // sadece txt dosyalarını acmasını emrettık
            of.ShowDialog();
            textBox1.Text = of.FileName;
            if (!(textBox1.Text=="")) // eger adres varsa dosyayı okumasını sağlattık
            {
                StreamReader str = new StreamReader(textBox1.Text);
                richTextBox1.Text = str.ReadToEnd();
                str.Close();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "")) // eger adres varsa oraya kaydet
            {
                StreamWriter sw = new StreamWriter(textBox1.Text);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
            else
            {
                SaveFileDialog slf = new SaveFileDialog();
                slf.Filter = "(*.txt)|*.txt";
                slf.ShowDialog();
                if(!(slf.FileName=="")) // eger bır adres secıı ıse calış
                {
                    StreamWriter swt = new StreamWriter(slf.FileName);
                    swt.Write(richTextBox1.Text);
                    swt.Close();
                    var writer = new FileWriter();
                   
                }
            }
        }

        private void btnfarklıkayet_Click(object sender, EventArgs e)
        {
            SaveFileDialog slf = new SaveFileDialog();
            slf.Filter = "(*.txt)|*.txt";
            slf.ShowDialog();
            if (!(slf.FileName == "")) // eger bır adres secıı ıse calış
            {
                StreamWriter swt = new StreamWriter(slf.FileName);
                swt.Write(richTextBox1.Text);
                swt.Close();

            }
        }

        
        
    }
}
