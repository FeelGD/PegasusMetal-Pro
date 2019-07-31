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
    public partial class frmDevamEdenProjelerProjeDetay : Form
    {
        private Offer offer;
        private AcceptedOffer acceptedOffer;
        private List<OfferItem> offerItems;
        public frmDevamEdenProjelerProjeDetay()
        {
            InitializeComponent();
        }

        public frmDevamEdenProjelerProjeDetay(Offer offer,AcceptedOffer acceptedOffer)
        {
            InitializeComponent();
            this.offer = offer;
            this.acceptedOffer = acceptedOffer;
            richTextBox13.Text = acceptedOffer.Note;
            offerItems = Lists.offerItems.Where(o => o.OfferId == offer.Id).ToList();
            ProjeTermin.Text = acceptedOffer.Deadline.ToShortDateString();
            foreach (var item in offerItems)
            {
                if (item.AssemblyPrice != null)
                {
                    groupBox11.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.Assembly && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxMontaj.Text = processItem.Note;
                    dateEditMontaj.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.CountersinkPrice != null)
                {
                    groupBox6.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.CounterSink && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxHavsaAcma.Text = processItem.Note;
                    dateEditHavsaAcma.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.CoveringPrice != null)
                {
                    groupBox5.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.Covering && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxKaplama.Text = processItem.Note;
                    dateEditKaplama.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.IndentionHelicoilPrice != null)
                {
                    groupBox7.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.ThreadingHelicoil && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxDisAcma.Text = processItem.Note;
                    dateEditDisAcma.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.LaserCuttingPrice != null)
                {
                    groupBox2.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.LaserCutting && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxLazer.Text = processItem.Note;
                    dateEditLazeer.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.MachiningOnePrice != null)
                {
                    groupBox10.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.MachiningOne && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxTalasli1.Text = processItem.Note;
                    dateEditTalasli1.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.MachiningTwoPrice != null)
                {
                    groupBox13.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.MachiningTwo && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxTalasli2.Text = processItem.Note;
                    dateEditTalasli2.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.MaskingTapePrice != null)
                {
                    groupBox8.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.MaskingTape && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxMaskeleme.Text = processItem.Note;
                    dateEditMaskeleme.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.PaintPrice != null)
                {
                    groupBox9.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.Paint && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxBoya.Text = processItem.Note;
                    dateEditBoya.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.TighteningPrice != null)
                {
                    groupBox12.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.ImpactWrench && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxSomunSikma.Text = processItem.Note;
                    dateEditSomunSikma.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.TwistPrice != null)
                {
                    groupBox3.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.Twist && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxBukum.Text = processItem.Note;
                    dateEditBukum.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
                if (item.WeldPrice != null)
                {
                    groupBox4.Visible = true;
                    var processItem = Lists.projectContinuings.Where(p => p.ProcessId == (int)Constants.Processes.Welding && p.ProjectId == offer.ProjectId).FirstOrDefault();
                    richTextBoxKaynak.Text = processItem.Note;
                    dateEditKaynak.DateTime = Convert.ToDateTime(processItem.Deadline);
                }
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
            if (groupBox11.Visible)
            {
                groupBox11.Visible = true;
                //Montaj
                ProjectContinuing p = new ProjectContinuing()
                {
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
