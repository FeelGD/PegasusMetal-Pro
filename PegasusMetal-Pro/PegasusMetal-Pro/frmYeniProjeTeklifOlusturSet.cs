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
    public partial class frmYeniProjeTeklifOlusturSet : Form
    {
        private Material material;
        public frmYeniProjeTeklifOlusturSet()
        {
            InitializeComponent();
        }

        private void frmYeniProjeTeklifOlusturSet_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Calculate()
        {
            //weight
           int TTotalWeight = Convert.ToInt32(DKPWeight.Text) + Convert.ToInt32(HRPWeight.Text) + Convert.ToInt32(PSLWeight.Text) + Convert.ToInt32(SYHWeight.Text) + Convert.ToInt32(ALUWeight.Text);
            TotalWeight.Text = TTotalWeight.ToString();

            //cost
            int TTotalCost = Convert.ToInt32(DKPWeight.Text) + Convert.ToInt32(HRPCost.Text) + Convert.ToInt32(PSLCost.Text) + Convert.ToInt32(SYHCost.Text) + Convert.ToInt32(ALUCost.Text);
            TotalCost.Text = TTotalCost.ToString();
        }
        private void WeightCalculate()
        {
            int weight;
            int alan = 0;
            int agirlik;
            if (txtEnBoy.Text == "2x1")
            {
                alan = 16;
            }
            else if (txtEnBoy.Text == "2.5x1.25")
            {
                alan = 25;
            }
            else if (txtEnBoy.Text == "3x1.5")
            {
                alan = 36;
            }
            else
            {
                MessageBox.Show("Lütfen En Boy Seçiniz!!!");
            }
            agirlik = Convert.ToInt16(txtKalinlik.Text) * alan * Convert.ToInt16(txtAdet.Text);
            switch (txtCins.Text)
            {
                case "DKP":
                     weight = Convert.ToInt16(DKPWeight.Text) + agirlik;
                    DKPWeight.Text = weight.ToString();
                    break;
                case "HRP":
                    weight = Convert.ToInt16(HRPWeight.Text) + agirlik;
                    HRPWeight.Text = weight.ToString();
                    break;
                case "PSL":
                    weight = Convert.ToInt16(PSLWeight.Text) + agirlik;
                    PSLWeight.Text = weight.ToString();
                    break;
                case "SYH":
                    weight = Convert.ToInt16(SYHWeight.Text) + agirlik;
                    SYHWeight.Text = weight.ToString();
                    break;
                case "ALÜ":
                    weight = Convert.ToInt16(ALUWeight.Text) + agirlik;
                    ALUWeight.Text = weight.ToString();
                    break;
                default:
                    MessageBox.Show("Lütfen Bir CİNS Giriniz");
                    break;
            }
        }

        private void simpleButtonEkle_Click(object sender, EventArgs e)
        {
            WeightCalculate();
            
        }

        private void simpleButtonEkle_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("LÜTFEN 1 KERE TIKLAYINIZ");
        }
    }
}
