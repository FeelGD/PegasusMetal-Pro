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
    public partial class frmYeniProjeler : Form
    {
        public frmYeniProjeler()
        {
            InitializeComponent();
            Lists.projects.Clear();
            Lists.companies.Clear();
            Lists.projects.CollectionChanged += CollectionChanged;
            Lists.companies.CollectionChanged += CompanyCollectionChanged;
            List<string> data = new List<string>();
            data.Add(OPCodes.GET_COMPANIES);
            WebSocketService.getInstance().Send(data);
            data.Clear();
            data.Add(OPCodes.GET_PROJECTS);
            WebSocketService.getInstance().Send(data);
        }

        private void CompanyCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.projects.Where(s => !SearchInListView(s.Id.ToString())))
            {
                string[] array = { item.Id.ToString(), item.Name, Lists.companies.Where(i=>i.Id==item.CompanyId).SingleOrDefault().Name, "Testing", "Testing" };
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmYeniProjeOlustur yeniProjeOlustur = new frmYeniProjeOlustur();
            yeniProjeOlustur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYeniProjeGuncelle yeniProjeGuncelle = new frmYeniProjeGuncelle();
            yeniProjeGuncelle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Project project = Lists.projects.Where(i => i.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text)).SingleOrDefault();
            Company company = Lists.companies.Where(i => i.Id == project.CompanyId).SingleOrDefault();
            frmYeniProjeTeklifOlustur projeyeTeklifOlustur = new frmYeniProjeTeklifOlustur(project, company);
            if(projeyeTeklifOlustur != null)
                projeyeTeklifOlustur.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
