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
        frmVerilerFirmalar frmVerilerFirmalar;
        frmVerilerPersoneller frmVerilerPersoneller;
        frmVerilerStok frmVerilerStok;
        frmVerilerMalzemeUcretleri frmVerilerMalzemeUcretleri;
        frmVerilerParcaKodlari frmVerilerParcaKodlari;
        public userVeriler()
        {
            InitializeComponent();
            frmVerilerFirmalar = new frmVerilerFirmalar();
            frmVerilerPersoneller = new frmVerilerPersoneller();
            frmVerilerStok = new frmVerilerStok();
            frmVerilerMalzemeUcretleri = new frmVerilerMalzemeUcretleri();
            frmVerilerParcaKodlari = new frmVerilerParcaKodlari();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerilerPersoneller.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerilerFirmalar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmVerilerStok.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVerilerMalzemeUcretleri.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVerilerParcaKodlari.ShowDialog();
        }
    }
}
