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
    public partial class frmYeniProjeTeklifOlustur : Form
    {
        public frmYeniProjeTeklifOlustur()
        {
            InitializeComponent();
        }

        private void checkEditMontaj_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditMontaj.Checked==true)
            {
                groupBoxMontaj.Visible = true;
            }
            else
            {
                groupBoxMontaj.Visible = false;
            }
           
        }

        private void checkEditLazer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditLazer.Checked == true)
            {
                groupBoxLazer.Visible = true;
            }
            else
            {
                groupBoxLazer.Visible = false;
            }
        }

        private void checkEditBukum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditBukum.Checked == true)
            {
                groupBoxBukum.Visible = true;
            }
            else
            {
                groupBoxBukum.Visible = false;
            }
        }

        private void checkEditKaynak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditKaynak.Checked == true)
            {
                groupBoxKaynak.Visible = true;
            }
            else
            {
                groupBoxKaynak.Visible = false;
            }
        }

        private void checkEditKaplama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditKaplama.Checked == true)
            {
                groupBoxKaplama.Visible = true;
            }
            else
            {
                groupBoxKaplama.Visible = false;
            }
        }

        private void checkEditHavsaAcma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHavsaAcma.Checked == true)
            {
                groupBoxHavsa.Visible = true;
            }
            else
            {
                groupBoxHavsa.Visible = false;
            }
        }

        private void checkEditMaskelemeBandi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditMaskelemeBandi.Checked == true)
            {
                groupBoxMaske.Visible = true;
            }
            else
            {
                groupBoxMaske.Visible = false;
            }
        }

        private void checkEditBoya_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditBoya.Checked == true)
            {
                groupBoxBoya.Visible = true;
            }
            else
            {
                groupBoxBoya.Visible = false;
            }
        }

        private void checkEditTalasli1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditTalasli1.Checked == true)
            {
                groupBoxT1.Visible = true;
            }
            else
            {
                groupBoxT1.Visible = false;
            }
        }

        private void checkEditTalasli2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditTalasli2.Checked == true)
            {
                groupBoxT2.Visible = true;
            }
            else
            {
                groupBoxT2.Visible = false;
            }
        }

        private void checkEditSomunSikma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditSomunSikma.Checked == true)
            {
                groupBoxSomun.Visible = true;
            }
            else
            {
                groupBoxSomun.Visible = false;
            }
        }

        private void checkEditDisAcmaHelicoil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditDisAcmaHelicoil.Checked == true)
            {
                groupBoxDis.Visible = true;
            }
            else
            {
                groupBoxDis.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
