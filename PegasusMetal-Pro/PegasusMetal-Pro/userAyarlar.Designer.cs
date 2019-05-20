namespace PegasusMetal_Pro
{
    partial class userAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAyarlar));
            this.ARollerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ARollerBtn
            // 
            this.ARollerBtn.AutoEllipsis = true;
            this.ARollerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ARollerBtn.BackgroundImage")));
            this.ARollerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ARollerBtn.FlatAppearance.BorderSize = 0;
            this.ARollerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARollerBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARollerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ARollerBtn.Image = ((System.Drawing.Image)(resources.GetObject("ARollerBtn.Image")));
            this.ARollerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ARollerBtn.Location = new System.Drawing.Point(287, 237);
            this.ARollerBtn.Name = "ARollerBtn";
            this.ARollerBtn.Size = new System.Drawing.Size(314, 145);
            this.ARollerBtn.TabIndex = 6;
            this.ARollerBtn.Text = "Roller\r\n\r\n";
            this.ARollerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ARollerBtn.UseVisualStyleBackColor = true;
            // 
            // userAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ARollerBtn);
            this.Name = "userAyarlar";
            this.Size = new System.Drawing.Size(888, 619);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ARollerBtn;
    }
}
