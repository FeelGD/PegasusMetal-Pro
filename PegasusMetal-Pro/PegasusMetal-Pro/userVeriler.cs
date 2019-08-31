using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class userVeriler : UserControl
    {
        private delegate void SafeCall(Form frmName);
        frmVerilerFirmalar frmVerilerFirmalar;
        frmVerilerPersoneller frmVerilerPersoneller;
        frmVerilerStok frmVerilerStok;
        frmVerilerMalzemeUcretleri frmVerilerMalzemeUcretleri;
        frmVerilerParcaKodlari frmVerilerParcaKodlari;
        frmVerilerGelirGider frmVerilerGelirGider;
        frmVerilerIslemUcretleri frmVerilerIslemUcretleri;
        public userVeriler()
        {
            InitializeComponent();
        }

        private void ShowDialog(Form frmName)
        {
            if (frmName.InvokeRequired)
            {
                var del = new SafeCall(ShowDialog);
                Invoke(del, new object[] { frmName });
            }
            else
            {
                frmName.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(frmVerilerPersoneller==null)
            {
                frmVerilerPersoneller = new frmVerilerPersoneller();
            }
            ShowDialog(frmVerilerPersoneller);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(frmVerilerFirmalar==null)
            {
                frmVerilerFirmalar = new frmVerilerFirmalar();
            }
            ShowDialog(frmVerilerFirmalar);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(frmVerilerStok==null)
            {
                frmVerilerStok = new frmVerilerStok();
            }
            ShowDialog(frmVerilerStok);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(frmVerilerMalzemeUcretleri==null)
            {
                frmVerilerMalzemeUcretleri = new frmVerilerMalzemeUcretleri();
            }
            ShowDialog(frmVerilerMalzemeUcretleri);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(frmVerilerParcaKodlari==null)
            {
                frmVerilerParcaKodlari = new frmVerilerParcaKodlari();
            }
            ShowDialog(frmVerilerParcaKodlari);
        }

        private void VGiderlerBtn_Click(object sender, EventArgs e)
        {
            if(frmVerilerGelirGider==null)
            {
                frmVerilerGelirGider = new frmVerilerGelirGider();
            }
            ShowDialog(frmVerilerGelirGider);
        }

        private void VIslemUcretleriBtn_Click(object sender, EventArgs e)
        {
            if(frmVerilerIslemUcretleri==null)
            {
                frmVerilerIslemUcretleri = new frmVerilerIslemUcretleri();
            }
            ShowDialog(frmVerilerIslemUcretleri);
        }
    }
}
