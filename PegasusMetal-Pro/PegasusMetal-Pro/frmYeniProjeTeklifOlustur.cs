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
        private Piece piece;
        private Material material;
        private object lock_object = new object();
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
            Lists.processes.Clear();
            Lists.processes.CollectionChanged += KaplamaCollectionChanged;
            data.Clear();
            data.Add(OPCodes.GET_PROCESSES);
            WebSocketService.getInstance().Send(data);
        }

        private void KaplamaCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.processes.Where(s => !SearchKaplama(s.Property.ToString()) && s.Name.Contains("Kaplama")))
            {
                if (item.Id < textEditKaplanacakMalzeme.Properties.Items.Count)
                {
                    
                    var t2 = new Task(() =>
                    {
                        lock (lock_object)
                        {
                            if(!SearchKaplama(item.Property))
                            {
                                textEditKaplanacakMalzeme.Properties.Items.Insert(item.Id, item.Property);
                            }
                        }
                    });
                    t2.Start();
                }
                else
                {
                    var t2 = new Task(() => 
                    {
                        lock (lock_object)
                        {
                            if (!SearchKaplama(item.Property))
                            {
                                textEditKaplanacakMalzeme.Properties.Items.Add(item.Property);
                            }
                        }
                    });
                    t2.Start();
                }
            }
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.pieces.Where(s => !SearchInListView(s.Code.ToString())))
            {
                if (item.Id < comboBoxEditParcaKodu.Properties.Items.Count)
                {
                    if(!SearchInListView(item.Code))
                    {
                        comboBoxEditParcaKodu.Properties.Items.Insert(item.Id, item.Code);
                    }
                }
                else
                {
                    if(!SearchInListView(item.Code))
                    {
                        comboBoxEditParcaKodu.Properties.Items.Add(item.Code);
                    }
                }
            }
        }

        private bool SearchKaplama(string Id)
        {
            foreach (string item in textEditKaplanacakMalzeme.Properties.Items)
            {
                if (item.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
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
            Calculate();
        }

        private void simpleButtonParcaKoduEkle_Click(object sender, EventArgs e)
        {
            frmParcaKoduEkle frmParcaKoduEkle = new frmParcaKoduEkle();
            frmParcaKoduEkle.ShowDialog();
        }

        private void Calculate()
        {
            piece = Lists.pieces.Where(i => i.Code == comboBoxEditParcaKodu.Text).SingleOrDefault();
            if (piece != null)
            {
                material = Lists.materials.Where(i => i.Name.Trim() == piece.Quality.Trim()).SingleOrDefault();
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
            else
            {
                textEditParcaAdi.Text = "";
                labelControlEn.Text = "";
                labelControlKalinlik.Text = "";
                labelControlBoy.Text = "";
                labelControlKalite.Text = "";
                labelControlFireOrani.Text = "";
                labelControlAgirligi.Text = ""; // Calculation = Width*Height*0.8*Thickness/100000
                labelControlAlan.Text = "";
                labelControlMaliyet.Text = "";
                labelControlBirimMaliyet.Text = "";
            }
        }

        private void TextEditAdet_EditValueChanged(object sender, EventArgs e)
        {
            if(textEditAdet.Text.Trim() != "")
            {
                Calculate();
                labelControlMaliyet.Text = (Convert.ToDecimal(labelControlMaliyet.Text)*Convert.ToDecimal(textEditAdet.Text)).ToString();
                labelControlAlan.Text = (Convert.ToDecimal(labelControlAlan.Text) * Convert.ToDecimal(textEditAdet.Text)).ToString();
                labelControlAgirligi.Text = (Convert.ToDecimal(labelControlAgirligi.Text) * Convert.ToDecimal(textEditAdet.Text)).ToString(); // Calculation = Width*Height*0.8*Thickness/100000
            }
            else
            {
                Calculate();
            }
        }

        private void CalculateLazer()
        {
            if (textEditKesimSuresi.Text.Trim() == "" || textEditKesimSuresi.Text.Trim() == "0")
            {
                labelControlLazerTl.Text = "0" + " TL";
                return;
            }
            float price = ((float)(material.Price * Convert.ToDecimal(textEditKesimSuresi.Text)));
            if (textEditLazerKar.Text.Trim() != "")
            {
                labelControlLazerTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditLazerKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlLazerTl.Text = price.ToString() + " TL";
            }
        }

        private void TextEditKesimSuresi_TextChanged(object sender, EventArgs e)
        {
            CalculateLazer();
        }

        private void TextEditLazerKar_TextChanged(object sender, EventArgs e)
        {
            CalculateLazer();
        }

        private void TextEditBoyaKar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
