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
    public partial class frmNot : Form
    {
        private Offer offer;
        private Staff staff;
        private DateTime deadLine;
        public frmNot()
        {
            InitializeComponent();
        }

        public frmNot(Offer offer,Staff staff,DateTime deadLine)
        {
            InitializeComponent();
            this.offer = offer;
            this.staff = staff;
            this.deadLine = deadLine;
        }

        private void BtnNotEkle_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(richTextBox1.Text.Trim()))
            {
                var msgBoxDialogResult = MessageBox.Show("Not kısmını boş bırakmak istediğinize eminmisiniz?", "Not Boş!", MessageBoxButtons.YesNo);
                if(msgBoxDialogResult == DialogResult.No)
                {
                    return;
                }
            }
            AcceptedOffer acceptedOffer = new AcceptedOffer()
            {
                StaffId = staff.Id,
                OfferId = offer.Id,
                Deadline = deadLine,
                Note = richTextBox1.Text
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.ACCEPTED_OFFER);
            data.Add(JsonConvert.SerializeObject(acceptedOffer));
            WebSocketService.getInstance().Send(data);
            this.Close();
        }
    }
}
