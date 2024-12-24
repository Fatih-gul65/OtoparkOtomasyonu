namespace OtoparkOtomasyon
{
    partial class abonelikForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abonelikForm4));
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiyatGoster = new Guna.UI2.WinForms.Guna2Button();
            this.cmbAracTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAbonelikSuresi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAracPlakasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BorderRadius = 15;
            this.btnGeri.BorderThickness = 1;
            this.btnGeri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeri.FillColor = System.Drawing.Color.White;
            this.btnGeri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGeri.ImageSize = new System.Drawing.Size(30, 35);
            this.btnGeri.Location = new System.Drawing.Point(50, 634);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(180, 45);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiyatGoster);
            this.groupBox1.Controls.Add(this.cmbAracTuru);
            this.groupBox1.Controls.Add(this.cmbAbonelikSuresi);
            this.groupBox1.Controls.Add(this.txtAracPlakasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTutar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(311, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 324);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abonelik İşlemleri";
            // 
            // btnFiyatGoster
            // 
            this.btnFiyatGoster.BorderRadius = 15;
            this.btnFiyatGoster.BorderThickness = 1;
            this.btnFiyatGoster.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiyatGoster.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiyatGoster.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiyatGoster.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiyatGoster.FillColor = System.Drawing.Color.White;
            this.btnFiyatGoster.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiyatGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnFiyatGoster.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFiyatGoster.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFiyatGoster.Location = new System.Drawing.Point(503, 241);
            this.btnFiyatGoster.Name = "btnFiyatGoster";
            this.btnFiyatGoster.Size = new System.Drawing.Size(180, 45);
            this.btnFiyatGoster.TabIndex = 22;
            this.btnFiyatGoster.Text = "Fiyat Göster";
            this.btnFiyatGoster.Click += new System.EventHandler(this.btnFiyatGoster_Click);
            // 
            // cmbAracTuru
            // 
            this.cmbAracTuru.BackColor = System.Drawing.Color.Transparent;
            this.cmbAracTuru.BorderRadius = 15;
            this.cmbAracTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAracTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAracTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAracTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAracTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAracTuru.ItemHeight = 30;
            this.cmbAracTuru.Location = new System.Drawing.Point(92, 94);
            this.cmbAracTuru.Name = "cmbAracTuru";
            this.cmbAracTuru.Size = new System.Drawing.Size(140, 36);
            this.cmbAracTuru.TabIndex = 21;
            // 
            // cmbAbonelikSuresi
            // 
            this.cmbAbonelikSuresi.BackColor = System.Drawing.Color.Transparent;
            this.cmbAbonelikSuresi.BorderRadius = 15;
            this.cmbAbonelikSuresi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAbonelikSuresi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbonelikSuresi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAbonelikSuresi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAbonelikSuresi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAbonelikSuresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAbonelikSuresi.ItemHeight = 30;
            this.cmbAbonelikSuresi.Location = new System.Drawing.Point(484, 94);
            this.cmbAbonelikSuresi.Name = "cmbAbonelikSuresi";
            this.cmbAbonelikSuresi.Size = new System.Drawing.Size(140, 36);
            this.cmbAbonelikSuresi.TabIndex = 21;
            // 
            // txtAracPlakasi
            // 
            this.txtAracPlakasi.Location = new System.Drawing.Point(365, 210);
            this.txtAracPlakasi.Name = "txtAracPlakasi";
            this.txtAracPlakasi.Size = new System.Drawing.Size(100, 26);
            this.txtAracPlakasi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(462, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Abonelik Süresi Seçiniz!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Araç Türü Seçiniz!";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.ForeColor = System.Drawing.Color.White;
            this.lblTutar.Location = new System.Drawing.Point(393, 280);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(37, 19);
            this.lblTutar.TabIndex = 19;
            this.lblTutar.Text = "..TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(258, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Araç Plakası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderRadius = 15;
            this.btnKaydet.BorderThickness = 1;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKaydet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKaydet.Location = new System.Drawing.Point(1060, 634);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKaydet.Size = new System.Drawing.Size(180, 45);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // abonelikForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1292, 708);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "abonelikForm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abonelikForm4";
            this.Load += new System.EventHandler(this.abonelikForm4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAracPlakasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAracTuru;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAbonelikSuresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnFiyatGoster;
    }
}