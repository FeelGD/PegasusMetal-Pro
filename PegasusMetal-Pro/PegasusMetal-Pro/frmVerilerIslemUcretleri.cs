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
    public partial class frmVerilerIslemUcretleri : Form
    {
        public frmVerilerIslemUcretleri()
        {
            InitializeComponent();
            Lists.processes.Clear();
            Lists.processes.CollectionChanged += CollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_PROCESSES);
            WebSocketService.getInstance().Send(data);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.processes.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, item.Property, item.UnitPrice.ToString(),item.MinutePrice.ToString() };
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                textEditId.Text = item.SubItems[0].Text;
                textEditIslemAdi.Text = item.SubItems[1].Text;
                textEditMalzemeOzelligi.Text = item.SubItems[2].Text;
                textEditBirimFiyati.Text = item.SubItems[3].Text;
                textEditDakikaFiyati.Text = item.SubItems[4].Text;
            }
        }

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "")
            {
                //TODO : Guncelle
                Process process = new Process()
                {
                    Id = int.Parse(textEditId.Text),
                    Name = textEditIslemAdi.Text,
                    Property = textEditMalzemeOzelligi.Text,
                    UnitPrice = Convert.ToDecimal(textEditBirimFiyati.Text),
                    MinutePrice = Convert.ToDecimal(textEditDakikaFiyati.Text)
                };
                listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text = textEditId.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = textEditIslemAdi.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = textEditMalzemeOzelligi.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text = textEditBirimFiyati.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text = textEditDakikaFiyati.Text;
                foreach (var item in Lists.processes.ToList())
                {
                    if (item.Id == int.Parse(textEditId.Text))
                    {
                        Lists.processes.Remove(item);
                    }
                }
                List<string> data = new List<string>();
                data.Add(OPCodes.PROCESS);
                data.Add(JsonConvert.SerializeObject(process));
                WebSocketService.getInstance().Send(data);
                RefreshBoxes();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Veri Bırakmayınız");
            }
        }

        private void RefreshBoxes()
        {
            textEditId.Text = "";
            textEditDakikaFiyati.Text = "";
            textEditBirimFiyati.Text = "";
            textEditIslemAdi.Text = "";
            textEditMalzemeOzelligi.Text = "";
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Process process = new Process()
            {
                Id = -1,
                Name = textEditIslemAdi.Text,
                Property = textEditMalzemeOzelligi.Text,
                UnitPrice = Convert.ToDecimal(textEditBirimFiyati.Text),
                MinutePrice = Convert.ToDecimal(textEditDakikaFiyati.Text)
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.PROCESS);
            data.Add(JsonConvert.SerializeObject(process));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
        }
    }
}
