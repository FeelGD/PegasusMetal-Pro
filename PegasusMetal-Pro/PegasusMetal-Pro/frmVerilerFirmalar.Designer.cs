namespace PegasusMetal_Pro
{
    partial class frmVerilerFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerilerFirmalar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VergiNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VergiDaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButtonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFirmaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.textEditVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.textEditVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.textEditFirmaIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAdres = new DevExpress.XtraEditors.MemoEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirmaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirmaIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdres.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1138, 41);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1068, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 41);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1103, 0);
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
            this.panel2.Size = new System.Drawing.Size(796, 540);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ad,
            this.Kod,
            this.VergiNo,
            this.VergiDaire,
            this.Mail,
            this.Adres});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 540);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "id";
            this.Id.Width = 20;
            // 
            // Ad
            // 
            this.Ad.Text = "Firmanın Adı";
            this.Ad.Width = 126;
            // 
            // Kod
            // 
            this.Kod.Text = "Firmanın Kodu";
            this.Kod.Width = 108;
            // 
            // VergiNo
            // 
            this.VergiNo.Text = "Vergi Numarası";
            this.VergiNo.Width = 130;
            // 
            // VergiDaire
            // 
            this.VergiDaire.Text = "Vergi Dairesi";
            this.VergiDaire.Width = 118;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail Adresi";
            this.Mail.Width = 102;
            // 
            // Adres
            // 
            this.Adres.Text = "Firmanın adresi";
            this.Adres.Width = 175;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.simpleButtonGuncelle);
            this.panel3.Controls.Add(this.simpleButtonKaydet);
            this.panel3.Controls.Add(this.textEditFirmaKodu);
            this.panel3.Controls.Add(this.labelControl8);
            this.panel3.Controls.Add(this.textEditId);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Controls.Add(this.textEditMail);
            this.panel3.Controls.Add(this.textEditVergiDairesi);
            this.panel3.Controls.Add(this.textEditVergiNo);
            this.panel3.Controls.Add(this.textEditFirmaIsmi);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.textEditAdres);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(805, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 540);
            this.panel3.TabIndex = 4;
            // 
            // simpleButtonGuncelle
            // 
            this.simpleButtonGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonGuncelle.Appearance.Options.UseFont = true;
            this.simpleButtonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuncelle.ImageOptions.Image")));
            this.simpleButtonGuncelle.Location = new System.Drawing.Point(3, 475);
            this.simpleButtonGuncelle.Name = "simpleButtonGuncelle";
            this.simpleButtonGuncelle.Size = new System.Drawing.Size(327, 53);
            this.simpleButtonGuncelle.TabIndex = 44;
            this.simpleButtonGuncelle.Text = "FİRMAYI GÜNCELLE";
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonKaydet.Appearance.Options.UseFont = true;
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(3, 415);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(327, 54);
            this.simpleButtonKaydet.TabIndex = 43;
            this.simpleButtonKaydet.Text = "FİRMAYI KAYDET";
            // 
            // textEditFirmaKodu
            // 
            this.textEditFirmaKodu.Location = new System.Drawing.Point(143, 102);
            this.textEditFirmaKodu.Name = "textEditFirmaKodu";
            this.textEditFirmaKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditFirmaKodu.Properties.Appearance.Options.UseFont = true;
            this.textEditFirmaKodu.Size = new System.Drawing.Size(187, 26);
            this.textEditFirmaKodu.TabIndex = 42;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(47, 107);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 21);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Firma Kodu:";
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(143, 15);
            this.textEditId.Name = "textEditId";
            this.textEditId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditId.Properties.Appearance.Options.UseFont = true;
            this.textEditId.Size = new System.Drawing.Size(187, 26);
            this.textEditId.TabIndex = 40;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(113, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 21);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "ID:";
            // 
            // textEditMail
            // 
            this.textEditMail.EditValue = "";
            this.textEditMail.Location = new System.Drawing.Point(143, 235);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEditMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEditMail.Size = new System.Drawing.Size(187, 26);
            this.textEditMail.TabIndex = 38;
            // 
            // textEditVergiDairesi
            // 
            this.textEditVergiDairesi.Location = new System.Drawing.Point(143, 187);
            this.textEditVergiDairesi.Name = "textEditVergiDairesi";
            this.textEditVergiDairesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditVergiDairesi.Properties.Appearance.Options.UseFont = true;
            this.textEditVergiDairesi.Size = new System.Drawing.Size(187, 26);
            this.textEditVergiDairesi.TabIndex = 36;
            // 
            // textEditVergiNo
            // 
            this.textEditVergiNo.Location = new System.Drawing.Point(143, 144);
            this.textEditVergiNo.Name = "textEditVergiNo";
            this.textEditVergiNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditVergiNo.Properties.Appearance.Options.UseFont = true;
            this.textEditVergiNo.Size = new System.Drawing.Size(187, 26);
            this.textEditVergiNo.TabIndex = 35;
            // 
            // textEditFirmaIsmi
            // 
            this.textEditFirmaIsmi.Location = new System.Drawing.Point(143, 58);
            this.textEditFirmaIsmi.Name = "textEditFirmaIsmi";
            this.textEditFirmaIsmi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditFirmaIsmi.Properties.Appearance.Options.UseFont = true;
            this.textEditFirmaIsmi.Size = new System.Drawing.Size(187, 26);
            this.textEditFirmaIsmi.TabIndex = 34;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(84, 285);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 21);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Adresi:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 21);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Mail Adresi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 192);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 21);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Vergi Dairesi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 149);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 21);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Vergi Numarası:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 21);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Firma İsmi:";
            // 
            // textEditAdres
            // 
            this.textEditAdres.Location = new System.Drawing.Point(144, 284);
            this.textEditAdres.Name = "textEditAdres";
            this.textEditAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditAdres.Properties.Appearance.Options.UseFont = true;
            this.textEditAdres.Size = new System.Drawing.Size(186, 94);
            this.textEditAdres.TabIndex = 37;
            // 
            // frmVerilerFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerilerFirmalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerilerFirmalar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirmaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirmaIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Kod;
        private System.Windows.Forms.ColumnHeader VergiNo;
        private System.Windows.Forms.ColumnHeader VergiDaire;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditFirmaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.TextEdit textEditVergiDairesi;
        private DevExpress.XtraEditors.TextEdit textEditVergiNo;
        private DevExpress.XtraEditors.TextEdit textEditFirmaIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit textEditAdres;
    }
}