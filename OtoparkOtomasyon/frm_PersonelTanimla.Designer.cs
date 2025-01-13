namespace OtoparkOtomasyon
{
    partial class frm_PersonelTanimla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonelTanimla));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKullaniciEkle = new Guna.UI2.WinForms.Guna2Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnKullaniciSil = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSecilenKullaniciyiGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridPersonelTanimla = new System.Windows.Forms.DataGridView();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersonelTanimla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKullaniciID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKullaniciEkle);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtKullaniciSifre);
            this.groupBox1.Controls.Add(this.btnKullaniciSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSecilenKullaniciyiGuncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datagridPersonelTanimla);
            this.groupBox1.Location = new System.Drawing.Point(45, 179);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1081, 440);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Enabled = false;
            this.txtKullaniciID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.Location = new System.Drawing.Point(204, 95);
            this.txtKullaniciID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(180, 27);
            this.txtKullaniciID.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Kullanıcı ID      : ";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BorderRadius = 15;
            this.btnKullaniciEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKullaniciEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKullaniciEkle.FillColor = System.Drawing.Color.White;
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnKullaniciEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.Image")));
            this.btnKullaniciEkle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKullaniciEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKullaniciEkle.Location = new System.Drawing.Point(5, 234);
            this.btnKullaniciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnKullaniciEkle.Size = new System.Drawing.Size(205, 53);
            this.btnKullaniciEkle.TabIndex = 52;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(204, 137);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(180, 27);
            this.txtKullaniciAdi.TabIndex = 42;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(204, 180);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(180, 27);
            this.txtKullaniciSifre.TabIndex = 44;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BorderRadius = 15;
            this.btnKullaniciSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKullaniciSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKullaniciSil.FillColor = System.Drawing.Color.White;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnKullaniciSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciSil.Image")));
            this.btnKullaniciSil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKullaniciSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKullaniciSil.Location = new System.Drawing.Point(216, 234);
            this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnKullaniciSil.Size = new System.Drawing.Size(205, 53);
            this.btnKullaniciSil.TabIndex = 51;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kullanıcı Şifre : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(662, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kullanıcı Silmek veya Güncellemek İçin Lütfen Tablodan Kayıt Seçiniz";
            // 
            // btnSecilenKullaniciyiGuncelle
            // 
            this.btnSecilenKullaniciyiGuncelle.BorderRadius = 15;
            this.btnSecilenKullaniciyiGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecilenKullaniciyiGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecilenKullaniciyiGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecilenKullaniciyiGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecilenKullaniciyiGuncelle.FillColor = System.Drawing.Color.White;
            this.btnSecilenKullaniciyiGuncelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenKullaniciyiGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnSecilenKullaniciyiGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnSecilenKullaniciyiGuncelle.Image")));
            this.btnSecilenKullaniciyiGuncelle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSecilenKullaniciyiGuncelle.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnSecilenKullaniciyiGuncelle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSecilenKullaniciyiGuncelle.Location = new System.Drawing.Point(5, 327);
            this.btnSecilenKullaniciyiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecilenKullaniciyiGuncelle.Name = "btnSecilenKullaniciyiGuncelle";
            this.btnSecilenKullaniciyiGuncelle.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSecilenKullaniciyiGuncelle.Size = new System.Drawing.Size(416, 62);
            this.btnSecilenKullaniciyiGuncelle.TabIndex = 47;
            this.btnSecilenKullaniciyiGuncelle.Text = "Seçilen Kullanıcıyı Güncelle";
            this.btnSecilenKullaniciyiGuncelle.Click += new System.EventHandler(this.btnSecilenKullaniciyiGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kullanıcı Adı    : ";
            // 
            // datagridPersonelTanimla
            // 
            this.datagridPersonelTanimla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPersonelTanimla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPersonelTanimla.Location = new System.Drawing.Point(427, 95);
            this.datagridPersonelTanimla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridPersonelTanimla.Name = "datagridPersonelTanimla";
            this.datagridPersonelTanimla.RowHeadersWidth = 51;
            this.datagridPersonelTanimla.RowTemplate.Height = 24;
            this.datagridPersonelTanimla.Size = new System.Drawing.Size(648, 293);
            this.datagridPersonelTanimla.TabIndex = 40;
            this.datagridPersonelTanimla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPersonelTanimla_CellClick);
            // 
            // btnGeri
            // 
            this.btnGeri.BorderRadius = 15;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeri.FillColor = System.Drawing.Color.White;
            this.btnGeri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGeri.ImageSize = new System.Drawing.Size(30, 35);
            this.btnGeri.Location = new System.Drawing.Point(12, 666);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(180, 46);
            this.btnGeri.TabIndex = 48;
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
            this.guna2ControlBox3.TabIndex = 51;
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
            this.guna2ControlBox2.TabIndex = 50;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1113, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 49;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frm_PersonelTanimla
            // 
            this.AcceptButton = this.btnKullaniciEkle;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_PersonelTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelTanimla";
            this.Load += new System.EventHandler(this.PersonelTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersonelTanimla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnSecilenKullaniciyiGuncelle;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridPersonelTanimla;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private Guna.UI2.WinForms.Guna2Button btnKullaniciSil;
        private Guna.UI2.WinForms.Guna2Button btnKullaniciEkle;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}