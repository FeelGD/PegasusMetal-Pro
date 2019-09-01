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
    public partial class frmVerilerFirmalar : Form
    {
        public frmVerilerFirmalar()
        {
            InitializeComponent();
            //Lists.companies.Clear();
            Lists.companies.CollectionChanged += CollectionChanged;
            //List<string> data = new List<string>();
            //data.Add(OPCodes.GET_COMPANIES);
            //WebSocketService.getInstance().Send(data);
            CollectionChanged(null,null);
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

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.companies.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, item.Code, item.TaxNumber, item.TaxOffice, item.MailAddress,item.Address };
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshBoxes()
        {
            textEditId.Text = "";
            textEditFirmaIsmi.Text = "";
            textEditAdres.Text = "";
            textEditFirmaKodu.Text = "";
            textEditMail.Text = "";
            textEditVergiDairesi.Text = "";
            textEditVergiNo.Text = "";
        }

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text!="")
            {
                Company company = new Company
                {
                    Id = int.Parse(textEditId.Text),
                    Name = textEditFirmaIsmi.Text,
                    Address = textEditAdres.Text,
                    MailAddress = textEditMail.Text,
                    Code = textEditFirmaKodu.Text,
                    Note = "",
                    TaxNumber = textEditVergiNo.Text,
                    TaxOffice = textEditVergiDairesi.Text
                };
                var item = listView1.SelectedItems[0];

                item.SubItems[0].Text= textEditId.Text;
                item.SubItems[1].Text= textEditFirmaIsmi.Text;
                item.SubItems[2].Text= textEditFirmaKodu.Text;
                item.SubItems[3].Text = textEditVergiNo.Text;
                item.SubItems[4].Text = textEditVergiDairesi.Text;
                item.SubItems[5].Text = textEditMail.Text;
                item.SubItems[6].Text = textEditAdres.Text;
                List<string> data = new List<string>();
                data.Add(OPCodes.COMPANY);
                data.Add(JsonConvert.SerializeObject(company));
                WebSocketService.getInstance().Send(data);
                RefreshBoxes();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Veri Bırakmayınız");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SimpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Company company = new Company
            {
                Id = -1,
                Name = textEditFirmaIsmi.Text,
                Address = textEditAdres.Text,
                MailAddress = textEditMail.Text,
                Code = textEditFirmaKodu.Text,
                Note = "",
                TaxNumber = textEditVergiNo.Text,
                TaxOffice = textEditVergiDairesi.Text
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.COMPANY);
            data.Add(JsonConvert.SerializeObject(company));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                textEditId.Text = item.SubItems[0].Text;
                textEditFirmaIsmi.Text = item.SubItems[1].Text;
                textEditFirmaKodu.Text = item.SubItems[2].Text;
                textEditVergiNo.Text = item.SubItems[3].Text;
                textEditVergiDairesi.Text = item.SubItems[4].Text;
                textEditMail.Text = item.SubItems[5].Text;
                textEditAdres.Text = item.SubItems[6].Text;
            }
        }

        private void FrmVerilerFirmalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lists.companies.CollectionChanged -= CollectionChanged;
        }
    }
}
