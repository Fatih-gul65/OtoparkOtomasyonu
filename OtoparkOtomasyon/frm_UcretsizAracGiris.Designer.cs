namespace OtoparkOtomasyon
{
    partial class frm_UcretsizAracGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UcretsizAracGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUcretsizPlaka = new System.Windows.Forms.TextBox();
            this.datagridUcretsizGiris = new System.Windows.Forms.DataGridView();
            this.btnSecilenPlakayiSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlakaEkle = new Guna.UI2.WinForms.Guna2Button();
            this.lblUcretsizGiris = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUcretsizGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Otopark Yönetiminde Ustalık Zamanı!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ücretsiz Giriş Tanımlamak İstediğiniz Aracın Plakasını Giriniz : ";
            // 
            // txtUcretsizPlaka
            // 
            this.txtUcretsizPlaka.Location = new System.Drawing.Point(792, 477);
            this.txtUcretsizPlaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUcretsizPlaka.Name = "txtUcretsizPlaka";
            this.txtUcretsizPlaka.Size = new System.Drawing.Size(153, 22);
            this.txtUcretsizPlaka.TabIndex = 32;
            // 
            // datagridUcretsizGiris
            // 
            this.datagridUcretsizGiris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUcretsizGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUcretsizGiris.Location = new System.Drawing.Point(199, 177);
            this.datagridUcretsizGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridUcretsizGiris.Name = "datagridUcretsizGiris";
            this.datagridUcretsizGiris.RowHeadersWidth = 51;
            this.datagridUcretsizGiris.RowTemplate.Height = 24;
            this.datagridUcretsizGiris.Size = new System.Drawing.Size(746, 233);
            this.datagridUcretsizGiris.TabIndex = 33;
            this.datagridUcretsizGiris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridUcretsizGiris_CellClick);
            // 
            // btnSecilenPlakayiSil
            // 
            this.btnSecilenPlakayiSil.BorderRadius = 15;
            this.btnSecilenPlakayiSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecilenPlakayiSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecilenPlakayiSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecilenPlakayiSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecilenPlakayiSil.FillColor = System.Drawing.Color.White;
            this.btnSecilenPlakayiSil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenPlakayiSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnSecilenPlakayiSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSecilenPlakayiSil.Image")));
            this.btnSecilenPlakayiSil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSecilenPlakayiSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSecilenPlakayiSil.Location = new System.Drawing.Point(601, 544);
            this.btnSecilenPlakayiSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecilenPlakayiSil.Name = "btnSecilenPlakayiSil";
            this.btnSecilenPlakayiSil.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSecilenPlakayiSil.Size = new System.Drawing.Size(242, 46);
            this.btnSecilenPlakayiSil.TabIndex = 47;
            this.btnSecilenPlakayiSil.Text = "Seçilen Plakayı Sil";
            this.btnSecilenPlakayiSil.Click += new System.EventHandler(this.btnSecilenPlakayiSil_Click);
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
            this.btnGeri.Location = new System.Drawing.Point(12, 666);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(180, 46);
            this.btnGeri.TabIndex = 49;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnPlakaEkle
            // 
            this.btnPlakaEkle.BorderRadius = 15;
            this.btnPlakaEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlakaEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlakaEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlakaEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlakaEkle.FillColor = System.Drawing.Color.White;
            this.btnPlakaEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlakaEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnPlakaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnPlakaEkle.Image")));
            this.btnPlakaEkle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlakaEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlakaEkle.Location = new System.Drawing.Point(309, 544);
            this.btnPlakaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlakaEkle.Name = "btnPlakaEkle";
            this.btnPlakaEkle.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnPlakaEkle.Size = new System.Drawing.Size(242, 46);
            this.btnPlakaEkle.TabIndex = 50;
            this.btnPlakaEkle.Text = "Plakayı Ekle";
            this.btnPlakaEkle.Click += new System.EventHandler(this.btnPlakaEkle_Click);
            // 
            // lblUcretsizGiris
            // 
            this.lblUcretsizGiris.AutoSize = true;
            this.lblUcretsizGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcretsizGiris.ForeColor = System.Drawing.Color.White;
            this.lblUcretsizGiris.Location = new System.Drawing.Point(793, 429);
            this.lblUcretsizGiris.Name = "lblUcretsizGiris";
            this.lblUcretsizGiris.Size = new System.Drawing.Size(0, 24);
            this.lblUcretsizGiris.TabIndex = 51;
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
            this.guna2ControlBox3.TabIndex = 54;
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
            this.guna2ControlBox2.TabIndex = 53;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1113, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 52;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frm_UcretsizAracGiris
            // 
            this.AcceptButton = this.btnPlakaEkle;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblUcretsizGiris);
            this.Controls.Add(this.btnPlakaEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSecilenPlakayiSil);
            this.Controls.Add(this.datagridUcretsizGiris);
            this.Controls.Add(this.txtUcretsizPlaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_UcretsizAracGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcretsizAraçTanimla";
            this.Load += new System.EventHandler(this.UcretsizAraçGirisiTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUcretsizGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUcretsizPlaka;
        private System.Windows.Forms.DataGridView datagridUcretsizGiris;
        private Guna.UI2.WinForms.Guna2Button btnSecilenPlakayiSil;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private Guna.UI2.WinForms.Guna2Button btnPlakaEkle;
        private System.Windows.Forms.Label lblUcretsizGiris;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}