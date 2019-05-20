namespace PegasusMetal_Pro
{
    partial class userRaporlar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userRaporlar));
            this.RRaporOlusturBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RRaporOlusturBtn
            // 
            this.RRaporOlusturBtn.AutoEllipsis = true;
            this.RRaporOlusturBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RRaporOlusturBtn.BackgroundImage")));
            this.RRaporOlusturBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RRaporOlusturBtn.FlatAppearance.BorderSize = 0;
            this.RRaporOlusturBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RRaporOlusturBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRaporOlusturBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RRaporOlusturBtn.Image = ((System.Drawing.Image)(resources.GetObject("RRaporOlusturBtn.Image")));
            this.RRaporOlusturBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RRaporOlusturBtn.Location = new System.Drawing.Point(287, 237);
            this.RRaporOlusturBtn.Name = "RRaporOlusturBtn";
            this.RRaporOlusturBtn.Size = new System.Drawing.Size(314, 145);
            this.RRaporOlusturBtn.TabIndex = 6;
            this.RRaporOlusturBtn.Text = "Rapor Oluştur\r\n\r\n";
            this.RRaporOlusturBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RRaporOlusturBtn.UseVisualStyleBackColor = true;
            // 
            // userRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.RRaporOlusturBtn);
            this.Name = "userRaporlar";
            this.Size = new System.Drawing.Size(888, 619);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RRaporOlusturBtn;
    }
}
