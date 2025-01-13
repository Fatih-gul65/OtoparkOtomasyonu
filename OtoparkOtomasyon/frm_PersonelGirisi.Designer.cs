namespace OtoparkOtomasyon
{
    partial class frm_PersonelGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonelGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAracGiris = new Guna.UI2.WinForms.Guna2Button();
            this.btnAracCikis = new Guna.UI2.WinForms.Guna2Button();
            this.btnAboneEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnAboneListele = new Guna.UI2.WinForms.Guna2Button();
            this.btnOtoparkDoluluk = new Guna.UI2.WinForms.Guna2Button();
            this.btnAracBul = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnAracGiris
            // 
            this.btnAracGiris.BorderRadius = 15;
            this.btnAracGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAracGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAracGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAracGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAracGiris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAracGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAracGiris.ForeColor = System.Drawing.Color.Black;
            this.btnAracGiris.Location = new System.Drawing.Point(46, 281);
            this.btnAracGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracGiris.Name = "btnAracGiris";
            this.btnAracGiris.Size = new System.Drawing.Size(292, 111);
            this.btnAracGiris.TabIndex = 22;
            this.btnAracGiris.Text = "Araç Giriş";
            this.btnAracGiris.Click += new System.EventHandler(this.btnAracGiris_Click_1);
            // 
            // btnAracCikis
            // 
            this.btnAracCikis.BorderRadius = 15;
            this.btnAracCikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAracCikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAracCikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAracCikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAracCikis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAracCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAracCikis.ForeColor = System.Drawing.Color.Black;
            this.btnAracCikis.Location = new System.Drawing.Point(46, 441);
            this.btnAracCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracCikis.Name = "btnAracCikis";
            this.btnAracCikis.Size = new System.Drawing.Size(292, 111);
            this.btnAracCikis.TabIndex = 22;
            this.btnAracCikis.Text = "Araç Çıkış";
            this.btnAracCikis.Click += new System.EventHandler(this.btnAracCikis_Click_1);
            // 
            // btnAboneEkle
            // 
            this.btnAboneEkle.BorderRadius = 15;
            this.btnAboneEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAboneEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAboneEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAboneEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAboneEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAboneEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAboneEkle.ForeColor = System.Drawing.Color.Black;
            this.btnAboneEkle.Location = new System.Drawing.Point(810, 281);
            this.btnAboneEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboneEkle.Name = "btnAboneEkle";
            this.btnAboneEkle.Size = new System.Drawing.Size(292, 111);
            this.btnAboneEkle.TabIndex = 22;
            this.btnAboneEkle.Text = "Abone Ekle";
            this.btnAboneEkle.Click += new System.EventHandler(this.btnAboneEkle_Click_1);
            // 
            // btnAboneListele
            // 
            this.btnAboneListele.BorderRadius = 15;
            this.btnAboneListele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAboneListele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAboneListele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAboneListele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAboneListele.FillColor = System.Drawing.Color.Aqua;
            this.btnAboneListele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAboneListele.ForeColor = System.Drawing.Color.Black;
            this.btnAboneListele.Location = new System.Drawing.Point(810, 441);
            this.btnAboneListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboneListele.Name = "btnAboneListele";
            this.btnAboneListele.Size = new System.Drawing.Size(292, 111);
            this.btnAboneListele.TabIndex = 22;
            this.btnAboneListele.Text = "Aboneleri Listele";
            this.btnAboneListele.Click += new System.EventHandler(this.btnAboneListele_Click_1);
            // 
            // btnOtoparkDoluluk
            // 
            this.btnOtoparkDoluluk.BorderRadius = 15;
            this.btnOtoparkDoluluk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOtoparkDoluluk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOtoparkDoluluk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOtoparkDoluluk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOtoparkDoluluk.FillColor = System.Drawing.Color.Yellow;
            this.btnOtoparkDoluluk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOtoparkDoluluk.ForeColor = System.Drawing.Color.Black;
            this.btnOtoparkDoluluk.Location = new System.Drawing.Point(426, 281);
            this.btnOtoparkDoluluk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtoparkDoluluk.Name = "btnOtoparkDoluluk";
            this.btnOtoparkDoluluk.Size = new System.Drawing.Size(292, 111);
            this.btnOtoparkDoluluk.TabIndex = 22;
            this.btnOtoparkDoluluk.Text = "Otopoark Doluluk";
            this.btnOtoparkDoluluk.Click += new System.EventHandler(this.btnOtoparkDoluluk_Click_1);
            // 
            // btnAracBul
            // 
            this.btnAracBul.BorderRadius = 15;
            this.btnAracBul.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAracBul.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAracBul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAracBul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAracBul.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAracBul.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAracBul.ForeColor = System.Drawing.Color.Black;
            this.btnAracBul.Location = new System.Drawing.Point(426, 441);
            this.btnAracBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracBul.Name = "btnAracBul";
            this.btnAracBul.Size = new System.Drawing.Size(292, 111);
            this.btnAracBul.TabIndex = 22;
            this.btnAracBul.Text = "Araç Bul";
            this.btnAracBul.Click += new System.EventHandler(this.btnAracBul_Click_1);
            // 
            // btnGeri
            // 
            this.btnGeri.BorderRadius = 15;
            this.btnGeri.BorderThickness = 1;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.btnGeri.Location = new System.Drawing.Point(13, 655);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(209, 55);
            this.btnGeri.TabIndex = 25;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1011, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 49;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1062, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 48;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1113, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 47;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frm_PersonelGirisi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.btnAracCikis);
            this.Controls.Add(this.btnAracGiris);
            this.Controls.Add(this.btnAracBul);
            this.Controls.Add(this.btnOtoparkDoluluk);
            this.Controls.Add(this.btnAboneListele);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.btnAboneEkle);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_PersonelGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAracGiris;
        private Guna.UI2.WinForms.Guna2Button btnAracCikis;
        private Guna.UI2.WinForms.Guna2Button btnAboneEkle;
        private Guna.UI2.WinForms.Guna2Button btnAboneListele;
        private Guna.UI2.WinForms.Guna2Button btnOtoparkDoluluk;
        private Guna.UI2.WinForms.Guna2Button btnAracBul;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}