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
            frmVerilerFirmalar = new frmVerilerFirmalar();
            frmVerilerPersoneller = new frmVerilerPersoneller();
            frmVerilerStok = new frmVerilerStok();
            frmVerilerMalzemeUcretleri = new frmVerilerMalzemeUcretleri();
            frmVerilerParcaKodlari = new frmVerilerParcaKodlari();
            frmVerilerGelirGider = new frmVerilerGelirGider();
            frmVerilerIslemUcretleri = new frmVerilerIslemUcretleri();
        }

        private void ShowDialog(Form frmName)
        {
            if(frmName.InvokeRequired)
            {
                var del = new SafeCall(ShowDialog);
                Invoke(del, new object[] { frmName });
            }
            else
            {
                if(frmName != null)
                {
                    frmName.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerPersoneller);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerFirmalar);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerStok);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerMalzemeUcretleri);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerParcaKodlari);
        }

        private void VGiderlerBtn_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerGelirGider);
        }

        private void VIslemUcretleriBtn_Click(object sender, EventArgs e)
        {
            ShowDialog(frmVerilerIslemUcretleri);
        }
    }
}
