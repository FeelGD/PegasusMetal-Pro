using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class frmYeniProjeOlustur : Form
    {
        public frmYeniProjeOlustur()
        {
            InitializeComponent();
            foreach(var item in Lists.companies.ToList())
            {
                textEdit2.Properties.Items.Add(item.Name);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Project project = new Project
            {
                Id = -1,
                CompanyId = Lists.companies.Where(i=>i.Name==textEdit2.Text).SingleOrDefault().Id,
                Name = textEdit1.Text,
                PType = textEdit3.Text == "Parça" ? true : false,
                Status = "Durum"
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.PROJECT);
            data.Add(JsonConvert.SerializeObject(project));
            WebSocketService.getInstance().Send(data);
            MessageBox.Show("Proje başarıyla oluşturuldu.");
            this.Close();
        }
    }
}
