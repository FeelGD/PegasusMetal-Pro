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
    public partial class frmVerilerMalzemeUcretleri : Form
    {
        public frmVerilerMalzemeUcretleri()
        {
            InitializeComponent();
            //Lists.materials.Clear();
            Lists.materials.CollectionChanged += CollectionChanged;
            //List<string> data = new List<string>();
            //data.Add(OPCodes.GET_MATERIALS);
            //WebSocketService.getInstance().Send(data);
            CollectionChanged(null,null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.materials.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, item.Price.ToString() };
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

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "")
            {
                Material material = new Material
                {
                    Id = int.Parse(textEditId.Text),
                    Name = textEditMalzemeOzelligi.Text,
                    Price = Convert.ToDecimal(textEditBirimFiyat.Text)
                };
                listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text = textEditId.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = textEditMalzemeOzelligi.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = textEditBirimFiyat.Text;
                foreach (var item in Lists.materials.ToList())
                {
                    if (item.Id == int.Parse(textEditId.Text))
                    {
                        Lists.materials.Remove(item);
                    }
                }
                List<string> data = new List<string>();
                data.Add(OPCodes.MATERIAL);
                data.Add(JsonConvert.SerializeObject(material));
                WebSocketService.getInstance().Send(data);
                textEditId.Text = "";
                textEditBirimFiyat.Text = "";
                textEditMalzemeOzelligi.Text = "";
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

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                textEditId.Text = item.SubItems[0].Text;
                textEditMalzemeOzelligi.Text = item.SubItems[1].Text;
                textEditBirimFiyat.Text = item.SubItems[2].Text;
            }
        }

        private void FrmVerilerMalzemeUcretleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lists.materials.CollectionChanged -= CollectionChanged;
        }
    }
}
