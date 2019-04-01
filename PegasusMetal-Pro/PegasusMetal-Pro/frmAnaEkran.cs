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
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userDelete();
            userProjeler1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userDelete();
            userTeklifler1.Visible = true;
        }

        private void colorPickEdit1_ColorChanged(object sender, EventArgs e)
        {
            string color = colorPickEdit1.Color;
            this.BackColor = colorPickEdit1.BackColor;
        }
    }
}
