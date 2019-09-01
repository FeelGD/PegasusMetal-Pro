using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
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
    public partial class frmVerilerStok : Form
    {
        public frmVerilerStok()
        {
            InitializeComponent();
            //Lists.stocks.Clear();
            Lists.stocks.CollectionChanged += StockCollectionChanged;
            //List<string> data = new List<string>();
            //data.Add(OPCodes.GET_STOCK_CATEGORIES);
            //WebSocketService.getInstance().Send(data);
            //Lists.stockCategories.Clear();
            Lists.stockCategories.CollectionChanged += StockCategoryCollectionChanged;
            //data.Clear();
            //data.Add(OPCodes.GET_STOCKS);
            //WebSocketService.getInstance().Send(data);
            StockCollectionChanged(null,null);
            StockCategoryCollectionChanged(null,null);
        }

        private void StockCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.stocks.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), Lists.stockCategories.Where(i=>i.Id == item.CategoryId).SingleOrDefault().Name, item.Name, item.Amount.ToString(), item.Price.ToString() };
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Amount);
                ListViewItem listViewItem = new ListViewItem(array);
                if (item.Id < listView1.Items.Count)
                {
                    listView1.Items.Insert(item.Id, listViewItem);
                }
                else
                {
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void StockCategoryCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.stockCategories.Where(s => !SearchInComboBox(s.Name.ToString())))
            {
                textEditKategori.Properties.Items.Add(item.Name);
            }
        }

        private bool SearchInListView(string Id)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private bool SearchInComboBox(string Id)
        {
            foreach (string item in textEditKategori.Properties.Items)
            {
                if (item.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "")
            {
                Stock stock = new Stock
                {
                    Id = int.Parse(textEditId.Text),
                    Name = textEditUrunAdi.Text,
                    Amount = int.Parse(textEditMiktar.Text),
                    Price = Convert.ToDecimal(textEditFiyat.Text),
                    CategoryId = Lists.stockCategories.Where(i => i.Name.Equals(textEditKategori.Text)).SingleOrDefault().Id
                };
                listView1.SelectedItems[0].SubItems[1].Text = textEditKategori.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textEditUrunAdi.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textEditFiyat.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textEditMiktar.Text;
                List<string> data = new List<string>();
                data.Add(OPCodes.STOCK);
                data.Add(JsonConvert.SerializeObject(stock));
                WebSocketService.getInstance().Send(data);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Veri Bırakmayınız");
            }
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock
            {
                Id = -1,
                Name = textEditUrunAdi.Text,
                Amount = int.Parse(textEditMiktar.Text),
                Price = Convert.ToDecimal(textEditFiyat.Text),
                CategoryId = Lists.stockCategories.Where(i => i.Name.Equals(textEditKategori.Text)).SingleOrDefault().Id
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.STOCK);
            data.Add(JsonConvert.SerializeObject(stock));
            WebSocketService.getInstance().Send(data);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SimpleButtonArttir_Click(object sender, EventArgs e)
        {
            StockCategory stockCategory = new StockCategory
            {
                Id = -1,
                Name = textEditUrunAdiGoruntule.Text,
                CreatedAt = null,
                CreatedBy = Info.GetInstance().staff.Id
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.STOCK_CATEGORY);
            data.Add(JsonConvert.SerializeObject(stockCategory));
            WebSocketService.getInstance().Send(data);
            textEditUrunAdiGoruntule.Text = "";
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                textEditId.Text = item.SubItems[0].Text;
                textEditKategori.Text = item.SubItems[1].Text;
                textEditUrunAdi.Text = item.SubItems[2].Text;
                textEditMiktar.Text = item.SubItems[3].Text;
                textEditFiyat.Text = item.SubItems[4].Text;
            }
            
        }

        private void FrmVerilerStok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lists.stocks.CollectionChanged -= StockCollectionChanged;
            Lists.stockCategories.CollectionChanged -= StockCategoryCollectionChanged;
        }
    }
}
