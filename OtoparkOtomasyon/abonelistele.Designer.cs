namespace OtoparkOtomasyon
{
    partial class abonelistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abonelistele));
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagridAboneListele = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAracTuruSorgula = new System.Windows.Forms.TextBox();
            this.txtAboneSuresiSorgula = new System.Windows.Forms.TextBox();
            this.txtUcretSorgula = new System.Windows.Forms.TextBox();
            this.txtPlakaSorgula = new System.Windows.Forms.TextBox();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnSonuclariListele = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAboneListele)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnGeri.Location = new System.Drawing.Point(51, 693);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(240, 55);
            this.btnGeri.TabIndex = 17;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(494, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // datagridAboneListele
            // 
            this.datagridAboneListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAboneListele.Location = new System.Drawing.Point(617, 195);
            this.datagridAboneListele.Margin = new System.Windows.Forms.Padding(4);
            this.datagridAboneListele.Name = "datagridAboneListele";
            this.datagridAboneListele.RowHeadersWidth = 51;
            this.datagridAboneListele.Size = new System.Drawing.Size(743, 396);
            this.datagridAboneListele.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAracTuruSorgula);
            this.groupBox1.Controls.Add(this.txtAboneSuresiSorgula);
            this.groupBox1.Controls.Add(this.txtUcretSorgula);
            this.groupBox1.Controls.Add(this.txtPlakaSorgula);
            this.groupBox1.Controls.Add(this.dateTimePickerBaslangic);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 396);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapmak İstediğiniz İşlemi Seçiniz !";
            // 
            // txtAracTuruSorgula
            // 
            this.txtAracTuruSorgula.Location = new System.Drawing.Point(171, 330);
            this.txtAracTuruSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAracTuruSorgula.Name = "txtAracTuruSorgula";
            this.txtAracTuruSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtAracTuruSorgula.TabIndex = 63;
            this.txtAracTuruSorgula.TextChanged += new System.EventHandler(this.txtAracTuruSorgula_TextChanged);
            // 
            // txtAboneSuresiSorgula
            // 
            this.txtAboneSuresiSorgula.Location = new System.Drawing.Point(290, 84);
            this.txtAboneSuresiSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAboneSuresiSorgula.Name = "txtAboneSuresiSorgula";
            this.txtAboneSuresiSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtAboneSuresiSorgula.TabIndex = 61;
            this.txtAboneSuresiSorgula.TextChanged += new System.EventHandler(this.txtAboneSuresiSorgula_TextChanged);
            // 
            // txtUcretSorgula
            // 
            this.txtUcretSorgula.Location = new System.Drawing.Point(290, 218);
            this.txtUcretSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUcretSorgula.Name = "txtUcretSorgula";
            this.txtUcretSorgula.Size = new System.Drawing.Size(137, 27);
            this.txtUcretSorgula.TabIndex = 60;
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
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Checked = false;
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(16, 84);
            this.dateTimePickerBaslangic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerBaslangic.TabIndex = 53;
            this.dateTimePickerBaslangic.ValueChanged += new System.EventHandler(this.dateTimePickerBaslangic_ValueChanged);
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
            this.btnSonuclariListele.Location = new System.Drawing.Point(1161, 693);
            this.btnSonuclariListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonuclariListele.Name = "btnSonuclariListele";
            this.btnSonuclariListele.Size = new System.Drawing.Size(199, 55);
            this.btnSonuclariListele.TabIndex = 34;
            this.btnSonuclariListele.Text = "Tüm Sonuçları Listele";
            this.btnSonuclariListele.Click += new System.EventHandler(this.btnSonuclariListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Araç Türüne Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Ücrete Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "Plakaya Göre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 71;
            this.label5.Text = "Abonelik Süresine Göre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 72;
            this.label6.Text = "Tarihe Göre";
            // 
            // abonelistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1403, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridAboneListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSonuclariListele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "abonelistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abonelistele";
            this.Load += new System.EventHandler(this.abonelistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAboneListele)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagridAboneListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlakaSorgula;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private Guna.UI2.WinForms.Guna2Button btnSonuclariListele;
        private System.Windows.Forms.TextBox txtUcretSorgula;
        private System.Windows.Forms.TextBox txtAboneSuresiSorgula;
        private System.Windows.Forms.TextBox txtAracTuruSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}