﻿using System;
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
