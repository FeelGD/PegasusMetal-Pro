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
    public partial class frmVerilerParcaKodlari : Form
    {
        public frmVerilerParcaKodlari()
        {
            InitializeComponent();
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
                string[] array = { item.Id.ToString(), item.Code, item.Name, item.Quality, item.Width.ToString(), item.Height.ToString(), item.Thickness.ToString(), item.Type,item.WasteRate.ToString(), item.PMCode.ToString() };
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

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "")
            {
                //TODO : Guncelle
                Piece piece = new Piece
                {
                    Id = int.Parse(textEdit9.Text),
                    Name = textEdit1.Text,
                    Code = textEditId.Text,
                    Quality = textEdit2.Text,
                    Height = int.Parse(textEdit3.Text),
                    Width = int.Parse(textEdit4.Text),
                    Thickness = Convert.ToDecimal(textEdit6.Text),
                    WasteRate = Convert.ToDecimal(textEdit7.Text),
                    PMCode = int.Parse(textEdit8.Text)
                };
                listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text = textEdit9.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = textEditId.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = textEdit1.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text = textEdit2.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text = textEdit4.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[5].Text = textEdit3.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[6].Text = textEdit6.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[7].Text = textEdit7.Text;
                listView1.Items[listView1.SelectedIndices[0]].SubItems[8].Text = textEdit8.Text;
                foreach (var item in Lists.pieces.ToList())
                {
                    if (item.Id == int.Parse(textEdit9.Text))
                    {
                        Lists.pieces.Remove(item);
                    }
                }
                List<string> data = new List<string>();
                data.Add(OPCodes.PIECE);
                data.Add(JsonConvert.SerializeObject(piece));
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
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit6.Text = "";
            textEdit7.Text = "";
            textEdit8.Text = "";
            textEdit9.Text = "";
            textEditId.Text = "";
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Piece piece = new Piece
            {
                Id = -1,
                Name = textEdit1.Text,
                Code = textEditId.Text,
                Quality = textEdit2.Text,
                Height = int.Parse(textEdit3.Text),
                Width = int.Parse(textEdit4.Text),
                Thickness = Convert.ToDecimal(textEdit6.Text),
                WasteRate = Convert.ToDecimal(textEdit7.Text),
                PMCode = -1
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.PIECE);
            data.Add(JsonConvert.SerializeObject(piece));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                textEdit9.Text = item.SubItems[0].Text;
                textEditId.Text = item.SubItems[1].Text;
                textEdit1.Text = item.SubItems[2].Text;
                textEdit2.Text = item.SubItems[3].Text;
                textEdit4.Text = item.SubItems[4].Text;
                textEdit3.Text = item.SubItems[5].Text;
                textEdit6.Text = item.SubItems[6].Text;
                textEdit7.Text = item.SubItems[8].Text;
                textEdit8.Text = item.SubItems[9].Text;
            }
        }
    }
}
