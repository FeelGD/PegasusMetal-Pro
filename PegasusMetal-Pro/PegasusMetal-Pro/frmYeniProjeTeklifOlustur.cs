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

        private void CalculateBukum(decimal? price,int value)
        {
            float calc = (float)(price * (decimal)value);
            if(textEditBukumKar.Text.Trim() != "")
            {
                labelControlBukumTl.Text = ((float)((calc / 100) * (100 + int.Parse(textEditBukumKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlBukumTl.Text = calc.ToString() + " TL";
            }
        }

        private void textEditBukumSuresi_TextChanged(object sender, EventArgs e)
        {
            if (textEditBukumSuresi.Text.Trim() == "" || textEditBukumSuresi.Text.Trim() == "") return;
            textEditBukumAdedi.Text = "0";
            decimal? price = GetPrice(true);
            CalculateBukum(price, int.Parse(textEditBukumSuresi.Text));
        }

        private void textEditBukumAdedi_TextChanged(object sender, EventArgs e)
        {
            if (textEditBukumAdedi.Text.Trim() == "" || textEditBukumAdedi.Text.Trim() == "") return;
            textEditBukumSuresi.Text = "0";
            decimal? price = GetPrice(false);
            CalculateBukum(price, int.Parse(textEditBukumAdedi.Text));
        }

        private decimal? GetPrice(bool type)
        {
            if(type)
            {
                if (piece.Thickness >= 0.8m && piece.Thickness < 1.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "0.8").SingleOrDefault().MinutePrice;
                }
                else if (piece.Thickness >= 1.0m && piece.Thickness < 2.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "1").SingleOrDefault().MinutePrice;
                }
                else if (piece.Thickness >= 2.0m && piece.Thickness < 3.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "2").SingleOrDefault().MinutePrice;
                }
                else if (piece.Thickness >= 3.0m && piece.Thickness < 8.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "5").SingleOrDefault().MinutePrice;
                }
                else if (piece.Thickness >= 8.0m && piece.Thickness <= 10m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "10").SingleOrDefault().MinutePrice;
                }
                else
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "10").SingleOrDefault().MinutePrice;
                }
            }
            else
            {
                if (piece.Thickness >= 0.8m && piece.Thickness < 1.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "0.8").SingleOrDefault().UnitPrice;
                }
                else if (piece.Thickness >= 1.0m && piece.Thickness < 2.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "1").SingleOrDefault().UnitPrice;
                }
                else if (piece.Thickness >= 2.0m && piece.Thickness < 3.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "2").SingleOrDefault().UnitPrice;
                }
                else if (piece.Thickness >= 3.0m && piece.Thickness < 8.0m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "5").SingleOrDefault().UnitPrice;
                }
                else if (piece.Thickness >= 8.0m && piece.Thickness <= 10m)
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "10").SingleOrDefault().UnitPrice;
                }
                else
                {
                    return Lists.processes.Where(i => i.Name == "Büküm" && i.Property == "10").SingleOrDefault().UnitPrice;
                }
            }
        }

        private void textEditBukumKar_TextChanged(object sender, EventArgs e)
        {
            if (textEditBukumAdedi.Text.Trim() == "" && textEditBukumAdedi.Text.Trim() == "0" && textEditBukumSuresi.Text.Trim() == "" && textEditBukumSuresi.Text.Trim() == "0") return;
            if(textEditBukumSuresi.Text.Trim() != "" && textEditBukumSuresi.Text.Trim() != "0")
            {
                CalculateBukum(GetPrice(true), int.Parse(textEditBukumSuresi.Text));
            }
            else if(textEditBukumAdedi.Text.Trim() != "" && textEditBukumAdedi.Text.Trim() != "0")
            {
                CalculateBukum(GetPrice(false), int.Parse(textEditBukumAdedi.Text));
            }
        }

        private void CalculateKaynak()
        {
            if (textEditKaynakSuresi.Text.Trim() == "0" && textEditKaynakSuresi.Text.Trim() == "")
            {
                return;
            }
            Process process = Lists.processes.Where(i => i.Name.Trim() == "Kaynak" && i.Property.ToLower() == "Kaynak".ToLower()).SingleOrDefault();
            float price = (float)(Convert.ToDecimal(textEditKaynakSuresi.Text) * process.MinutePrice);
            if(textEditKaynakKar.Text.Trim() != "")
            {
                labelControlKaynakTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditKaynakKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlKaynakTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditKaynakSuresi_TextChanged(object sender, EventArgs e)
        {
            CalculateKaynak();
        }

        private void textEditKaynakKar_TextChanged(object sender, EventArgs e)
        {
            CalculateKaynak();
        }

        private void CalculateKaplama()
        {
            if(textEditKaplamaParcaAgirligi.Text.Trim() == ""  || textEditKaplanacakMalzeme.Text.Trim() == "")
            {
                return;
            }
            Process process = Lists.processes.Where(i => i.Name.ToLower().Contains("Kaplama".ToLower()) && i.Property.Trim() == textEditKaplanacakMalzeme.Text.Trim()).SingleOrDefault();
            float price = (float)(process.UnitPrice*Convert.ToDecimal(textEditKaplamaParcaAgirligi.Text));
            if(textEditKaplamaKar.Text.Trim() != "")
            {
                labelControlKaplamaTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditKaynakKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlKaplamaTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditKaplamaParcaAgirligi_TextChanged(object sender, EventArgs e)
        {
            CalculateKaplama();
        }

        private void textEditKaplamaKar_TextChanged(object sender, EventArgs e)
        {
            CalculateKaplama();
        }

        private void CalculateHavsa()
        {
            if (textEditHavsaAdedi.Text.Trim() == "")
            {
                return;
            }
            Process process = Lists.processes.Where(i => i.Name.Trim() == "Havşa Açma" && i.Property.ToLower() == "HAVŞA AÇMA".ToLower()).SingleOrDefault();
            float price = (float)(Convert.ToDecimal(textEditHavsaAdedi.Text) * process.UnitPrice);
            if (textEditHavsaAcmaKar.Text.Trim() != "")
            {
                labelControlHavsaTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditHavsaAcmaKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlHavsaTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditHavsaAdedi_TextChanged(object sender, EventArgs e)
        {
            CalculateHavsa();
        }

        private void textEditHavsaAcmaKar_TextChanged(object sender, EventArgs e)
        {
            CalculateHavsa();
        }

        private void CalculateMontaj()
        {
            if (textEditMontajIscilik.Text.Trim() == "" || textEditMontajToplamSet.Text.Trim() == "")
            {
                return;
            }
            float price = (float)(Convert.ToDecimal(textEditMontajToplamSet.Text) * Convert.ToDecimal(textEditMontajIscilik.Text));
            if(textEditMontajKar.Text.Trim() != "")
            {
                labelControlMontajTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditMontajKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlMontajTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditMontajKar_TextChanged(object sender, EventArgs e)
        {
            CalculateMontaj();
        }

        private void textEditMontajToplamSet_TextChanged(object sender, EventArgs e)
        {
            CalculateMontaj();
        }

        private void textEditMontajIscilik_TextChanged(object sender, EventArgs e)
        {
            CalculateMontaj();
        }

        private void CalculateMaskeleme()
        {
            if (textEditMaskelemeIscilikSuresi.Text.Trim() == "" && textEditMaskelemeBantAlani.Text.Trim() == "") return;
            Process process = radioButtonEbatli.Checked ? Lists.processes.Where(i => i.Name.Trim() == "Maskeleme Bandı" && i.Property.Trim() == "EBATLI").SingleOrDefault() : Lists.processes.Where(i => i.Name.Trim() == "Maskeleme Bandı" && i.Property.Trim() == "EBATSIZ").SingleOrDefault();
            float price = 0f;
            if (textEditMaskelemeBantAlani.Text.Trim() != "0" && textEditMaskelemeBantAlani.Text.Trim() != "")
            {
                price = (float)(Convert.ToDecimal(textEditMaskelemeBantAlani.Text) * process.UnitPrice);
            }
            else if (textEditMaskelemeIscilikSuresi.Text.Trim() != "0" && textEditMaskelemeIscilikSuresi.Text.Trim() != "")
            {
                price = (float)(Convert.ToDecimal(textEditMaskelemeIscilikSuresi.Text) * process.MinutePrice);
            }

            if(textEditMaskelemeKar.Text.Trim() != "")
            {
                labelControlMaskelemeTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditMaskelemeKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlMaskelemeTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditMaskelemeIscilikSuresi_TextChanged(object sender, EventArgs e)
        {
            CalculateMaskeleme();
        }

        private void textEditMaskelemeBantAlani_TextChanged(object sender, EventArgs e)
        {
            CalculateMaskeleme();
        }

        private void textEditMaskelemeKar_TextChanged(object sender, EventArgs e)
        {
            CalculateMaskeleme();
        }

        private void CalculateBoya()
        {
            if(textEditBoyaParcaAlani.Text.Trim() == "") { return; }
            Process process=null;
            if(piece.Thickness <2m)
            {
                process = Lists.processes.Where(i => i.Name.Trim() == "Boya" && i.Property.Trim() == "0.8").SingleOrDefault();
            }
            else
            {
                process = Lists.processes.Where(i => i.Name.Trim() == "Boya" && i.Property.Trim() == "2").SingleOrDefault();
            }
            float price = (float)(process.UnitPrice * Convert.ToDecimal(textEditBoyaParcaAlani.Text));
            if (textEditBoyaKar.Text.Trim() != "")
            {
                labelControlBoyaTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditBoyaKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlBoyaTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditBoyaParcaAlani_TextChanged(object sender, EventArgs e)
        {
            CalculateBoya();
        }

        private void textEditBoyaKar_TextChanged(object sender, EventArgs e)
        {
            CalculateBoya();
        }

        private void CalculateTalasli1()
        {
            if (textEditTalasli1Adet.Text.Trim() == "" || textEditTalasli1Fiyat.Text.Trim() == "") { return; }
            float price = (float)(Convert.ToDecimal(textEditTalasli1Fiyat.Text) * Convert.ToDecimal(textEditTalasli1Adet.Text));
            if (textEditTalasli1Kar.Text.Trim() != "")
            {
                labelControlTalasliTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditTalasli1Kar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlTalasliTl.Text = price.ToString() + " TL";
            }
        }

        private void CalculateTalasli2()
        {
            if (textEditTalasli2Adet.Text.Trim() == "" || textEditTalasli2Fiyat.Text.Trim() == "" || textEditTalasli2Boy.Text.Trim() == "") { return; }
            float price = (float)(Convert.ToDecimal(textEditTalasli2Fiyat.Text) * Convert.ToDecimal(textEditTalasli2Adet.Text)*Convert.ToDecimal(textEditTalasli2Boy.Text));
            if (textEditTalasli2Kar.Text.Trim() != "")
            {
                labelControlTalasliCapTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditTalasli2Kar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlTalasliCapTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditTalasli1Adet_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli1();
        }

        private void textEditTalasli1Fiyat_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli1();
        }

        private void textEditTalasli1Kar_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli1();
        }

        private void textEditTalasli2Adet_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli2();
        }

        private void textEditTalasli2Boy_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli2();
        }

        private void textEditTalasli2Fiyat_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli2();
        }

        private void textEditTalasli2Kar_TextChanged(object sender, EventArgs e)
        {
            CalculateTalasli2();
        }

        private void CalculateSomunSikma()
        {
            if (textEditSomunSikmaIscilik.Text.Trim() == "" || textEditSomunSikmaSetAdedi.Text.Trim() == "" || textEditSomunSikmaToplamSet.Text.Trim() == "") { return; }
            float price = (float)(Convert.ToDecimal(textEditSomunSikmaToplamSet.Text) * Convert.ToDecimal(textEditSomunSikmaIscilik.Text) * Convert.ToDecimal(textEditSomunSikmaSetAdedi.Text));
            if (textEditSomunSikmaKar.Text.Trim() != "")
            {
                labelControlSomunTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditSomunSikmaKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlSomunTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditSomunSikmaIscilik_TextChanged(object sender, EventArgs e)
        {
            CalculateSomunSikma();
        }

        private void textEditSomunSikmaSetAdedi_TextChanged(object sender, EventArgs e)
        {
            CalculateSomunSikma();
        }

        private void textEditSomunSikmaToplamSet_TextChanged(object sender, EventArgs e)
        {
            CalculateSomunSikma();
        }

        private void textEditSomunSikmaKar_TextChanged(object sender, EventArgs e)
        {
            CalculateSomunSikma();
        }

        private float CalculateDisAcma()
        {
            if(textEditDisAdedi.Text.Trim() == "" || textEditDisEbadi.Text.Trim() == "")
            {
                return 0f;
            }
            decimal disEbadi = Convert.ToDecimal(textEditDisEbadi.Text);
            decimal? price = 0m;
            if(disEbadi >= 3 && disEbadi < 6)
            {
                price = Lists.processes.Where(i => i.Name.Trim() == "Diş Açma" && i.Property.Trim() == "3").SingleOrDefault().UnitPrice;
                return (float)(price*Convert.ToDecimal(textEditDisAdedi.Text));
            }
            else if (disEbadi >= 6 && disEbadi < 8)
            {
                price = Lists.processes.Where(i => i.Name.Trim() == "Diş Açma" && i.Property.Trim() == "6").SingleOrDefault().UnitPrice;
                return (float)(price * Convert.ToDecimal(textEditDisAdedi.Text));
            }
            else if (disEbadi >= 8 && disEbadi <= 16)
            {
                price = Lists.processes.Where(i => i.Name.Trim() == "Diş Açma" && i.Property.Trim() == "8").SingleOrDefault().UnitPrice;
                return (float)(price * Convert.ToDecimal(textEditDisAdedi.Text));
            }
            else
            {
                price = Lists.processes.Where(i => i.Name.Trim() == "Diş Açma" && i.Property.Trim() == "8").SingleOrDefault().UnitPrice;
                return (float)(price * Convert.ToDecimal(textEditDisAdedi.Text));
            }
        }

        private float CalculateHelicoil()
        {
            if (textEditHelicoilAdet.Text.Trim() == "" || textEditHelicoilFiyat.Text.Trim() == "")
            {
                return 0f;
            }
            return (float)(Convert.ToDecimal(textEditHelicoilFiyat.Text)*Convert.ToDecimal(textEditHelicoilAdet.Text));
        }

        private void CalculateDisAcmaHelicoilTL()
        {
            float price = CalculateHelicoil() + CalculateDisAcma();
            if (textEditDisAcmaKar.Text.Trim() != "")
            {
                labelControlSomunTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditDisAcmaKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlSomunTl.Text = price.ToString() + " TL";
            }
        }

        private void textEditDisAdedi_TextChanged(object sender, EventArgs e)
        {
            CalculateDisAcmaHelicoilTL();
        }

        private void textEditDisEbadi_TextChanged(object sender, EventArgs e)
        {
            CalculateDisAcmaHelicoilTL();
        }

        private void textEditHelicoilAdet_TextChanged(object sender, EventArgs e)
        {
            CalculateDisAcmaHelicoilTL();
        }

        private void textEditHelicoilFiyat_TextChanged(object sender, EventArgs e)
        {
            CalculateDisAcmaHelicoilTL();
        }

        private void textEditDisAcmaKar_TextChanged(object sender, EventArgs e)
        {
            CalculateDisAcmaHelicoilTL();
        }

        private void TextEditKaplanacakMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateKaplama();
        }

        private void textEditParcaAdi_TextChanged(object sender, EventArgs e)
        {
            if (textEditParcaAdi.Text!="")
            {
                checkEditLazer.Enabled = true;
                checkEditBukum.Enabled = true;
                checkEditKaynak.Enabled = true;
                checkEditKaplama.Enabled = true;
                checkEditHavsaAcma.Enabled = true;
                checkEditMontaj.Enabled = true;
                checkEditMaskelemeBandi.Enabled = true;
                checkEditBoya.Enabled = true;
                checkEditTalasli1.Enabled = true;
                checkEditTalasli2.Enabled = true;
                checkEditSomunSikma.Enabled = true;
                checkEditDisAcmaHelicoil.Enabled = true;
            
            }
            else
            {
                checkEditLazer.Enabled = false;
                checkEditBukum.Enabled = false;
                checkEditKaynak.Enabled = false;
                checkEditKaplama.Enabled = false;
                checkEditHavsaAcma.Enabled = false;
                checkEditMontaj.Enabled = false;
                checkEditMaskelemeBandi.Enabled = false;
                checkEditBoya.Enabled = false;
                checkEditTalasli1.Enabled = false;
                checkEditTalasli2.Enabled = false;
                checkEditSomunSikma.Enabled = false;
                checkEditDisAcmaHelicoil.Enabled = false;
            }
        }
    }
}
