﻿using System;
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
        public userVeriler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerilerPersoneller frmVerilerPersoneller = new frmVerilerPersoneller();
            frmVerilerPersoneller.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerilerFirmalar frmVerilerFirmalar = new frmVerilerFirmalar();
            frmVerilerFirmalar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmVerilerStok frmVerilerStok = new frmVerilerStok();
            frmVerilerStok.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVerilerMalzemeUcretleri frmVerilerMalzemeUcretleri = new frmVerilerMalzemeUcretleri();
            frmVerilerMalzemeUcretleri.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVerilerParcaKodlari frmVerilerParcaKodlari = new frmVerilerParcaKodlari();
            frmVerilerParcaKodlari.ShowDialog();
        }
    }
}
