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
    public partial class frmTeklifler : Form
    {
        private delegate void InvokeForm(Form form);
        public frmTeklifler()
        {
            InitializeComponent();
            Lists.projects.Clear();
            Lists.companies.Clear();
            Lists.offers.CollectionChanged += CollectionChanged;
            Lists.companies.CollectionChanged += CompanyCollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_PROJECTS);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_COMPANIES);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_OFFERS);
            WebSocketService.getInstance().Send(data);
        }

        private void CompanyCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.offers.Where(s => !SearchInListView(s.Id.ToString())))
            {
                var project = Lists.projects.Where(i => i.Id == item.ProjectId).SingleOrDefault();
                string[] array = { item.Id.ToString(), project.Name, item.LastPrice.ToString(), "Testing", project.Status };
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmTekliflerPersonelAta frmTekliflerPersonelAta = new frmTekliflerPersonelAta();
            frmTekliflerPersonelAta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems[0] != null)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text.Trim());
                var offer = Lists.offers.Where(i => i.Id == id).SingleOrDefault();
                var project = Lists.projects.Where(i => i.Id == offer.ProjectId).SingleOrDefault();
                var company = Lists.companies.Where(i => i.Id == project.CompanyId).SingleOrDefault();
                frmYeniProjeTeklifOlustur teklifOlustur = new frmYeniProjeTeklifOlustur(project, company, offer);
                Open(teklifOlustur);
            }
        }

        private void Open(Form form)
        {
            if(form.InvokeRequired)
            {
                var d = new InvokeForm(Open);
                Invoke(d, new object[] { form });
            }
            else
            {
                form.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
