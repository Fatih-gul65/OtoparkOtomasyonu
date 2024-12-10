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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAboneListele)).BeginInit();
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
            this.btnGeri.TabIndex = 17;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 19);
            this.label1.TabIndex = 19;
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
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // datagridAboneListele
            // 
            this.datagridAboneListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAboneListele.Location = new System.Drawing.Point(196, 158);
            this.datagridAboneListele.Name = "datagridAboneListele";
            this.datagridAboneListele.Size = new System.Drawing.Size(916, 445);
            this.datagridAboneListele.TabIndex = 20;
            // 
            // abonelistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1292, 708);
            this.Controls.Add(this.datagridAboneListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "abonelistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abonelistele";
            this.Load += new System.EventHandler(this.abonelistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAboneListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagridAboneListele;
    }
}