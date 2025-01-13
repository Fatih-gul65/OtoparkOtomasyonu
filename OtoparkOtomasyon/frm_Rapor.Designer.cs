namespace OtoparkOtomasyon
{
    partial class frm_Rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rapor));
            this.datagridRapor = new System.Windows.Forms.DataGridView();
            this.btnSonuclariListele = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcelAktar = new Guna.UI2.WinForms.Guna2Button();
            this.lblGunlukKazanc = new System.Windows.Forms.Label();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAracTuruSorgula = new System.Windows.Forms.TextBox();
            this.txtUcretSorgula = new System.Windows.Forms.TextBox();
            this.txtPlakaSorgula = new System.Windows.Forms.TextBox();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblHaftalikKazanc = new System.Windows.Forms.Label();
            this.lblAylikKazanc = new System.Windows.Forms.Label();
            this.lblAboneAylik = new System.Windows.Forms.Label();
            this.lblAboneHaftalik = new System.Windows.Forms.Label();
            this.lblAboneGunluk = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRapor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridRapor
            // 
            this.datagridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRapor.Location = new System.Drawing.Point(530, 185);
            this.datagridRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridRapor.Name = "datagridRapor";
            this.datagridRapor.RowHeadersWidth = 51;
            this.datagridRapor.RowTemplate.Height = 24;
            this.datagridRapor.Size = new System.Drawing.Size(628, 363);
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
            this.btnSonuclariListele.Location = new System.Drawing.Point(106, 298);
            this.btnSonuclariListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonuclariListele.Name = "btnSonuclariListele";
            this.btnSonuclariListele.Size = new System.Drawing.Size(239, 58);
            this.btnSonuclariListele.TabIndex = 34;
            this.btnSonuclariListele.Text = "Tüm Sonuçları Listele";
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
            this.btnExcelAktar.Location = new System.Drawing.Point(906, 659);
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
            this.lblGunlukKazanc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukKazanc.ForeColor = System.Drawing.Color.White;
            this.lblGunlukKazanc.Location = new System.Drawing.Point(97, 116);
            this.lblGunlukKazanc.Name = "lblGunlukKazanc";
            this.lblGunlukKazanc.Size = new System.Drawing.Size(14, 19);
            this.lblGunlukKazanc.TabIndex = 37;
            this.lblGunlukKazanc.Text = " ";
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
            this.btnGeri.TabIndex = 50;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAracTuruSorgula);
            this.groupBox1.Controls.Add(this.txtUcretSorgula);
            this.groupBox1.Controls.Add(this.txtPlakaSorgula);
            this.groupBox1.Controls.Add(this.btnSonuclariListele);
            this.groupBox1.Controls.Add(this.dateTimePickerGirisTarihi);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Plakaya Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ücrete Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 65;
            this.label3.Text = "Araç Türüne Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tarihe Göre";
            // 
            // txtAracTuruSorgula
            // 
            this.txtAracTuruSorgula.Location = new System.Drawing.Point(290, 85);
            this.txtAracTuruSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAracTuruSorgula.Name = "txtAracTuruSorgula";
            this.txtAracTuruSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtAracTuruSorgula.TabIndex = 63;
            this.txtAracTuruSorgula.TextChanged += new System.EventHandler(this.txtAracTuruSorgula_TextChanged);
            // 
            // txtUcretSorgula
            // 
            this.txtUcretSorgula.Location = new System.Drawing.Point(290, 218);
            this.txtUcretSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUcretSorgula.Name = "txtUcretSorgula";
            this.txtUcretSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtUcretSorgula.TabIndex = 60;
            this.txtUcretSorgula.TextChanged += new System.EventHandler(this.txtUcretSorgula_TextChanged);
            // 
            // txtPlakaSorgula
            // 
            this.txtPlakaSorgula.Location = new System.Drawing.Point(16, 218);
            this.txtPlakaSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlakaSorgula.Name = "txtPlakaSorgula";
            this.txtPlakaSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtPlakaSorgula.TabIndex = 57;
            this.txtPlakaSorgula.TextChanged += new System.EventHandler(this.txtPlakaSorgula_TextChanged);
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(16, 84);
            this.dateTimePickerGirisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerGirisTarihi.TabIndex = 53;
            this.dateTimePickerGirisTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerGirisTarihi_ValueChanged);
            // 
            // lblHaftalikKazanc
            // 
            this.lblHaftalikKazanc.AutoSize = true;
            this.lblHaftalikKazanc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftalikKazanc.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikKazanc.Location = new System.Drawing.Point(453, 116);
            this.lblHaftalikKazanc.Name = "lblHaftalikKazanc";
            this.lblHaftalikKazanc.Size = new System.Drawing.Size(14, 19);
            this.lblHaftalikKazanc.TabIndex = 57;
            this.lblHaftalikKazanc.Text = " ";
            // 
            // lblAylikKazanc
            // 
            this.lblAylikKazanc.AutoSize = true;
            this.lblAylikKazanc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikKazanc.ForeColor = System.Drawing.Color.White;
            this.lblAylikKazanc.Location = new System.Drawing.Point(759, 116);
            this.lblAylikKazanc.Name = "lblAylikKazanc";
            this.lblAylikKazanc.Size = new System.Drawing.Size(14, 19);
            this.lblAylikKazanc.TabIndex = 58;
            this.lblAylikKazanc.Text = " ";
            // 
            // lblAboneAylik
            // 
            this.lblAboneAylik.AutoSize = true;
            this.lblAboneAylik.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboneAylik.ForeColor = System.Drawing.Color.White;
            this.lblAboneAylik.Location = new System.Drawing.Point(759, 52);
            this.lblAboneAylik.Name = "lblAboneAylik";
            this.lblAboneAylik.Size = new System.Drawing.Size(14, 19);
            this.lblAboneAylik.TabIndex = 61;
            this.lblAboneAylik.Text = " ";
            // 
            // lblAboneHaftalik
            // 
            this.lblAboneHaftalik.AutoSize = true;
            this.lblAboneHaftalik.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboneHaftalik.ForeColor = System.Drawing.Color.White;
            this.lblAboneHaftalik.Location = new System.Drawing.Point(453, 52);
            this.lblAboneHaftalik.Name = "lblAboneHaftalik";
            this.lblAboneHaftalik.Size = new System.Drawing.Size(14, 19);
            this.lblAboneHaftalik.TabIndex = 60;
            this.lblAboneHaftalik.Text = " ";
            // 
            // lblAboneGunluk
            // 
            this.lblAboneGunluk.AutoSize = true;
            this.lblAboneGunluk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboneGunluk.ForeColor = System.Drawing.Color.White;
            this.lblAboneGunluk.Location = new System.Drawing.Point(97, 52);
            this.lblAboneGunluk.Name = "lblAboneGunluk";
            this.lblAboneGunluk.Size = new System.Drawing.Size(14, 19);
            this.lblAboneGunluk.TabIndex = 59;
            this.lblAboneGunluk.Text = " ";
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
            this.guna2ControlBox3.TabIndex = 64;
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
            this.guna2ControlBox2.TabIndex = 63;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1113, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 62;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frm_Rapor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblAboneAylik);
            this.Controls.Add(this.lblAboneHaftalik);
            this.Controls.Add(this.lblAboneGunluk);
            this.Controls.Add(this.lblAylikKazanc);
            this.Controls.Add(this.lblHaftalikKazanc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblGunlukKazanc);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.datagridRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporOlustur";
            this.Load += new System.EventHandler(this.RaporOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridRapor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridRapor;
        private Guna.UI2.WinForms.Guna2Button btnSonuclariListele;
        private Guna.UI2.WinForms.Guna2Button btnExcelAktar;
        private System.Windows.Forms.Label lblGunlukKazanc;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAracTuruSorgula;
        private System.Windows.Forms.TextBox txtUcretSorgula;
        private System.Windows.Forms.TextBox txtPlakaSorgula;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private System.Windows.Forms.Label lblHaftalikKazanc;
        private System.Windows.Forms.Label lblAylikKazanc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAboneAylik;
        private System.Windows.Forms.Label lblAboneHaftalik;
        private System.Windows.Forms.Label lblAboneGunluk;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}