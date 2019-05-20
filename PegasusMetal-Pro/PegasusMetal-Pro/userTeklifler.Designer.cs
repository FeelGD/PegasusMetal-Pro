namespace PegasusMetal_Pro
{
    partial class userTeklifler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userTeklifler));
            this.TTeklifArsiviBtn = new System.Windows.Forms.Button();
            this.TTekliflerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TTeklifArsiviBtn
            // 
            this.TTeklifArsiviBtn.AutoEllipsis = true;
            this.TTeklifArsiviBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TTeklifArsiviBtn.BackgroundImage")));
            this.TTeklifArsiviBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TTeklifArsiviBtn.FlatAppearance.BorderSize = 0;
            this.TTeklifArsiviBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTeklifArsiviBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTeklifArsiviBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TTeklifArsiviBtn.Image = ((System.Drawing.Image)(resources.GetObject("TTeklifArsiviBtn.Image")));
            this.TTeklifArsiviBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTeklifArsiviBtn.Location = new System.Drawing.Point(462, 119);
            this.TTeklifArsiviBtn.Name = "TTeklifArsiviBtn";
            this.TTeklifArsiviBtn.Size = new System.Drawing.Size(314, 145);
            this.TTeklifArsiviBtn.TabIndex = 7;
            this.TTeklifArsiviBtn.Text = "Teklif Arşivi\r\n\r\n";
            this.TTeklifArsiviBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TTeklifArsiviBtn.UseVisualStyleBackColor = true;
            // 
            // TTekliflerBtn
            // 
            this.TTekliflerBtn.AutoEllipsis = true;
            this.TTekliflerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TTekliflerBtn.BackgroundImage")));
            this.TTekliflerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TTekliflerBtn.FlatAppearance.BorderSize = 0;
            this.TTekliflerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTekliflerBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTekliflerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TTekliflerBtn.Image = ((System.Drawing.Image)(resources.GetObject("TTekliflerBtn.Image")));
            this.TTekliflerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTekliflerBtn.Location = new System.Drawing.Point(113, 119);
            this.TTekliflerBtn.Name = "TTekliflerBtn";
            this.TTekliflerBtn.Size = new System.Drawing.Size(314, 145);
            this.TTekliflerBtn.TabIndex = 5;
            this.TTekliflerBtn.Text = "Teklifler\r\n\r\n";
            this.TTekliflerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TTekliflerBtn.UseVisualStyleBackColor = true;
            this.TTekliflerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTeklifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TTeklifArsiviBtn);
            this.Controls.Add(this.TTekliflerBtn);
            this.Name = "userTeklifler";
            this.Size = new System.Drawing.Size(888, 619);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TTeklifArsiviBtn;
        private System.Windows.Forms.Button TTekliflerBtn;
    }
}
