using DevExpress.XtraEditors.Controls;
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
    public partial class frmTekliflerPersonelAta : Form
    {
        public delegate void AddDelegate(object item);
        private Offer offer;

        public frmTekliflerPersonelAta()
        {
            InitializeComponent();
        }

        public frmTekliflerPersonelAta(Offer offer)
        {
            InitializeComponent();
            this.offer = offer;
            //Lists.users.Clear();
            Lists.users.CollectionChanged += UsersCollectionChanged;
            //List<string> data = new List<string>();
            //Lists.staffs.Clear();
            //data.Add(OPCodes.GET_PERSONAL_LIST);
            //WebSocketService.getInstance().Send(data);
            //data.Clear();
            //data.Add(OPCodes.GET_USER_LIST);
            //WebSocketService.getInstance().Send(data);
            UsersCollectionChanged(null, null);
            
        }

        private void UsersCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Lists.users.Where(s => !Search(Lists.staffs.Where(sa => sa.Id == s.StaffId).SingleOrDefault().Name + " " + Lists.staffs.Where(sa => sa.Id == s.StaffId).SingleOrDefault().Surname)))
            {
                Add(item.StaffId + "-"+ Lists.staffs.Where(sa => sa.Id == item.StaffId).SingleOrDefault().Name + " " + Lists.staffs.Where(sa => sa.Id == item.StaffId).SingleOrDefault().Surname);
            }
        }

        private void Add(object item)
        {
            if(textEditPersonelAdi.InvokeRequired)
            {
                var d = new AddDelegate(Add);
                Invoke(d, new object[] { item });
            }
            else
            {
                textEditPersonelAdi.Properties.Items.Add(item);
            }
        }

        private bool Search(string Id)
        {
            foreach (string item in textEditPersonelAdi.Properties.Items)
            {
                if (item.ToString().Trim().Equals(Id.Trim()))
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textEditPersonelAdi.Text.Trim()) || String.IsNullOrEmpty(textEditTermin.Text.Trim()))
            {
                MessageBox.Show("Termin Tarihi veya Personel Adı Boş Bırakılamaz.");
                return;
            }

            Staff staff = Lists.staffs.Where(s => s.Id == int.Parse(textEditPersonelAdi.Text.Trim().Split('-')[0])).FirstOrDefault();
            frmNot frmNot = new frmNot(offer,staff,Convert.ToDateTime(textEditTermin.Text));
            frmNot.ShowDialog();
            
        }
    }
}
