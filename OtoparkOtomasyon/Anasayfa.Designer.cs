namespace OtoparkOtomasyon
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYoneticiGiris = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonelGiris = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BorderRadius = 20;
            this.btnYoneticiGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYoneticiGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYoneticiGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYoneticiGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYoneticiGiris.FillColor = System.Drawing.Color.White;
            this.btnYoneticiGiris.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnYoneticiGiris.Location = new System.Drawing.Point(145, 366);
            this.btnYoneticiGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(218, 107);
            this.btnYoneticiGiris.TabIndex = 37;
            this.btnYoneticiGiris.Text = "Yönetici Girişi";
            this.btnYoneticiGiris.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BorderRadius = 20;
            this.btnPersonelGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersonelGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersonelGiris.FillColor = System.Drawing.Color.White;
            this.btnPersonelGiris.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPersonelGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnPersonelGiris.Location = new System.Drawing.Point(596, 366);
            this.btnPersonelGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(218, 107);
            this.btnPersonelGiris.TabIndex = 38;
            this.btnPersonelGiris.Text = "Personel Girişi";
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 488);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(968, 569);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnYoneticiGiris;
        private Guna.UI2.WinForms.Guna2Button btnPersonelGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}