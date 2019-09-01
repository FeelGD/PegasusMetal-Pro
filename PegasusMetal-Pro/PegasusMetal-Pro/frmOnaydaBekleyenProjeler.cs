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
    public partial class frmOnaydaBekleyenProjeler : Form
    {
        private delegate void AddDelegate(object item);
        private delegate void InsertDelegate(int index, object item);
        public frmOnaydaBekleyenProjeler()
        {
            InitializeComponent();
            //Lists.acceptedOffers.Clear();
            Lists.acceptedOffers.CollectionChanged += CollectionChanged;
            //List<string> data = new List<string>();
            //data.Clear();
            //data.Add(OPCodes.GET_OFFERS);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_OFFER_ITEMS);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_PROJECTS);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_COMPANIES);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_PERSONAL_LIST);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_ACCEPTED_OFFERS);
            //WebSocketService.getInstance().Send(data);
            CollectionChanged(null,null);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.acceptedOffers.Where(s => !SearchInListView2(GetProject(s.OfferId).Id.ToString()) && Lists.projectContinuings.Where(p=>p.ProjectId == GetProject(s.OfferId).Id).ToList().Count == 0))
            {
                AddListView(GetListViewItem(item));
            }
        }

        private Project GetProject(int offerId)
        {
            var tempOffer = Lists.offers.Where(o => o.Id == offerId).FirstOrDefault();
            return Lists.projects.Where(p => p.Id == tempOffer.ProjectId).FirstOrDefault();
        }

        private ListViewItem GetListViewItem(AcceptedOffer item)
        {
            ListViewItem lvItem = new ListViewItem();
            Project project = GetProject(item.OfferId);
            lvItem.Text = project.Id.ToString();
            lvItem.SubItems.Add(project.Name);
            lvItem.SubItems.Add(Lists.companies.Where(c => c.Id == project.CompanyId).FirstOrDefault().Name);
            lvItem.SubItems.Add(Lists.staffs.Where(s => s.Id == item.StaffId).FirstOrDefault().Name + " " + Lists.staffs.Where(s => s.Id == item.StaffId).FirstOrDefault().Surname);
            lvItem.SubItems.Add(item.Deadline.ToShortDateString());
            return lvItem;
        }

        private bool SearchInListView2(string Id)
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

        private void AddListView(object item)
        {
            if (listView1.InvokeRequired)
            {
                var d = new AddDelegate(AddListView);
                Invoke(d, new object[] { item });
            }
            else
            {
                listView1.Items.Add((ListViewItem)item);
            }
        }

        private void InsertListView(int index, object item)
        {
            if (listView1.InvokeRequired)
            {
                var d = new InsertDelegate(InsertListView);
                Invoke(d, new object[] { index, item });
            }
            else
            {
                listView1.Items.Insert(index, (ListViewItem)item);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SearchInAcceptedOffers(int offerId)
        {
            var d = Lists.acceptedOffers.Where(a => a.OfferId == offerId).FirstOrDefault();
            return d == null ? false : true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count<=0)
            {
                return;
            }
            Project project = Lists.projects.Where(p => p.Id == int.Parse(listView1.SelectedItems[0].Text.Trim())).FirstOrDefault();
            Offer offer = Lists.offers.Where(o => o.ProjectId == project.Id && SearchInAcceptedOffers(o.Id)).FirstOrDefault();
            AcceptedOffer acceptedOffer = Lists.acceptedOffers.Where(a => a.OfferId == offer.Id).FirstOrDefault();
            frmSipariseBasla sipariseBasla = new frmSipariseBasla(offer,acceptedOffer);
            sipariseBasla.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
