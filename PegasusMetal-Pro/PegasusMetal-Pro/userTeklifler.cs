﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public partial class userTeklifler : UserControl
    {
        public userTeklifler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTeklifler frmTeklifler = new frmTeklifler();
            frmTeklifler.ShowDialog();
        }
    }
}
