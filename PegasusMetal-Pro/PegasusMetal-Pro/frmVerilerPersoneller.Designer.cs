namespace PegasusMetal_Pro
{
    partial class frmVerilerPersoneller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerilerPersoneller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gorev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTel = new DevExpress.XtraEditors.TextEdit();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.textEditGorevi = new DevExpress.XtraEditors.TextEdit();
            this.textEditAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGorevi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 41);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1005, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 41);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1040, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 532);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.Gorev,
            this.Mail,
            this.Telefon});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 532);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "id";
            this.Id.Width = 20;
            // 
            // Ad
            // 
            this.Ad.Text = "Personelin Adı";
            this.Ad.Width = 91;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Personelin Soyadı";
            this.Soyad.Width = 134;
            // 
            // Gorev
            // 
            this.Gorev.Text = "Personelin Görevi";
            this.Gorev.Width = 113;
            // 
            // Mail
            // 
            this.Mail.Text = "Personelin Mail Adresi";
            this.Mail.Width = 144;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Personelin Telefon Numarası";
            this.Telefon.Width = 167;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.simpleButtonSil);
            this.panel3.Controls.Add(this.simpleButtonGuncelle);
            this.panel3.Controls.Add(this.simpleButtonKaydet);
            this.panel3.Controls.Add(this.textEditSoyad);
            this.panel3.Controls.Add(this.labelControl7);
            this.panel3.Controls.Add(this.textEditId);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Controls.Add(this.textEditTel);
            this.panel3.Controls.Add(this.textEditMail);
            this.panel3.Controls.Add(this.textEditGorevi);
            this.panel3.Controls.Add(this.textEditAd);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(716, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 532);
            this.panel3.TabIndex = 3;
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonSil.Appearance.Options.UseFont = true;
            this.simpleButtonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSil.ImageOptions.Image")));
            this.simpleButtonSil.Location = new System.Drawing.Point(20, 399);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(327, 53);
            this.simpleButtonSil.TabIndex = 42;
            this.simpleButtonSil.Text = "PERSONELİ SİL";
            this.simpleButtonSil.Click += new System.EventHandler(this.SimpleButtonSil_Click);
            // 
            // simpleButtonGuncelle
            // 
            this.simpleButtonGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonGuncelle.Appearance.Options.UseFont = true;
            this.simpleButtonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuncelle.ImageOptions.Image")));
            this.simpleButtonGuncelle.Location = new System.Drawing.Point(20, 458);
            this.simpleButtonGuncelle.Name = "simpleButtonGuncelle";
            this.simpleButtonGuncelle.Size = new System.Drawing.Size(327, 53);
            this.simpleButtonGuncelle.TabIndex = 41;
            this.simpleButtonGuncelle.Text = "PERSONELİ GÜNCELLE";
            this.simpleButtonGuncelle.Click += new System.EventHandler(this.SimpleButtonGuncelle_Click);
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonKaydet.Appearance.Options.UseFont = true;
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(20, 339);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(327, 54);
            this.simpleButtonKaydet.TabIndex = 40;
            this.simpleButtonKaydet.Text = "PERSONELİ KAYDET";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.SimpleButtonKaydet_Click);
            // 
            // textEditSoyad
            // 
            this.textEditSoyad.Location = new System.Drawing.Point(142, 93);
            this.textEditSoyad.Name = "textEditSoyad";
            this.textEditSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditSoyad.Properties.Appearance.Options.UseFont = true;
            this.textEditSoyad.Size = new System.Drawing.Size(205, 26);
            this.textEditSoyad.TabIndex = 39;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(76, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 23);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = "Soyad:";
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(142, 6);
            this.textEditId.Name = "textEditId";
            this.textEditId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditId.Properties.Appearance.Options.UseFont = true;
            this.textEditId.Size = new System.Drawing.Size(205, 26);
            this.textEditId.TabIndex = 37;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(107, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 23);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "ID:";
            // 
            // textEditTel
            // 
            this.textEditTel.EditValue = "";
            this.textEditTel.Location = new System.Drawing.Point(142, 231);
            this.textEditTel.Name = "textEditTel";
            this.textEditTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditTel.Properties.Appearance.Options.UseFont = true;
            this.textEditTel.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEditTel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEditTel.Size = new System.Drawing.Size(205, 26);
            this.textEditTel.TabIndex = 35;
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(142, 184);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Size = new System.Drawing.Size(205, 26);
            this.textEditMail.TabIndex = 34;
            // 
            // textEditGorevi
            // 
            this.textEditGorevi.Location = new System.Drawing.Point(142, 139);
            this.textEditGorevi.Name = "textEditGorevi";
            this.textEditGorevi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditGorevi.Properties.Appearance.Options.UseFont = true;
            this.textEditGorevi.Size = new System.Drawing.Size(205, 26);
            this.textEditGorevi.TabIndex = 33;
            // 
            // textEditAd
            // 
            this.textEditAd.Location = new System.Drawing.Point(142, 47);
            this.textEditAd.Name = "textEditAd";
            this.textEditAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditAd.Properties.Appearance.Options.UseFont = true;
            this.textEditAd.Size = new System.Drawing.Size(205, 26);
            this.textEditAd.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 23);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Cep Telefonu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(39, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 23);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Mail Adresi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(76, 146);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 23);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Görevi:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 23);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Ad:";
            // 
            // frmVerilerPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 573);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerilerPersoneller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerilerPersoneller";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGorevi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Gorev;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Telefon;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditTel;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.TextEdit textEditGorevi;
        private DevExpress.XtraEditors.TextEdit textEditAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}