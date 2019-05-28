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
    public partial class frmParcaKoduEkle : Form
    {
        public frmParcaKoduEkle()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void RefreshBoxes()
        {
            textEditParcaAdi.Text = "";
            textEditParcaKodu.Text = "";
            textEditKalite.Text = "";
            textEditBoy.Text = "";
            textEditEn.Text = "";
            texteditKalinlik.Text = "";
            textEdit2.Text = "";
  
        }

        private void simpleButtonParcaKoduEkle_Click(object sender, EventArgs e)
        {
            Piece piece = new Piece
            {
                Id = -1,
                Name = textEditParcaAdi.Text,
                Code = textEditParcaKodu.Text,
                Quality = textEditKalite.Text,
                Height = int.Parse(textEditBoy.Text),
                Width = int.Parse(textEditEn.Text),
                Thickness = Convert.ToDecimal(texteditKalinlik.Text),
                WasteRate = Convert.ToDecimal(textEdit2.Text),
                PMCode = -1
            };
            List<string> data = new List<string>();
            data.Add(OPCodes.PIECE);
            data.Add(JsonConvert.SerializeObject(piece));
            WebSocketService.getInstance().Send(data);
            RefreshBoxes();
                   }
            
    }
}

