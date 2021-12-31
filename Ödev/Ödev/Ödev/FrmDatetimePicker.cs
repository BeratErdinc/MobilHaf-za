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
    public partial class FrmDatetimePicker : Form
    {
        public FrmDatetimePicker()
        {
            InitializeComponent();
        }

        private void FrmDatetimePicker_Load(object sender, EventArgs e)
        {
            //Windows Forms DateTimePicker denetimi, denetimdeki tarih ve saatlerin görüntülenmesini biçimlendirme esnekliği sağlar.

            // DateTimePickerı ekler 
            DateTimePicker zaman = new DateTimePicker();
            Controls.Add(zaman);

            //Şimdi label oluşturup daha farklı kullanımlarını görelim
            Label lblzaman = new Label();
            lblzaman.Location =  new Point(20,20);
            Controls.Add(lblzaman);
            lblzaman.Text = zaman.Value.ToString();  //hepsini yazar
            // lblzaman.Text = zaman.Value.ToShortTimeString(); // zaman yazar
            //lblzaman.Text = zaman.Value.ToShortDateString();  tarih yazar
             
        }
    }
}
