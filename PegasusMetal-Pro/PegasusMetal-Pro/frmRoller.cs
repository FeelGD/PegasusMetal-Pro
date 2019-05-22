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
    public partial class frmRoller : Form
    {
        public frmRoller()
        {
            InitializeComponent();
            Lists.staffs.Clear();
            Lists.staffs.CollectionChanged += CollectionChanged;
            Lists.roles.CollectionChanged += RolesCollectionChanged;
            Lists.users.CollectionChanged += UsersCollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_PERSONAL_LIST);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_ROLE_LIST);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_USER_LIST);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_USER_ROLE_LIST);
            WebSocketService.getInstance().Send(data);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.staffs.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, item.Surname, "","" };
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

        private void UpdateCheckedListBox()
        {
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            foreach (var item in Lists.userRoles.Where(r => r.StaffId == int.Parse(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text)).ToList())
            {
                checkedListBox1.SetItemChecked(item.RoleId, true);
            }
        }
        private void RolesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.roles.Where(s => !SearchInCheckedListBox(s.Explanation.ToString())))
            {
                checkedListBox1.Items.Add(item.Explanation,false);
            }
        }
        //will design again.
        private void UserRolesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach(var item in Lists.userRoles)
            {
                if (listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text.Equals(item.StaffId.ToString()))
                {
                    UpdateCheckedListBox();
                }
            }
        }

        private void UsersCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach(var item in Lists.users)
            {
                foreach(ListViewItem item2 in listView1.Items)
                {
                    if(item.StaffId.Equals(int.Parse(item2.SubItems[0].Text)))
                    {
                        item2.SubItems[3].Text = item.Username;
                        item2.SubItems[4].Text = item.Password;
                        break;
                    }
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

        private bool SearchInCheckedListBox(string explanation)
        {
            foreach (var item in checkedListBox1.Items)
            {
                if (((string)item).Trim().Equals(explanation.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lists.staffs.CollectionChanged += null;
            Lists.roles.CollectionChanged += null;
            Lists.users.CollectionChanged += null;
            this.Close();
        }

        private void SimpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                StaffId = int.Parse(textEditId.Text),
                Username = textEditAd.Text,
                Password = textEditSoyad.Text
            };
            List<string> userData = new List<string>();
            userData.Add(OPCodes.USER);
            userData.Add(JsonConvert.SerializeObject(user));
            WebSocketService.getInstance().Send(userData);
            for (int i = 0;i<checkedListBox1.Items.Count;i++)
            {
                listView1.SelectedItems[0].SubItems[3].Text = textEditAd.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textEditSoyad.Text;
                if (checkedListBox1.GetItemChecked(i) && !SearchInUserRoles(int.Parse(listView1.SelectedItems[0].SubItems[0].Text),i))
                {
                    UserRole role = new UserRole()
                    {
                        Id = -1,
                        RoleId = i,
                        StaffId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text)
                    };
                    List<string> data = new List<string>();
                    data.Add(OPCodes.USER_ROLE);
                    data.Add(JsonConvert.SerializeObject(role));
                    WebSocketService.getInstance().Send(data);
                }

                if (!checkedListBox1.GetItemChecked(i) && SearchInUserRoles(int.Parse(listView1.SelectedItems[0].SubItems[0].Text), i))
                {
                    List<string> data = new List<string>();
                    data.Add(OPCodes.DELETE_USER_ROLE);
                    data.Add(Lists.userRoles.Where(item=>item.StaffId == int.Parse(listView1.SelectedItems[0].SubItems[0].Text)&&item.RoleId==i).SingleOrDefault().Id.ToString());
                    WebSocketService.getInstance().Send(data);
                    Lists.userRoles.Remove(Lists.userRoles.Where(item => item.StaffId == int.Parse(listView1.SelectedItems[0].SubItems[0].Text) && item.RoleId == i).SingleOrDefault());
                }
            }
        }

        private bool SearchInUserRoles(int staffId,int roleId)
        {
            return Lists.userRoles.Where(i => i.StaffId == staffId && i.RoleId==roleId).SingleOrDefault() != null;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                textEditId.Text = item.SubItems[0].Text;
                textEditAd.Text = item.SubItems[3].Text;
                textEditSoyad.Text = item.SubItems[4].Text;
                UpdateCheckedListBox();
            }
        }
    }
}
