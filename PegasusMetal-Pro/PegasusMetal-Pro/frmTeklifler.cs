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
    public partial class frmTeklifler : Form
    {
        public frmTeklifler()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTekliflerPersonelAta frmTekliflerPersonelAta = new frmTekliflerPersonelAta();
            frmTekliflerPersonelAta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTekliflerTeklifGuncelle frmTekliflerTeklifGuncelle = new frmTekliflerTeklifGuncelle();
            frmTekliflerTeklifGuncelle.ShowDialog();
        }
    }
}
