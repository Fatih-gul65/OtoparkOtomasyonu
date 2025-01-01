namespace OtoparkOtomasyon
{
    partial class RaporOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporOlustur));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagridRapor = new System.Windows.Forms.DataGridView();
            this.btnSonuclariListele = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcelAktar = new Guna.UI2.WinForms.Guna2Button();
            this.lblGunlukKazanc = new System.Windows.Forms.Label();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAracTuruSorgula = new System.Windows.Forms.TextBox();
            this.rdbtnAracTuruSorgula = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtUcretSorgula = new System.Windows.Forms.TextBox();
            this.rdbtnUcretSorgula = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtPlakaSorgula = new System.Windows.Forms.TextBox();
            this.rdbtnPlakaSorgula = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.rdbtnTarihSorgula = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblHaftalikKazanc = new System.Windows.Forms.Label();
            this.lblAylikKazanc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRapor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(459, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // datagridRapor
            // 
            this.datagridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRapor.Location = new System.Drawing.Point(530, 185);
            this.datagridRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridRapor.Name = "datagridRapor";
            this.datagridRapor.RowHeadersWidth = 51;
            this.datagridRapor.RowTemplate.Height = 24;
            this.datagridRapor.Size = new System.Drawing.Size(716, 363);
            this.datagridRapor.TabIndex = 33;
            // 
            // btnSonuclariListele
            // 
            this.btnSonuclariListele.BorderRadius = 15;
            this.btnSonuclariListele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSonuclariListele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSonuclariListele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSonuclariListele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSonuclariListele.FillColor = System.Drawing.Color.White;
            this.btnSonuclariListele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSonuclariListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnSonuclariListele.Location = new System.Drawing.Point(148, 298);
            this.btnSonuclariListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonuclariListele.Name = "btnSonuclariListele";
            this.btnSonuclariListele.Size = new System.Drawing.Size(185, 53);
            this.btnSonuclariListele.TabIndex = 34;
            this.btnSonuclariListele.Text = "Sonuçları Listele";
            this.btnSonuclariListele.Click += new System.EventHandler(this.btnSonuclariListele_Click);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BorderRadius = 15;
            this.btnExcelAktar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelAktar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelAktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelAktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelAktar.FillColor = System.Drawing.Color.White;
            this.btnExcelAktar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelAktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.Image")));
            this.btnExcelAktar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcelAktar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExcelAktar.Location = new System.Drawing.Point(1003, 634);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExcelAktar.Size = new System.Drawing.Size(252, 53);
            this.btnExcelAktar.TabIndex = 35;
            this.btnExcelAktar.Text = "Bilgileri Excel Tablosuna Aktar";
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // lblGunlukKazanc
            // 
            this.lblGunlukKazanc.AutoSize = true;
            this.lblGunlukKazanc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukKazanc.ForeColor = System.Drawing.Color.White;
            this.lblGunlukKazanc.Location = new System.Drawing.Point(929, 18);
            this.lblGunlukKazanc.Name = "lblGunlukKazanc";
            this.lblGunlukKazanc.Size = new System.Drawing.Size(16, 24);
            this.lblGunlukKazanc.TabIndex = 37;
            this.lblGunlukKazanc.Text = " ";
            // 
            // btnGeri
            // 
            this.btnGeri.BorderRadius = 15;
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
            this.btnGeri.Location = new System.Drawing.Point(51, 634);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(180, 46);
            this.btnGeri.TabIndex = 50;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAracTuruSorgula);
            this.groupBox1.Controls.Add(this.rdbtnAracTuruSorgula);
            this.groupBox1.Controls.Add(this.txtUcretSorgula);
            this.groupBox1.Controls.Add(this.rdbtnUcretSorgula);
            this.groupBox1.Controls.Add(this.txtPlakaSorgula);
            this.groupBox1.Controls.Add(this.rdbtnPlakaSorgula);
            this.groupBox1.Controls.Add(this.btnSonuclariListele);
            this.groupBox1.Controls.Add(this.dateTimePickerGirisTarihi);
            this.groupBox1.Controls.Add(this.rdbtnTarihSorgula);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(475, 373);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapmak İstediğiniz İşlemi Seçiniz !";
            // 
            // txtAracTuruSorgula
            // 
            this.txtAracTuruSorgula.Location = new System.Drawing.Point(290, 85);
            this.txtAracTuruSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAracTuruSorgula.Name = "txtAracTuruSorgula";
            this.txtAracTuruSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtAracTuruSorgula.TabIndex = 63;
            this.txtAracTuruSorgula.Visible = false;
            this.txtAracTuruSorgula.TextChanged += new System.EventHandler(this.txtAracTuruSorgula_TextChanged);
            // 
            // rdbtnAracTuruSorgula
            // 
            this.rdbtnAracTuruSorgula.AutoSize = true;
            this.rdbtnAracTuruSorgula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnAracTuruSorgula.CheckedState.BorderThickness = 0;
            this.rdbtnAracTuruSorgula.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.rdbtnAracTuruSorgula.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnAracTuruSorgula.CheckedState.InnerOffset = -4;
            this.rdbtnAracTuruSorgula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdbtnAracTuruSorgula.ForeColor = System.Drawing.Color.White;
            this.rdbtnAracTuruSorgula.Location = new System.Drawing.Point(290, 42);
            this.rdbtnAracTuruSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnAracTuruSorgula.Name = "rdbtnAracTuruSorgula";
            this.rdbtnAracTuruSorgula.Size = new System.Drawing.Size(171, 23);
            this.rdbtnAracTuruSorgula.TabIndex = 62;
            this.rdbtnAracTuruSorgula.Text = "Araç Türüne Göre";
            this.rdbtnAracTuruSorgula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnAracTuruSorgula.UncheckedState.BorderThickness = 2;
            this.rdbtnAracTuruSorgula.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnAracTuruSorgula.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnAracTuruSorgula.CheckedChanged += new System.EventHandler(this.rdbtnAracTuruSorgula_CheckedChanged);
            // 
            // txtUcretSorgula
            // 
            this.txtUcretSorgula.Location = new System.Drawing.Point(290, 218);
            this.txtUcretSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUcretSorgula.Name = "txtUcretSorgula";
            this.txtUcretSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtUcretSorgula.TabIndex = 60;
            this.txtUcretSorgula.Visible = false;
            this.txtUcretSorgula.TextChanged += new System.EventHandler(this.txtUcretSorgula_TextChanged);
            // 
            // rdbtnUcretSorgula
            // 
            this.rdbtnUcretSorgula.AutoSize = true;
            this.rdbtnUcretSorgula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnUcretSorgula.CheckedState.BorderThickness = 0;
            this.rdbtnUcretSorgula.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.rdbtnUcretSorgula.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnUcretSorgula.CheckedState.InnerOffset = -4;
            this.rdbtnUcretSorgula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdbtnUcretSorgula.ForeColor = System.Drawing.Color.White;
            this.rdbtnUcretSorgula.Location = new System.Drawing.Point(290, 175);
            this.rdbtnUcretSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnUcretSorgula.Name = "rdbtnUcretSorgula";
            this.rdbtnUcretSorgula.Size = new System.Drawing.Size(126, 23);
            this.rdbtnUcretSorgula.TabIndex = 59;
            this.rdbtnUcretSorgula.Text = "Ücrete Göre";
            this.rdbtnUcretSorgula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnUcretSorgula.UncheckedState.BorderThickness = 2;
            this.rdbtnUcretSorgula.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnUcretSorgula.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnUcretSorgula.CheckedChanged += new System.EventHandler(this.rdbtnUcretSorgula_CheckedChanged);
            // 
            // txtPlakaSorgula
            // 
            this.txtPlakaSorgula.Location = new System.Drawing.Point(16, 218);
            this.txtPlakaSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlakaSorgula.Name = "txtPlakaSorgula";
            this.txtPlakaSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtPlakaSorgula.TabIndex = 57;
            this.txtPlakaSorgula.Visible = false;
            this.txtPlakaSorgula.TextChanged += new System.EventHandler(this.txtPlakaSorgula_TextChanged);
            // 
            // rdbtnPlakaSorgula
            // 
            this.rdbtnPlakaSorgula.AutoSize = true;
            this.rdbtnPlakaSorgula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnPlakaSorgula.CheckedState.BorderThickness = 0;
            this.rdbtnPlakaSorgula.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.rdbtnPlakaSorgula.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnPlakaSorgula.CheckedState.InnerOffset = -4;
            this.rdbtnPlakaSorgula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnPlakaSorgula.ForeColor = System.Drawing.Color.White;
            this.rdbtnPlakaSorgula.Location = new System.Drawing.Point(16, 175);
            this.rdbtnPlakaSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnPlakaSorgula.Name = "rdbtnPlakaSorgula";
            this.rdbtnPlakaSorgula.Size = new System.Drawing.Size(200, 23);
            this.rdbtnPlakaSorgula.TabIndex = 56;
            this.rdbtnPlakaSorgula.Text = "Plakaya Göre Sorgula";
            this.rdbtnPlakaSorgula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnPlakaSorgula.UncheckedState.BorderThickness = 2;
            this.rdbtnPlakaSorgula.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnPlakaSorgula.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnPlakaSorgula.CheckedChanged += new System.EventHandler(this.rdbtnPlakaSorgula_CheckedChanged);
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(16, 84);
            this.dateTimePickerGirisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerGirisTarihi.TabIndex = 53;
            this.dateTimePickerGirisTarihi.Visible = false;
            this.dateTimePickerGirisTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerGirisTarihi_ValueChanged);
            // 
            // rdbtnTarihSorgula
            // 
            this.rdbtnTarihSorgula.AutoSize = true;
            this.rdbtnTarihSorgula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnTarihSorgula.CheckedState.BorderThickness = 0;
            this.rdbtnTarihSorgula.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.rdbtnTarihSorgula.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnTarihSorgula.CheckedState.InnerOffset = -4;
            this.rdbtnTarihSorgula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdbtnTarihSorgula.ForeColor = System.Drawing.Color.White;
            this.rdbtnTarihSorgula.Location = new System.Drawing.Point(16, 42);
            this.rdbtnTarihSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnTarihSorgula.Name = "rdbtnTarihSorgula";
            this.rdbtnTarihSorgula.Size = new System.Drawing.Size(122, 23);
            this.rdbtnTarihSorgula.TabIndex = 52;
            this.rdbtnTarihSorgula.Text = "Tarihe Göre";
            this.rdbtnTarihSorgula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnTarihSorgula.UncheckedState.BorderThickness = 2;
            this.rdbtnTarihSorgula.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnTarihSorgula.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnTarihSorgula.CheckedChanged += new System.EventHandler(this.rdbtnTarihSorgula_CheckedChanged);
            // 
            // lblHaftalikKazanc
            // 
            this.lblHaftalikKazanc.AutoSize = true;
            this.lblHaftalikKazanc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftalikKazanc.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikKazanc.Location = new System.Drawing.Point(929, 62);
            this.lblHaftalikKazanc.Name = "lblHaftalikKazanc";
            this.lblHaftalikKazanc.Size = new System.Drawing.Size(16, 24);
            this.lblHaftalikKazanc.TabIndex = 57;
            this.lblHaftalikKazanc.Text = " ";
            // 
            // lblAylikKazanc
            // 
            this.lblAylikKazanc.AutoSize = true;
            this.lblAylikKazanc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikKazanc.ForeColor = System.Drawing.Color.White;
            this.lblAylikKazanc.Location = new System.Drawing.Point(929, 108);
            this.lblAylikKazanc.Name = "lblAylikKazanc";
            this.lblAylikKazanc.Size = new System.Drawing.Size(16, 24);
            this.lblAylikKazanc.TabIndex = 58;
            this.lblAylikKazanc.Text = " ";
            // 
            // RaporOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1291, 700);
            this.Controls.Add(this.lblAylikKazanc);
            this.Controls.Add(this.lblHaftalikKazanc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblGunlukKazanc);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.datagridRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RaporOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporOlustur";
            this.Load += new System.EventHandler(this.RaporOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRapor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagridRapor;
        private Guna.UI2.WinForms.Guna2Button btnSonuclariListele;
        private Guna.UI2.WinForms.Guna2Button btnExcelAktar;
        private System.Windows.Forms.Label lblGunlukKazanc;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAracTuruSorgula;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnAracTuruSorgula;
        private System.Windows.Forms.TextBox txtUcretSorgula;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnUcretSorgula;
        private System.Windows.Forms.TextBox txtPlakaSorgula;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnPlakaSorgula;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnTarihSorgula;
        private System.Windows.Forms.Label lblHaftalikKazanc;
        private System.Windows.Forms.Label lblAylikKazanc;
    }
}