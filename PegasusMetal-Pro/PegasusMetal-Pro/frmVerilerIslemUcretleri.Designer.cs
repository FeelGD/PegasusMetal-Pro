namespace PegasusMetal_Pro
{
    partial class frmVerilerIslemUcretleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerilerIslemUcretleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ozellik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DakikaFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditDakikaFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditBirimFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMalzemeOzelligi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditIslemAdi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDakikaFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBirimFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMalzemeOzelligi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIslemAdi.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1024, 41);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(954, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(989, 0);
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
            this.panel2.Size = new System.Drawing.Size(674, 549);
            this.panel2.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ad,
            this.Ozellik,
            this.BirimFiyat,
            this.DakikaFiyat});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 549);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "İşlem Numarası";
            this.Id.Width = 104;
            // 
            // Ad
            // 
            this.Ad.Text = "İşlemin Adı";
            this.Ad.Width = 163;
            // 
            // Ozellik
            // 
            this.Ozellik.Text = "Malzeme Özelliği";
            this.Ozellik.Width = 129;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.Text = "Birim Fiyatı";
            this.BirimFiyat.Width = 92;
            // 
            // DakikaFiyat
            // 
            this.DakikaFiyat.Text = "Dakika Fiyatı";
            this.DakikaFiyat.Width = 116;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.simpleButtonKaydet);
            this.panel3.Controls.Add(this.textEditDakikaFiyati);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.textEditBirimFiyati);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.simpleButtonGuncelle);
            this.panel3.Controls.Add(this.textEditId);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Controls.Add(this.textEditMalzemeOzelligi);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.textEditIslemAdi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(681, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 549);
            this.panel3.TabIndex = 5;
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonKaydet.Appearance.Options.UseFont = true;
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(23, 339);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(288, 54);
            this.simpleButtonKaydet.TabIndex = 65;
            this.simpleButtonKaydet.Text = "İŞLEMİ KAYDET";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.simpleButtonKaydet_Click);
            // 
            // textEditDakikaFiyati
            // 
            this.textEditDakikaFiyati.Location = new System.Drawing.Point(161, 220);
            this.textEditDakikaFiyati.Name = "textEditDakikaFiyati";
            // 
            // 
            // 
            this.textEditDakikaFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditDakikaFiyati.Properties.Appearance.Options.UseFont = true;
            this.textEditDakikaFiyati.Properties.Mask.EditMask = "n2";
            this.textEditDakikaFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditDakikaFiyati.Size = new System.Drawing.Size(147, 26);
            this.textEditDakikaFiyati.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(54, 225);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 21);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Dakika Fiyatı:";
            // 
            // textEditBirimFiyati
            // 
            this.textEditBirimFiyati.Location = new System.Drawing.Point(161, 172);
            this.textEditBirimFiyati.Name = "textEditBirimFiyati";
            // 
            // 
            // 
            this.textEditBirimFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditBirimFiyati.Properties.Appearance.Options.UseFont = true;
            this.textEditBirimFiyati.Properties.Mask.EditMask = "n2";
            this.textEditBirimFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditBirimFiyati.Size = new System.Drawing.Size(147, 26);
            this.textEditBirimFiyati.TabIndex = 53;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 177);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 21);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Birim Fiyatı:";
            // 
            // simpleButtonGuncelle
            // 
            this.simpleButtonGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonGuncelle.Appearance.Options.UseFont = true;
            this.simpleButtonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuncelle.ImageOptions.Image")));
            this.simpleButtonGuncelle.Location = new System.Drawing.Point(24, 399);
            this.simpleButtonGuncelle.Name = "simpleButtonGuncelle";
            this.simpleButtonGuncelle.Size = new System.Drawing.Size(287, 53);
            this.simpleButtonGuncelle.TabIndex = 51;
            this.simpleButtonGuncelle.Text = "İŞLEMİ GÜNCELLE";
            this.simpleButtonGuncelle.Click += new System.EventHandler(this.simpleButtonGuncelle_Click);
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(161, 37);
            this.textEditId.Name = "textEditId";
            // 
            // 
            // 
            this.textEditId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditId.Properties.Appearance.Options.UseFont = true;
            this.textEditId.Size = new System.Drawing.Size(147, 26);
            this.textEditId.TabIndex = 49;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(131, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 21);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "ID:";
            // 
            // textEditMalzemeOzelligi
            // 
            this.textEditMalzemeOzelligi.Location = new System.Drawing.Point(161, 126);
            this.textEditMalzemeOzelligi.Name = "textEditMalzemeOzelligi";
            // 
            // 
            // 
            this.textEditMalzemeOzelligi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditMalzemeOzelligi.Properties.Appearance.Options.UseFont = true;
            this.textEditMalzemeOzelligi.Properties.Mask.EditMask = "n2";
            this.textEditMalzemeOzelligi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditMalzemeOzelligi.Size = new System.Drawing.Size(147, 26);
            this.textEditMalzemeOzelligi.TabIndex = 47;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(131, 21);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Malzeme Özelliği:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(66, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 21);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "İşlemin Adı:";
            // 
            // textEditIslemAdi
            // 
            this.textEditIslemAdi.Location = new System.Drawing.Point(161, 83);
            this.textEditIslemAdi.Name = "textEditIslemAdi";
            // 
            // 
            // 
            this.textEditIslemAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditIslemAdi.Properties.Appearance.Options.UseFont = true;
            this.textEditIslemAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditIslemAdi.Properties.Items.AddRange(new object[] {
            "Lazer Kesim",
            "Büküm",
            "Kaynak",
            "Kaplama",
            "Havşa Açma",
            "Diş Açma",
            "Maskeleme Bandı",
            "Boya"});
            this.textEditIslemAdi.Size = new System.Drawing.Size(147, 26);
            this.textEditIslemAdi.TabIndex = 46;
            // 
            // frmVerilerIslemUcretleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerilerIslemUcretleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerilerIslemUcretleri";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDakikaFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBirimFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMalzemeOzelligi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIslemAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelle;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditMalzemeOzelligi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditDakikaFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditBirimFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Ozellik;
        private System.Windows.Forms.ColumnHeader BirimFiyat;
        private System.Windows.Forms.ColumnHeader DakikaFiyat;
        private DevExpress.XtraEditors.ComboBoxEdit textEditIslemAdi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
    }
}