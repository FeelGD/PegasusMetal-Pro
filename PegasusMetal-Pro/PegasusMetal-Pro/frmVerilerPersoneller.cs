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
    public partial class frmVerilerPersoneller : Form
    {
        public frmVerilerPersoneller()
        {
            InitializeComponent();
            Lists.staffs.Clear();
            Lists.staffs.CollectionChanged += CollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_PERSONAL_LIST);
            WebSocketService.getInstance().Send(data);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach(var item in Lists.staffs.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, item.Surname, item.Job, item.MailAddress, item.PhoneNumber };
                ListViewItem listViewItem = new ListViewItem(array);
                if(item.Id<listView1.Items.Count)
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
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.Text.Trim().Equals(Id.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lists.staffs.CollectionChanged += null;
            this.Close();
        }
        private void RefreshBoxes()
        {
            textEditId.Text = "";
            textEditAd.Text = "";
            textEditSoyad.Text = "";
            textEditMail.Text = "";
            textEditGorevi.Text = "";
            textEditTel.Text = "";
        }

        private void SimpleButtonKaydet_Click(object sender, EventArgs e)
        {
            //TODO : ADD
            Staff staff = new Staff {
                Id = -1,
                Name = textEditAd.Text,
                Surname = textEditSoyad.Text,
                MailAddress = textEditMail.Text,
                PhoneNumber = textEditTel.Text,
                Address = "ses",
                Job = textEditGorevi.Text
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.STAFF);
            data.Add(JsonConvert.SerializeObject(staff));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
        }
        //SimpleButtonGuncelle_Click
        private void SimpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "")
            {

            
            //TODO : Guncelle
            Staff staff = new Staff
            {
                Id = int.Parse(textEditId.Text),
                Name = textEditAd.Text,
                Surname = textEditSoyad.Text,
                MailAddress = textEditMail.Text,
                PhoneNumber = textEditTel.Text,
                Address = "ses",
                Job = textEditGorevi.Text
            };
            listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text = textEditId.Text;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = textEditAd.Text;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text = textEditSoyad.Text;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text = textEditGorevi.Text;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text = textEditMail.Text;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[5].Text = textEditTel.Text;
            foreach (var item in Lists.staffs.ToList())
            {
                if(item.Id == int.Parse(textEditId.Text))
                {
                    Lists.staffs.Remove(item);
                }
            }
            List<string> data = new List<string>();
            data.Add(OPCodes.STAFF);
            data.Add(JsonConvert.SerializeObject(staff));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İçin Bir Kullanıcı Seçiniz");
            }
        }
        //SimpleButtonSil_Click
        private void SimpleButtonSil_Click(object sender, EventArgs e)
        {
            if (textEditId.Text != "") {     
            //TODO : Sil
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                foreach(var listItem in Lists.staffs.ToList())
                {
                    if(listItem.Id.Equals(int.Parse(textEditId.Text)))
                    {
                        Lists.staffs.Remove(listItem);
                        break;
                    }
                }
                List<string> data = new List<string>();
                data.Add(OPCodes.DELETE_STAFF);
                data.Add(textEditId.Text);
                WebSocketService.getInstance().Send(data);
                RefreshBoxes();
            }
        }
            else
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Kullanıcı Seçiniz");
            }
}


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(int item in listView1.SelectedIndices)
            {
                textEditId.Text = listView1.Items[item].SubItems[0].Text;
                textEditAd.Text = listView1.Items[item].SubItems[1].Text;
                textEditSoyad.Text = listView1.Items[item].SubItems[2].Text;
                textEditMail.Text = listView1.Items[item].SubItems[4].Text;//3
                textEditTel.Text = listView1.Items[item].SubItems[5].Text;//4
                textEditGorevi.Text = listView1.Items[item].SubItems[3].Text;//2
            }
        }
    }
}
