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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (groupBox11.Visible)
            {
                groupBox11.Visible = true;
                //Montaj
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.Assembly,
                    Deadline = dateEditMontaj.DateTime,
                    Note = richTextBoxMontaj.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox6.Visible)
            {
                //Havşa Açma
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.CounterSink,
                    Deadline = dateEditHavsaAcma.DateTime,
                    Note = richTextBoxHavsaAcma.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox5.Visible)
            {
                //Kaplama
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.Covering,
                    Deadline = dateEditKaplama.DateTime,
                    Note = richTextBoxKaplama.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox7.Visible)
            {
                //Helicoil
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.ThreadingHelicoil,
                    Deadline = dateEditDisAcma.DateTime,
                    Note = richTextBoxDisAcma.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox2.Visible)
            {
                //Lazer Kesim
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.LaserCutting,
                    Deadline = dateEditLazeer.DateTime,
                    Note = richTextBoxLazer.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox10.Visible)
            {
                //Talaşlı 1
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.MachiningOne,
                    Deadline = dateEditTalasli1.DateTime,
                    Note = richTextBoxTalasli1.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox13.Visible)
            {
                //Talaşlı 2
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.MachiningTwo,
                    Deadline = dateEditTalasli2.DateTime,
                    Note = richTextBoxTalasli2.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox8.Visible)
            {
                //Maskeleme Bandı
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.MaskingTape,
                    Deadline = dateEditMaskeleme.DateTime,
                    Note = richTextBoxMaskeleme.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox9.Visible)
            {
                //Boyama
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.Paint,
                    Deadline = dateEditBoya.DateTime,
                    Note = richTextBoxBoya.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox12.Visible)
            {
                //Somun sıkma
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.ImpactWrench,
                    Deadline = dateEditSomunSikma.DateTime,
                    Note = richTextBoxSomunSikma.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox3.Visible)
            {
                //Bükme
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.Twist,
                    Deadline = dateEditBukum.DateTime,
                    Note = richTextBoxBukum.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            if (groupBox4.Visible)
            {
                //Kaynak
                ProjectContinuing p = new ProjectContinuing()
                {
                    Id = -1,
                    ProcessId = (int)Constants.Processes.Welding,
                    Deadline = dateEditKaynak.DateTime,
                    Note = richTextBoxKaynak.Text,
                    ProjectId = offer.ProjectId,
                    Status = true
                };
                List<string> data = new List<string>();
                data.Add(OPCodes.PROJECT_CONTINUING);
                data.Add(JsonConvert.SerializeObject(p));
                WebSocketService.getInstance().Send(data);
            }
            this.Close();
        }
    }
}
