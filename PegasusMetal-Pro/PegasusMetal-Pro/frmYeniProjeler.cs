using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class frmYeniProjeler : Form
    {
        public frmYeniProjeler()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmYeniProjeOlustur yeniProjeOlustur = new frmYeniProjeOlustur();
            yeniProjeOlustur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYeniProjeGuncelle yeniProjeGuncelle = new frmYeniProjeGuncelle();
            yeniProjeGuncelle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmYeniProjeTeklifOlustur projeyeTeklifOlustur = new frmYeniProjeTeklifOlustur();
            projeyeTeklifOlustur.ShowDialog();
        }
    }
}
