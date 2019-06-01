using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private Project project;
        private Company company;
        private frmYeniProjeTeklifOlustur()
        {
            InitializeComponent();
        }

        public frmYeniProjeTeklifOlustur(Project project,Company company)
        {
            InitializeComponent();
            this.project = project;
            this.company = company;
            textEditProjeAd.Text = project.Name;
            textEditMusteriAd.Text = company.Name;
            comboBoxEditTeklifBicim.Text = "Parça";
            Lists.pieces.Clear();
            Lists.pieces.CollectionChanged += CollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_PIECES);
            WebSocketService.getInstance().Send(data);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.pieces.Where(s => !SearchInListView(s.Id.ToString())))
            {
                //string[] array = { item.Id.ToString(), item.Code, item.Name, item.Quality, item.Width.ToString(), item.Height.ToString(), item.Thickness.ToString(), item.Type, item.WasteRate.ToString(), item.PMCode.ToString() };
                //ListViewItem listViewItem = new ListViewItem(array);
                if (item.Id < comboBoxEditParcaKodu.Properties.Items.Count)
                {
                    comboBoxEditParcaKodu.Properties.Items.Insert(item.Id, item.Code);
                }
                else
                {
                    comboBoxEditParcaKodu.Properties.Items.Add(item.Code);
                }
            }
        }

        private bool SearchInListView(string Id)
        {
            foreach (string item in comboBoxEditParcaKodu.Properties.Items)
            {
                if (item.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
        }
        #region CheckBox Events
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
        #endregion

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

        private void ComboBoxEditParcaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Piece piece = Lists.pieces.Where(i => i.Code == comboBoxEditParcaKodu.Text).SingleOrDefault();
            Material material = Lists.materials.Where(i => i.Name.Trim() == piece.Quality.Trim()).SingleOrDefault();
            decimal weight = ((decimal)(((decimal)piece.Height * (decimal)piece.Width * 0.8m * (decimal)piece.Thickness) / 100000m));
            textEditParcaAdi.Text = piece.Name;
            labelControlEn.Text = piece.Width.ToString();
            labelControlKalinlik.Text = piece.Thickness.ToString();
            labelControlBoy.Text = piece.Height.ToString();
            labelControlKalite.Text = piece.Quality;
            labelControlFireOrani.Text = piece.WasteRate.ToString();
            labelControlAgirligi.Text = weight.ToString(); // Calculation = Width*Height*0.8*Thickness/100000
            labelControlAlan.Text = ((decimal)((decimal)piece.Width * (decimal)piece.Height / 1000000m)).ToString();
            labelControlMaliyet.Text = (weight * material.Price).ToString();
            labelControlBirimMaliyet.Text = (weight * material.Price).ToString();
        }
    }
}
