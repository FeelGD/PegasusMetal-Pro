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
    public partial class frmSipariseBasla : Form
    {
        private Offer offer;
        private AcceptedOffer acceptedOffer;
        private List<OfferItem> offerItems;
        public frmSipariseBasla()
        {
            InitializeComponent();
        }

        public frmSipariseBasla(Offer offer,AcceptedOffer acceptedOffer)
        {
            InitializeComponent();
            this.offer = offer;
            this.acceptedOffer = acceptedOffer;
            richTextBox13.Text = acceptedOffer.Note;
            offerItems = Lists.offerItems.Where(o => o.OfferId == offer.Id).ToList();
            ProjeTermin.Text = acceptedOffer.Deadline.ToShortDateString();
            foreach(var item in offerItems)
            {
                if(item.AssemblyPrice!=null)
                {
                    groupBox11.Visible = true;
                }
                if(item.CountersinkPrice!=null)
                {
                    groupBox6.Visible = true;
                }
                if(item.CoveringPrice!=null)
                {
                    groupBox5.Visible = true;
                }
                if(item.IndentionHelicoilPrice!=null)
                {
                    groupBox7.Visible = true;
                }
                if (item.LaserCuttingPrice != null)
                {
                    groupBox2.Visible = true;
                }
                if (item.MachiningOnePrice != null)
                {
                    groupBox10.Visible = true;
                }
                if (item.MachiningTwoPrice != null)
                {
                    groupBox13.Visible = true;
                }
                if (item.MaskingTapePrice != null)
                {
                    groupBox8.Visible = true;
                }
                if (item.PaintPrice != null)
                {
                    groupBox9.Visible = true;
                }
                if (item.TighteningPrice != null)
                {
                    groupBox12.Visible = true;
                }
                if (item.TwistPrice != null)
                {
                    groupBox3.Visible = true;
                }
                if (item.WeldPrice != null)
                {
                    groupBox4.Visible = true;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateEdit10_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
