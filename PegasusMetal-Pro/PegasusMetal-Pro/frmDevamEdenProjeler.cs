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
    public partial class frmDevamEdenProjeler : Form
    {
        private delegate void AddDelegate(object item);
        public frmDevamEdenProjeler()
        {
            InitializeComponent();
            Lists.projectContinuings.Clear();
            Lists.projectContinuings.CollectionChanged += CollectionChanged;
            List<string> data = new List<string>();
            data.Clear();
            data.Add(OPCodes.GET_OFFERS);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_OFFER_ITEMS);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_PROJECTS);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_COMPANIES);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_PERSONAL_LIST);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_ACCEPTED_OFFERS);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_PROJECT_CONTINUING);
            WebSocketService.getInstance().Send(data);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.projectContinuings.Where(p => !SearchInListView2(p.ProjectId.ToString())))
            {
                AddListView(GetListViewItem(item));
            }
        }

        private ListViewItem GetListViewItem(ProjectContinuing item)
        {
            ListViewItem lvItem = new ListViewItem();
            Project project = Lists.projects.Where(p => p.Id == item.ProjectId).FirstOrDefault();
            List<Offer> offers = Lists.offers.Where(o => o.ProjectId == project.Id).ToList();
            AcceptedOffer temp = null;
            foreach(var foreachItem in offers)
            {
                temp = Lists.acceptedOffers.Where(o => o.OfferId == foreachItem.Id).FirstOrDefault();
                if(temp!=null)
                {
                    Staff staff=Lists.staffs.Where(s => s.Id == temp.StaffId).FirstOrDefault();
                    lvItem.Text = project.Id.ToString();
                    lvItem.SubItems.Add(project.Name);
                    lvItem.SubItems.Add(staff.Name + " " + staff.Surname);
                    lvItem.SubItems.Add(temp.Deadline.ToShortDateString());
                    lvItem.SubItems.Add("Test");
                    lvItem.SubItems.Add(temp.Note);
                    lvItem.SubItems.Add("Test");
                    break;
                }
            }
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                Project project = Lists.projects.Where(p => p.Id == id).FirstOrDefault();
                List<Offer> offers = Lists.offers.Where(o => o.ProjectId == id).ToList();
                Offer offer = null;
                AcceptedOffer acceptedOffer = null;
                foreach(var item in offers)
                {
                    acceptedOffer = Lists.acceptedOffers.Where(o => o.OfferId == item.Id).FirstOrDefault();
                    if(acceptedOffer!=null)
                    {
                        offer = item;
                        break;
                    }
                }
                frmDevamEdenProjelerProjeDetay devamProjelerProjeDetay = new frmDevamEdenProjelerProjeDetay(offer,acceptedOffer);
                devamProjelerProjeDetay.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Utilities.Minimize();
        }
    }
}
