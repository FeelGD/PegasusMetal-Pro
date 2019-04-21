namespace PegasusMetal_Pro
{
    partial class frmVerilerStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerilerStok));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButtonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFiyat = new DevExpress.XtraEditors.TextEdit();
            this.textEditMiktar = new DevExpress.XtraEditors.TextEdit();
            this.textEditUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButtonArttir = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUrunAdiGoruntule = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdiGoruntule.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(971, 41);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(901, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(936, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 527);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Kategori,
            this.Ad,
            this.Miktar,
            this.Tutar});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 527);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Stok Numarası";
            this.Id.Width = 91;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Ürün Kategorisi";
            this.Kategori.Width = 91;
            // 
            // Ad
            // 
            this.Ad.Text = "Ürün Adı";
            this.Ad.Width = 134;
            // 
            // Tutar
            // 
            this.Tutar.DisplayIndex = 3;
            this.Tutar.Text = "Ürün Fiyatı";
            this.Tutar.Width = 113;
            // 
            // Miktar
            // 
            this.Miktar.DisplayIndex = 4;
            this.Miktar.Text = "Ürünün Miktarı";
            this.Miktar.Width = 144;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.simpleButtonGuncelle);
            this.panel3.Controls.Add(this.textEditId);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Controls.Add(this.simpleButtonKaydet);
            this.panel3.Controls.Add(this.textEditFiyat);
            this.panel3.Controls.Add(this.textEditMiktar);
            this.panel3.Controls.Add(this.textEditUrunAdi);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.textEditKategori);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(585, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 337);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.simpleButtonArttir);
            this.panel4.Controls.Add(this.textEditUrunAdiGoruntule);
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(585, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 190);
            this.panel4.TabIndex = 5;
            // 
            // simpleButtonGuncelle
            // 
            this.simpleButtonGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonGuncelle.Appearance.Options.UseFont = true;
            this.simpleButtonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuncelle.ImageOptions.Image")));
            this.simpleButtonGuncelle.Location = new System.Drawing.Point(33, 286);
            this.simpleButtonGuncelle.Name = "simpleButtonGuncelle";
            this.simpleButtonGuncelle.Size = new System.Drawing.Size(323, 46);
            this.simpleButtonGuncelle.TabIndex = 36;
            this.simpleButtonGuncelle.Text = "STOK GÜNCELLE";
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(173, 5);
            this.textEditId.Name = "textEditId";
            this.textEditId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditId.Properties.Appearance.Options.UseFont = true;
            this.textEditId.Size = new System.Drawing.Size(183, 26);
            this.textEditId.TabIndex = 35;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(50, 7);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 21);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Stok Numarası:";
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.simpleButtonKaydet.Appearance.Options.UseFont = true;
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(33, 226);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(323, 47);
            this.simpleButtonKaydet.TabIndex = 33;
            this.simpleButtonKaydet.Text = "STOK KAYDET";
            // 
            // textEditFiyat
            // 
            this.textEditFiyat.EditValue = "";
            this.textEditFiyat.Location = new System.Drawing.Point(173, 191);
            this.textEditFiyat.Name = "textEditFiyat";
            this.textEditFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditFiyat.Properties.Appearance.Options.UseFont = true;
            this.textEditFiyat.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEditFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEditFiyat.Size = new System.Drawing.Size(183, 26);
            this.textEditFiyat.TabIndex = 32;
            // 
            // textEditMiktar
            // 
            this.textEditMiktar.Location = new System.Drawing.Point(173, 148);
            this.textEditMiktar.Name = "textEditMiktar";
            this.textEditMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditMiktar.Properties.Appearance.Options.UseFont = true;
            this.textEditMiktar.Size = new System.Drawing.Size(183, 26);
            this.textEditMiktar.TabIndex = 31;
            // 
            // textEditUrunAdi
            // 
            this.textEditUrunAdi.Location = new System.Drawing.Point(173, 102);
            this.textEditUrunAdi.Name = "textEditUrunAdi";
            this.textEditUrunAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditUrunAdi.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunAdi.Size = new System.Drawing.Size(183, 26);
            this.textEditUrunAdi.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(117, 196);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 21);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Fiyatı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(107, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 21);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Miktarı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(93, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 21);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Ürün Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Kategorisi:";
            // 
            // textEditKategori
            // 
            this.textEditKategori.Location = new System.Drawing.Point(173, 55);
            this.textEditKategori.Name = "textEditKategori";
            this.textEditKategori.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditKategori.Properties.Appearance.Options.UseFont = true;
            this.textEditKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditKategori.Properties.DropDownRows = 2;
            this.textEditKategori.Properties.Items.AddRange(new object[] {
            "Sarf Malzeme",
            "Hazır Malzeme",
            "Bağlantı Elemanı"});
            this.textEditKategori.Size = new System.Drawing.Size(183, 26);
            this.textEditKategori.TabIndex = 29;
            // 
            // simpleButtonArttir
            // 
            this.simpleButtonArttir.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonArttir.Appearance.Options.UseFont = true;
            this.simpleButtonArttir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonArttir.ImageOptions.Image")));
            this.simpleButtonArttir.Location = new System.Drawing.Point(117, 110);
            this.simpleButtonArttir.Name = "simpleButtonArttir";
            this.simpleButtonArttir.Size = new System.Drawing.Size(197, 67);
            this.simpleButtonArttir.TabIndex = 26;
            this.simpleButtonArttir.Text = "KATEGORİ EKLE";
            // 
            // textEditUrunAdiGoruntule
            // 
            this.textEditUrunAdiGoruntule.Enabled = false;
            this.textEditUrunAdiGoruntule.Location = new System.Drawing.Point(163, 33);
            this.textEditUrunAdiGoruntule.Name = "textEditUrunAdiGoruntule";
            this.textEditUrunAdiGoruntule.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.textEditUrunAdiGoruntule.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunAdiGoruntule.Size = new System.Drawing.Size(187, 26);
            this.textEditUrunAdiGoruntule.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(53, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 21);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Kategori Adı:";
            // 
            // frmVerilerStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerilerStok";
            this.Text = "frmVerilerStok";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdiGoruntule.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.ColumnHeader Tutar;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelle;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditFiyat;
        private DevExpress.XtraEditors.TextEdit textEditMiktar;
        private DevExpress.XtraEditors.TextEdit textEditUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit textEditKategori;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonArttir;
        private DevExpress.XtraEditors.TextEdit textEditUrunAdiGoruntule;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}