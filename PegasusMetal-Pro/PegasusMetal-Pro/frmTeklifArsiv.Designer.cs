namespace PegasusMetal_Pro
{
    partial class frmTeklifArsiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeklifArsiv));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostumerNmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfferSituation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTeklifDurumDegistir = new System.Windows.Forms.Button();
            this.btnTeklifTekrarla = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 41);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(607, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(642, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 343);
            this.panel1.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProjectName,
            this.CostumerNmae,
            this.OfferSituation,
            this.TotalPrize});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(677, 343);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnTeklifTekrarla);
            this.panel2.Controls.Add(this.btnTeklifDurumDegistir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 74);
            this.panel2.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 86;
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "Proje Adı";
            this.ProjectName.Width = 142;
            // 
            // CostumerNmae
            // 
            this.CostumerNmae.Text = "Firma Adı";
            this.CostumerNmae.Width = 143;
            // 
            // OfferSituation
            // 
            this.OfferSituation.Text = "Teklifin Durumu";
            this.OfferSituation.Width = 159;
            // 
            // TotalPrize
            // 
            this.TotalPrize.Text = "Toplam Ücret";
            this.TotalPrize.Width = 112;
            // 
            // btnTeklifDurumDegistir
            // 
            this.btnTeklifDurumDegistir.AutoEllipsis = true;
            this.btnTeklifDurumDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeklifDurumDegistir.BackgroundImage")));
            this.btnTeklifDurumDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeklifDurumDegistir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTeklifDurumDegistir.FlatAppearance.BorderSize = 0;
            this.btnTeklifDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeklifDurumDegistir.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeklifDurumDegistir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeklifDurumDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnTeklifDurumDegistir.Image")));
            this.btnTeklifDurumDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeklifDurumDegistir.Location = new System.Drawing.Point(356, 0);
            this.btnTeklifDurumDegistir.Name = "btnTeklifDurumDegistir";
            this.btnTeklifDurumDegistir.Size = new System.Drawing.Size(321, 74);
            this.btnTeklifDurumDegistir.TabIndex = 40;
            this.btnTeklifDurumDegistir.Text = "Teklifin Durumunu Değiştir\r\n";
            this.btnTeklifDurumDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeklifDurumDegistir.UseVisualStyleBackColor = true;
            // 
            // btnTeklifTekrarla
            // 
            this.btnTeklifTekrarla.AutoEllipsis = true;
            this.btnTeklifTekrarla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeklifTekrarla.BackgroundImage")));
            this.btnTeklifTekrarla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeklifTekrarla.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTeklifTekrarla.FlatAppearance.BorderSize = 0;
            this.btnTeklifTekrarla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeklifTekrarla.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeklifTekrarla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeklifTekrarla.Image = ((System.Drawing.Image)(resources.GetObject("btnTeklifTekrarla.Image")));
            this.btnTeklifTekrarla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeklifTekrarla.Location = new System.Drawing.Point(129, 0);
            this.btnTeklifTekrarla.Name = "btnTeklifTekrarla";
            this.btnTeklifTekrarla.Size = new System.Drawing.Size(227, 74);
            this.btnTeklifTekrarla.TabIndex = 41;
            this.btnTeklifTekrarla.Text = "Teklifi Tekrarla";
            this.btnTeklifTekrarla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeklifTekrarla.UseVisualStyleBackColor = true;
            // 
            // frmTeklifArsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeklifArsiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTeklifArsiv";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ProjectName;
        private System.Windows.Forms.ColumnHeader CostumerNmae;
        private System.Windows.Forms.ColumnHeader OfferSituation;
        private System.Windows.Forms.ColumnHeader TotalPrize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTeklifTekrarla;
        private System.Windows.Forms.Button btnTeklifDurumDegistir;
    }
}