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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (!Constants.AllDataIsReceived)
            {
                new frmLoading().ShowDialog();
            }
            InitializeComponent();
        }

        void userDelete()
        {

            userProjeler1.Visible = false;
            userTeklifler1.Visible = false;
            userVeriler1.Visible = false;
            userAyarlar1.Visible = false;
            userRaporlar1.Visible = false;

        }
        void yanPanel()
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainProjelerBtn.Height;
            SidePanel.Top = MainProjelerBtn.Top;
            userDelete();
            userProjeler1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainTekliflerBtn.Height;
            SidePanel.Top = MainTekliflerBtn.Top;
            userDelete();
            userTeklifler1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainVerilerBtn.Height;
            SidePanel.Top = MainVerilerBtn.Top;
            userDelete();
            userVeriler1.Visible = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainAyarlarBtn.Height;
            SidePanel.Top = MainAyarlarBtn.Top;
            userDelete();
            userAyarlar1.Visible = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainRaporlarBtn.Height;
            SidePanel.Top = MainRaporlarBtn.Top;
            userDelete();
            userRaporlar1.Visible = true;
        }
        private void colorPickEdit1_ColorChanged(object sender, EventArgs e)
        {

            this.BackColor = colorPickEdit1.Color;
            userProjeler1.BackColor = colorPickEdit1.Color;
            userTeklifler1.BackColor = colorPickEdit1.Color;
            userVeriler1.BackColor = colorPickEdit1.Color;
            userAyarlar1.BackColor = colorPickEdit1.Color;
            userRaporlar1.BackColor = colorPickEdit1.Color;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pegasusmetal.com.tr/");
        }
    }
}
