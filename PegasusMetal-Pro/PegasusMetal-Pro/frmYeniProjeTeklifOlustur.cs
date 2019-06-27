using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
using PegasusMetal_Pro.Models;
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
        private Offer generalOffer;
        private delegate void AddDelegate(object item);
        private delegate void InsertDelegate(int index, object item);
        private object lock_object = new object();
        private List<OfferItem> offerItems = new List<OfferItem>();
        decimal? totalPieceCost = 0m;
        decimal generalPrice = 0m;
        decimal totalPrice = 0m;
        private frmYeniProjeTeklifOlustur()
        {
            InitializeComponent();
        }

        public frmYeniProjeTeklifOlustur(Project project, Company company)
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

        private void Initialize(Project project, Company company)
        {
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

        public frmYeniProjeTeklifOlustur(Project project, Company company, Offer generalOffer)
        {
            InitializeComponent();
            Initialize(project, company);
            List<string> data = new List<string>();
            Lists.offerItems.CollectionChanged += OfferItemsCollectionChanged;
            data.Add(OPCodes.GET_OFFER_ITEMS);
            WebSocketService.getInstance().Send(data);
            totalPieceCost = generalOffer.UnitPrice;
            generalPrice = generalOffer.OfferPrice;
            labelControl26.Text = totalPieceCost.ToString();
            labelControl29.Text = generalPrice.ToString();
            totalPrice = generalPrice;
            textEdit1.Text = generalOffer.LastPrice.ToString();
            textEditKarOran.Text = generalOffer.ProfitPercentage.ToString();
            textEditIndirimOran.Text = generalOffer.DiscountPercentage.ToString();
            totalPrice = generalPrice * ((100 + int.Parse(textEditKarOran.Text)) / 100);
            totalPrice = generalPrice - generalPrice * ((int.Parse(textEditIndirimOran.Text)) / 100);
            labelControl32.Text = totalPrice.ToString() + "TL";
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
                            if (!SearchKaplama(item.Property))
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
                    if (!SearchInListView(item.Code))
                    {
                        Insert(item.Id, item.Code);
                    }
                }
                else
                {
                    if (!SearchInListView(item.Code))
                    {
                        Add(item.Code);
                    }
                }
            }
        }

        private void OfferItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.offerItems.Where(s => !SearchInListView2(s.Id.ToString())))
            {
                if (item.Id < comboBoxEditParcaKodu.Properties.Items.Count)
                {
                    offerItems.Add(item);
                    AddListView(GetListViewItem(item));
                }
                else
                {
                    offerItems.Insert(item.Id, item);
                    InsertListView(item.Id, GetListViewItem(item));
                }
            }
        }

        private void AddListView(object item)
        {
            if (listView2.InvokeRequired)
            {
                var d = new AddDelegate(AddListView);
                Invoke(d, new object[] { item });
            }
            else
            {
                listView2.Items.Add((ListViewItem)item);
            }
        }

        private void InsertListView(int index, object item)
        {
            if (listView2.InvokeRequired)
            {
                var d = new InsertDelegate(InsertListView);
                Invoke(d, new object[] { index, item });
            }
            else
            {
                listView2.Items.Insert(index, (ListViewItem)item);
            }
        }

        private void Add(object item)
        {
            if (comboBoxEditParcaKodu.InvokeRequired)
            {
                var d = new AddDelegate(Add);
                Invoke(d, new object[] { item });
            }
            else
            {
                comboBoxEditParcaKodu.Properties.Items.Add(item);
            }
        }

        private void Insert(int index, object item)
        {
            if (comboBoxEditParcaKodu.InvokeRequired)
            {
                var d = new InsertDelegate(Insert);
                Invoke(d, new object[] { index, item });
            }
            else
            {
                comboBoxEditParcaKodu.Properties.Items.Insert(index, item);
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

        private bool SearchInListView2(string Id)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                if (item.Text.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
        }
        #region CheckBox Events
        private void checkEditMontaj_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditMontaj.Checked == true)
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
                labelControlMaliyet.Text = (piece.WasteRate * weight * material.Price).ToString();
                labelControlBirimMaliyet.Text = (weight * material.Price*int.Parse(textEditAdet.Text)).ToString();
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
            if (textEditAdet.Text.Trim() != "")
            {
                Calculate();
                labelControlMaliyet.Text = (Convert.ToDecimal(labelControlMaliyet.Text) * Convert.ToDecimal(textEditAdet.Text)).ToString();
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

        private void CalculateBukum(decimal? price, float value) //float int
        {
            float calc = (float)(price * (decimal)value);
            if (textEditBukumKar.Text.Trim() != "")
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
            CalculateBukum(price, float.Parse(textEditBukumSuresi.Text));
        }

        private void textEditBukumAdedi_TextChanged(object sender, EventArgs e)
        {
            if (textEditBukumAdedi.Text.Trim() == "" || textEditBukumAdedi.Text.Trim() == "") return;
            textEditBukumSuresi.Text = "0";
            decimal? price = GetPrice(false);
            CalculateBukum(price, float.Parse(textEditBukumAdedi.Text));
        }

        private decimal? GetPrice(bool type)
        {
            if (type)
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
            if (textEditBukumSuresi.Text.Trim() != "" && textEditBukumSuresi.Text.Trim() != "0")
            {
                CalculateBukum(GetPrice(true), int.Parse(textEditBukumSuresi.Text));
            }
            else if (textEditBukumAdedi.Text.Trim() != "" && textEditBukumAdedi.Text.Trim() != "0")
            {
                CalculateBukum(GetPrice(false), int.Parse(textEditBukumAdedi.Text));
            }
        }

        private void CalculateKaynak()
        {
            if (textEditKaynakSuresi.Text.Trim() == "0" || textEditKaynakSuresi.Text.Trim() == "")
            {
                labelControlKaynakTl.Text = "..... TL";
                return;
            }
            Process process = Lists.processes.Where(i => i.Name.Trim() == "Kaynak" && i.Property.ToLower() == "Kaynak".ToLower()).SingleOrDefault();
            float price = (float)(Convert.ToDecimal(textEditKaynakSuresi.Text) * process.MinutePrice);
            if (textEditKaynakKar.Text.Trim() != "")
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
            if (textEditKaplamaParcaAgirligi.Text.Trim() == "" || textEditKaplanacakMalzeme.Text.Trim() == "")
            {
                return;
            }
            Process process = Lists.processes.Where(i => i.Name.ToLower().Contains("Kaplama".ToLower()) && i.Property.Trim() == textEditKaplanacakMalzeme.Text.Trim()).SingleOrDefault();
            float price = (float)(process.UnitPrice * Convert.ToDecimal(textEditKaplamaParcaAgirligi.Text));
            if (textEditKaplamaKar.Text.Trim() != "")
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
                labelControlHavsaTl.Text = "..... TL";
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
            if (textEditMontajKar.Text.Trim() != "")
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

            if (textEditMaskelemeKar.Text.Trim() != "")
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
            if (textEditBoyaParcaAlani.Text.Trim() == "") { labelControlBoyaTl.Text = "..... TL"; return; }
            Process process = null;
            if (piece.Thickness < 2m)
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
                labelControlBoyaTl.Text = ((float)((price / 100) * 2 * (100 + int.Parse(textEditBoyaKar.Text)))).ToString() + " TL";
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
            if (textEditTalasli1Adet.Text.Trim() == "" || textEditTalasli1Fiyat.Text.Trim() == "") { labelControlTalasliTl.Text = "..... TL"; return; }
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
            if (textEditTalasli2Adet.Text.Trim() == "" || textEditTalasli2Fiyat.Text.Trim() == "" || textEditTalasli2Boy.Text.Trim() == "") { labelControlTalasliCapTl.Text = "..... TL"; return; }
            float price = (float)(Convert.ToDecimal(textEditTalasli2Fiyat.Text) * Convert.ToDecimal(textEditTalasli2Adet.Text) * Convert.ToDecimal(textEditTalasli2Boy.Text));
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
            if (textEditSomunSikmaIscilik.Text.Trim() == "" || textEditSomunSikmaSetAdedi.Text.Trim() == "" || textEditSomunSikmaToplamSet.Text.Trim() == "") { labelControlSomunTl.Text = "..... TL"; return; }
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
            if (textEditDisAdedi.Text.Trim() == "" || textEditDisEbadi.Text.Trim() == "")
            {
                return 0f;
            }
            decimal disEbadi = Convert.ToDecimal(textEditDisEbadi.Text);
            decimal? price = 0m;
            if (disEbadi >= 3 && disEbadi < 6)
            {
                price = Lists.processes.Where(i => i.Name.Trim() == "Diş Açma" && i.Property.Trim() == "3").SingleOrDefault().UnitPrice;
                return (float)(price * Convert.ToDecimal(textEditDisAdedi.Text));
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
            return (float)(Convert.ToDecimal(textEditHelicoilFiyat.Text) * Convert.ToDecimal(textEditHelicoilAdet.Text));
        }

        private void CalculateDisAcmaHelicoilTL()
        {
            float price = CalculateHelicoil() + CalculateDisAcma();
            if (textEditDisAcmaKar.Text.Trim() != "")
            {
                labelControlDisTl.Text = ((float)((price / 100) * (100 + int.Parse(textEditDisAcmaKar.Text)))).ToString() + " TL";
            }
            else
            {
                labelControlDisTl.Text = price.ToString() + " TL";
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
            if (textEditParcaAdi.Text != "")
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

        private void SimpleButtonHesapla_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0m;
            if (labelControlLazerTl.Text.Trim() != "..... TL" && checkEditLazer.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlLazerTl.Text.Substring(0, labelControlLazerTl.Text.Length - 2).Trim());
            }
            if (labelControlBukumTl.Text.Trim() != "..... TL" && checkEditBukum.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlBukumTl.Text.Substring(0, labelControlBukumTl.Text.Length - 2).Trim());
            }
            if (labelControlKaynakTl.Text.Trim() != "..... TL" && checkEditKaynak.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlKaynakTl.Text.Substring(0, labelControlKaynakTl.Text.Length - 2).Trim());
            }
            if (labelControlKaplamaTl.Text.Trim() != "..... TL" && checkEditKaplama.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlKaplamaTl.Text.Substring(0, labelControlKaplamaTl.Text.Length - 2).Trim());
            }
            if (labelControlHavsaTl.Text.Trim() != "..... TL" && checkEditHavsaAcma.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlHavsaTl.Text.Substring(0, labelControlHavsaTl.Text.Length - 2).Trim());
            }
            if (labelControlMontajTl.Text.Trim() != "..... TL" && checkEditMontaj.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlMontajTl.Text.Substring(0, labelControlMontajTl.Text.Length - 2).Trim());
            }
            if (labelControlMaskelemeTl.Text.Trim() != "..... TL" && checkEditMaskelemeBandi.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlMaskelemeTl.Text.Substring(0, labelControlMaskelemeTl.Text.Length - 2).Trim());
            }
            if (labelControlBoyaTl.Text.Trim() != "..... TL" && checkEditBoya.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlBoyaTl.Text.Substring(0, labelControlBoyaTl.Text.Length - 2).Trim());
            }
            if (labelControlTalasliTl.Text.Trim() != "..... TL" && checkEditTalasli1.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlTalasliTl.Text.Substring(0, labelControlTalasliTl.Text.Length - 2).Trim());
            }
            if (labelControlTalasliCapTl.Text.Trim() != "..... TL" && checkEditTalasli2.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlTalasliCapTl.Text.Substring(0, labelControlTalasliCapTl.Text.Length - 2).Trim());
            }
            if (labelControlSomunTl.Text.Trim() != "..... TL" && checkEditSomunSikma.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlSomunTl.Text.Substring(0, labelControlSomunTl.Text.Length - 2).Trim());
            }
            if (labelControlDisTl.Text.Trim() != "..... TL" && checkEditDisAcmaHelicoil.Checked)
            {
                totalPrice += Convert.ToDecimal(labelControlDisTl.Text.Substring(0, labelControlDisTl.Text.Length - 2).Trim());
            }
            labelControlBirimIslemMaliyet.Text = totalPrice.ToString() + "TL";
            decimal parcaTeklif = 0m;
            if (labelControlBirimMaliyet.Text.Trim() != "")
            {
                parcaTeklif = (totalPrice + Convert.ToDecimal(labelControlBirimMaliyet.Text.Trim()));
            }
            //if (textEditAdet.Text.Trim() != "")
            //{
            //    parcaTeklif = parcaTeklif * Convert.ToDecimal(textEditAdet.Text.Trim());
            //}

            labelControlParcaTeklifFiyatı.Text = parcaTeklif.ToString() + " TL"; //ali
        }

        private void SimpleButtonParcaEkle_Click(object sender, EventArgs e)
        {
            OfferItem item = new OfferItem();
            if (checkEditLazer.Checked && Check(textEditKesimSuresi.Text))
            {
                item.LaserCuttingTime = int.Parse(textEditKesimSuresi.Text);
                item.LaserCuttingPrice = Convert.ToDecimal(labelControlLazerTl.Text.Substring(0, labelControlLazerTl.Text.Length - 2));
                item.LaserCuttingGain = int.Parse(textEditLazerKar.Text);
            }

            if (checkEditBukum.Checked && (Check(textEditBukumAdedi.Text) || Check(textEditBukumSuresi.Text)))
            {
                item.TwistGain = int.Parse(textEditBukumKar.Text);
                item.TwistCount = int.Parse(textEditBukumAdedi.Text);
                item.TwistTime = int.Parse(textEditBukumSuresi.Text);
                item.TwistPrice = Convert.ToDecimal(labelControlBukumTl.Text.Substring(0, labelControlBukumTl.Text.Length - 2));
            }

            if (checkEditKaynak.Checked && Check(textEditKaynakSuresi.Text))
            {
                item.WeldTime = int.Parse(textEditKaynakSuresi.Text);
                item.WeldGain = int.Parse(textEditKaynakKar.Text);
                item.WeldPrice = Convert.ToDecimal(labelControlKaynakTl.Text.Substring(0, labelControlKaynakTl.Text.Length - 2));
            }

            if (checkEditKaplama.Checked && Check(textEditKaplamaParcaAgirligi.Text) && Check(textEditKaplanacakMalzeme.Text))
            {
                item.CoveringValue = int.Parse(textEditKaplamaParcaAgirligi.Text);
                item.CoveringMaterialId = Lists.processes.Where(i => i.Name.Trim() == textEditKaplanacakMalzeme.Text.Trim()).SingleOrDefault().Id;
                item.CoveringGain = int.Parse(textEditKaplamaKar.Text);
                item.CoveringPrice = Convert.ToDecimal(labelControlKaplamaTl.Text.Substring(0, labelControlKaplamaTl.Text.Length - 2));
            }

            if (checkEditHavsaAcma.Checked && Check(textEditHavsaAdedi.Text))
            {
                item.CountersinkCount = int.Parse(textEditHavsaAdedi.Text);
                item.CountersinkGain = int.Parse(textEditHavsaAcmaKar.Text);
                item.CountersinkPrice = Convert.ToDecimal(labelControlHavsaTl.Text.Substring(0, labelControlHavsaTl.Text.Length - 2));
            }
            /*
                checkEditTalasli1.Enabled = true;
                checkEditTalasli2.Enabled = true;
                checkEditSomunSikma.Enabled = true;
                checkEditDisAcmaHelicoil.Enabled = true;*/
            if (checkEditMontaj.Checked && Check(textEditMontajIscilik.Text) && Check(textEditMontajToplamSet.Text))
            {
                item.AssemblyJobPrice = int.Parse(textEditMontajIscilik.Text);
                item.AssemblyTotalSetCount = int.Parse(textEditMontajToplamSet.Text);
                item.AssemblyGain = int.Parse(textEditMontajKar.Text);
                item.AssemblyPrice = Convert.ToDecimal(labelControlMontajTl.Text.Substring(0, labelControlMontajTl.Text.Length - 2));
            }

            if (checkEditMaskelemeBandi.Checked && Check(textEditMaskelemeIscilikSuresi.Text) && Check(textEditMaskelemeBantAlani.Text))
            {
                item.MaskingTapeArea = int.Parse(textEditMaskelemeBantAlani.Text);
                item.MaskingTapeJobPrice = Convert.ToDecimal(textEditMaskelemeIscilikSuresi.Text);
                item.MaskingTapeType = radioButtonEbatli.Checked;
                item.MaskingTapeGain = int.Parse(textEditMaskelemeKar.Text);
                item.MaskingTapePrice = Convert.ToDecimal(labelControlMaskelemeTl.Text.Substring(0, labelControlMaskelemeTl.Text.Length - 2));
            }

            if (checkEditBoya.Checked && Check(textEditBoyaParcaAlani.Text))
            {
                item.PaintArea = int.Parse(textEditBoyaParcaAlani.Text);
                item.PaintGain = int.Parse(textEditBoyaKar.Text);
                item.PaintPrice = Convert.ToDecimal(labelControlBoyaTl.Text.Substring(0, labelControlBoyaTl.Text.Length - 2));
            }

            if (checkEditTalasli1.Checked && Check(textEditTalasli1Adet.Text) && Check(textEditTalasli1Fiyat.Text))
            {
                item.MachiningOneCount = int.Parse(textEditTalasli1Adet.Text);
                item.MachiningOneJobPrice = Convert.ToDecimal(textEditTalasli1Fiyat.Text);
                item.MachiningOneGain = int.Parse(textEditTalasli1Kar.Text);
                item.MachiningOnePrice = Convert.ToDecimal(labelControlTalasliTl.Text.Substring(0, labelControlTalasliTl.Text.Length - 2));
            }

            if (checkEditTalasli2.Checked && Check(textEditTalasli2Adet.Text) && Check(textEditTalasli2Fiyat.Text) && Check(textEditTalasli2Boy.Text))
            {
                item.MachiningTwoCount = int.Parse(textEditTalasli2Adet.Text);
                item.MachiningTwoJobPrice = Convert.ToDecimal(textEditTalasli2Fiyat.Text);
                item.MachiningTwoGain = int.Parse(textEditTalasli2Kar.Text);
                item.MachiningTwoPrice = Convert.ToDecimal(labelControlTalasliCapTl.Text.Substring(0, labelControlTalasliCapTl.Text.Length - 2));
                item.MachiningTwoDiameter = int.Parse(textEditTalasli2Boy.Text);
            }

            if (checkEditSomunSikma.Checked && Check(textEditSomunSikmaIscilik.Text) && Check(textEditSomunSikmaSetAdedi.Text) && Check(textEditSomunSikmaToplamSet.Text))
            {
                item.TighteningJobPrice = Convert.ToDecimal(textEditSomunSikmaIscilik.Text);
                item.TighteningSetCount = int.Parse(textEditSomunSikmaSetAdedi.Text);
                item.TighteningTotalSet = int.Parse(textEditSomunSikmaToplamSet.Text);
                item.TighteningGain = int.Parse(textEditSomunSikmaKar.Text);
                item.TighteningPrice = Convert.ToDecimal(labelControlSomunTl.Text.Substring(0, labelControlSomunTl.Text.Length - 2));
            }

            if (checkEditDisAcmaHelicoil.Checked)
            {
                item.IndentionCount = int.Parse(textEditDisAdedi.Text);
                item.IndentionDimensions = int.Parse(textEditDisEbadi.Text);
                item.HelicoilCount = int.Parse(textEditHelicoilAdet.Text);
                item.HelicoilJobPrice = Convert.ToDecimal(textEditHelicoilFiyat.Text);
                item.IndentionHelicoilGain = int.Parse(textEditDisAcmaKar.Text);
                item.IndentionHelicoilPrice = Convert.ToDecimal(labelControlDisTl.Text.Substring(0, labelControlDisTl.Text.Length - 2));
            }

            item.PieceId = Lists.pieces.Where(i => i.Code.Trim() == comboBoxEditParcaKodu.Text.Trim()).SingleOrDefault().Id;
            item.OfferId = -1;
            item.TotalCount = int.Parse(textEditAdet.Text);
            item.TotalPrice = Convert.ToDecimal(labelControlParcaTeklifFiyatı.Text.Substring(0, labelControlParcaTeklifFiyatı.Text.Length - 2));
            item.UnitPrice = Convert.ToDecimal(labelControlBirimIslemMaliyet.Text.Substring(0, labelControlBirimIslemMaliyet.Text.Length - 2)) + Convert.ToDecimal(labelControlBirimMaliyet.Text.Substring(0, labelControlBirimMaliyet.Text.Length - 2));

            listView2.Items.Add(GetListViewItem(item));
            offerItems.Add(item);
            ResetAll();
            CalculateProject();
        }

        private ListViewItem GetListViewItem(OfferItem item)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = offerItems.Count.ToString();
            lvItem.SubItems.Add(item.PieceId.ToString());
            lvItem.SubItems.Add(GetItem(item.LaserCuttingPrice));
            lvItem.SubItems.Add(GetItem(item.TwistPrice));
            lvItem.SubItems.Add(GetItem(item.WeldPrice));
            lvItem.SubItems.Add(GetItem(item.CoveringPrice));
            lvItem.SubItems.Add(GetItem(item.CountersinkPrice));
            lvItem.SubItems.Add(GetItem(item.IndentionHelicoilPrice));
            lvItem.SubItems.Add(GetItem(item.MaskingTapePrice));
            lvItem.SubItems.Add(GetItem(item.PaintPrice));
            lvItem.SubItems.Add(GetItem(item.MachiningOnePrice));
            lvItem.SubItems.Add(GetItem(item.MachiningTwoPrice));
            lvItem.SubItems.Add(GetItem(item.TighteningPrice));
            lvItem.SubItems.Add(GetItem(item.AssemblyPrice));
            lvItem.SubItems.Add(GetItem(item.TotalPrice));
            lvItem.SubItems.Add(GetItem(item.UnitPrice));
            return lvItem;
        }

        private void CalculateProject()
        {
            foreach (var item in offerItems)
            {
                generalPrice = generalPrice + item.TotalPrice;
                var pieceTemp = Lists.pieces.Where(i => i.Id == item.PieceId).SingleOrDefault();
                var material = Lists.materials.Where(i => i.Name.Trim() == pieceTemp.Quality.Trim()).SingleOrDefault();
                decimal weight = ((decimal)(((decimal)pieceTemp.Height * (decimal)pieceTemp.Width * 0.8m * (decimal)pieceTemp.Thickness) / 100000m));
                totalPieceCost = totalPieceCost + (pieceTemp.WasteRate * weight * material.Price * item.TotalCount);
            }
            labelControl26.Text = totalPieceCost.ToString() + " TL";
            labelControl29.Text = generalPrice.ToString() + " TL";
            totalPrice = generalPrice;
            totalPrice = (totalPrice * (100 + int.Parse(textEditKarOran.Text))) / 100;
            totalPrice = totalPrice - ((totalPrice * int.Parse(textEditIndirimOran.Text)) / 100);
            labelControl32.Text = totalPrice.ToString() + " TL";
        }

        private string GetItem(object item)
        {
            if (item != null)
            {
                return item.ToString() + " TL";
            }
            return "";
        }

        private void ResetAll()
        {
            //malzeme bilgileri
            comboBoxEditParcaKodu.Text = "";
            textEditParcaAdi.Text = "";
            textEditAdet.Text = "";
            labelControlEn.Text = "";
            labelControlBoy.Text = "";
            labelControlKalinlik.Text = "";
            labelControlKalite.Text = "";
            labelControlFireOrani.Text = "";
            labelControlAlan.Text = "";
            labelControlAgirligi.Text = "";
            labelControlMaliyet.Text = "";

            //Yapılacak İşlemler
            checkEditLazer.Checked = false;
            checkEditBukum.Checked = false;
            checkEditKaynak.Checked = false;
            checkEditKaplama.Checked = false;
            checkEditHavsaAcma.Checked = false;
            checkEditMontaj.Checked = false;
            checkEditMaskelemeBandi.Checked = false;
            checkEditBoya.Checked = false;
            checkEditTalasli1.Checked = false;
            checkEditTalasli2.Checked = false;
            checkEditSomunSikma.Checked = false;
            checkEditDisAcmaHelicoil.Checked = false;


            //Parça Teklifi
            labelControlBirimMaliyet.Text = "";
            labelControlBirimIslemMaliyet.Text = "";
            labelControlParcaTeklifFiyatı.Text = "";
           

            //İslemler
            groupBoxLazer.Visible = false;
            groupBoxBukum.Visible = false;
            groupBoxKaynak.Visible = false;
            groupBoxKaplama.Visible = false;
            groupBoxHavsa.Visible = false;
            groupBoxMontaj.Visible = false;
            groupBoxMaske.Visible = false;
            groupBoxBoya.Visible = false;
            groupBoxT1.Visible = false;
            groupBoxT2.Visible = false;
            groupBoxSomun.Visible = false;
            groupBoxDis.Visible = false;
            textEditKesimSuresi.Text = "";
            textEditLazerKar.Text = "";
            labelControlLazerTl.Text = "..... TL";
            textEditBukumSuresi.Text = "";
            textEditBukumAdedi.Text = "";
            textEditBukumKar.Text = "0";
            labelControlBukumTl.Text = "..... TL";
            textEditKaynakSuresi.Text = "";
            textEditKaynakKar.Text = "0";
            labelControlKaynakTl.Text = "..... TL";
            textEditKaplanacakMalzeme.Text = "";
            textEditKaplamaParcaAgirligi.Text = "";
            textEditKaplamaKar.Text = "0";
            labelControlKaplamaTl.Text = "..... TL";
            radioButtonEbatli.Checked = true;
            textEditMaskelemeIscilikSuresi.Text = "";
            textEditMaskelemeBantAlani.Text = "";
            textEditMaskelemeKar.Text = "0";
            labelControlMaskelemeTl.Text = "..... TL";
            textEditBoyaParcaAlani.Text = "";
            textEditBoyaKar.Text = "0";
            labelControlBoyaTl.Text = "..... TL";
            textEditTalasli1Adet.Text = "";
            textEditTalasli1Fiyat.Text = "";
            textEditTalasli1Kar.Text = "0";
            labelControlTalasliTl.Text = "..... TL";
            textEditTalasli2Adet.Text = "";
            textEditTalasli2Boy.Text = "";
            textEditTalasli2Fiyat.Text = "";
            textEditTalasli2Kar.Text = "0";
            labelControlTalasliCapTl.Text = "..... TL";
            textEditHavsaAdedi.Text = "";
            textEditHavsaAcmaKar.Text = "0";
            labelControlHavsaTl.Text = "..... TL";
            textEditMontajIscilik.Text = "";
            textEditMontajToplamSet.Text = "";
            textEditMontajKar.Text = "0";
            labelControlMontajTl.Text = "..... TL";
            textEditSomunSikmaIscilik.Text = "";
            textEditSomunSikmaSetAdedi.Text = "";
            textEditSomunSikmaToplamSet.Text = "";
            textEditSomunSikmaKar.Text = "0";
            labelControlSomunTl.Text = "..... TL";
            textEditDisAdedi.Text = "";
            textEditDisEbadi.Text = "";
            textEditHelicoilAdet.Text = "";
            textEditHelicoilFiyat.Text = "";
            textEditDisAcmaKar.Text = "0";
            labelControlDisTl.Text = "..... TL";
        }

        private bool Check(string value)
        {
            int result = 0;
            if (!int.TryParse(value, out result))
            {
                return false;
            }
            if (value != null || value.Trim() != "" || value.Trim() != "0")
            {
                return true;
            }

            return false;
        }

        private void TextEditKarOran_TextChanged(object sender, EventArgs e)
        {
            if (textEditKarOran.Text.Trim() == "")
            {
                return;
            }
            totalPrice = generalPrice * ((100 + int.Parse(textEditKarOran.Text)) / 100);
            totalPrice = generalPrice - generalPrice * ((int.Parse(textEditIndirimOran.Text)) / 100);
            labelControl32.Text = totalPrice.ToString() + "TL";
        }

        private void TextEditIndirimOran_TextChanged(object sender, EventArgs e)
        {
            if (textEditIndirimOran.Text.Trim() == "")
            {
                return;
            }
            totalPrice = generalPrice * ((100 + int.Parse(textEditKarOran.Text)) / 100);
            totalPrice = generalPrice - generalPrice * ((int.Parse(textEditIndirimOran.Text)) / 100);
            labelControl32.Text = totalPrice.ToString() + "TL";
        }

        private void SimpleButtonSonTeklifVer_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(textEdit1.Text) < generalPrice)
            {
                MessageBox.Show("Minimum değerden daha aşağı teklif veremezsiniz.");
                return;
            }

            Offer offer = new Offer()
            {
                Id = -1,
                DiscountPercentage = Convert.ToSingle(textEditIndirimOran.Text),
                LastPrice = Convert.ToDecimal(textEdit1.Text),
                OfferPrice = generalPrice,
                ProfitPercentage = Convert.ToSingle(textEditKarOran.Text),
                ProjectId = project.Id,
                ProjectPreparation = "",
                UnitPrice = Convert.ToDecimal(labelControl26.Text.Substring(0, labelControl26.Text.Length - 2)),
            };

            TotalOffer totalOffer = new TotalOffer() { Offer = offer, OfferItems = offerItems };
            List<string> data = new List<string>();
            data.Add(OPCodes.TOTAL_OFFER);
            data.Add(JsonConvert.SerializeObject(totalOffer));
            WebSocketService.getInstance().Send(data);
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in listView2.SelectedItems)
            //{
            //    if (listView2.SelectedItems[0] != null)
            //    {
            //        if (listView2.SelectedItems[0].SubItems[2].Text != "")
            //        {
            //            checkEditLazer.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[3].Text != "")
            //        {
            //            checkEditBukum.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[4].Text != "")
            //        {
            //            checkEditKaynak.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[5].Text != "")
            //        {
            //            checkEditKaplama.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[6].Text != "")
            //        {
            //            checkEditHavsaAcma.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[7].Text != "")
            //        {
            //            checkEditDisAcmaHelicoil.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[8].Text != "")
            //        {
            //            checkEditMaskelemeBandi.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[9].Text != "")
            //        {
            //            checkEditBoya.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[10].Text != "")
            //        {
            //            checkEditTalasli1.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[11].Text != "")
            //        {
            //            checkEditTalasli2.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[12].Text != "")
            //        {
            //            checkEditSomunSikma.Checked = true;
            //        }
            //        if (listView2.SelectedItems[0].SubItems[13].Text != "")
            //        {
            //            checkEditMontaj.Checked = true;
            //        }
            //    }
            //    else
            //    {
            //        ResetAll();
            //    }
            //}
        }
    }
}
