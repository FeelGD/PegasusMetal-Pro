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
            InitializeComponent();
        }

        void userDelete()
        {

            userProjeler1.Visible = false;
            userTeklifler1.Visible = false;
            userVeriler1.Visible = false;
            userAyarlar1.Visible = false;

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
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            userDelete();
            userProjeler1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            userDelete();
            userTeklifler1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            userDelete();
            userVeriler1.Visible = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            userDelete();
            userAyarlar1.Visible = true;
        }
        private void colorPickEdit1_ColorChanged(object sender, EventArgs e)
        {

            this.BackColor = colorPickEdit1.Color;
            userProjeler1.BackColor = colorPickEdit1.Color;
            userTeklifler1.BackColor = colorPickEdit1.Color;
        }
    }
}
