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
    public partial class userProjeler : UserControl
    {
        public userProjeler()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmDevamEdenProjeler devamEdenProjeler = new frmDevamEdenProjeler();
            devamEdenProjeler.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOnaydaBekleyenProjeler onaydaBekleyenProjeler = new frmOnaydaBekleyenProjeler();
            onaydaBekleyenProjeler.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmYeniProjeler yeniProjeler = new frmYeniProjeler();
            yeniProjeler.ShowDialog();
        }
    }
}
