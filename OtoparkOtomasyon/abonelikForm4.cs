﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class abonelikForm4 : Form
    {
        Baglanti baglanti = new Baglanti();
        abonelikForm _islemler;

        public abonelikForm4()
        {
            InitializeComponent();
            _islemler = new abonelikForm(baglanti, cmbAracTuru, cmbAbonelikSuresi, txtAracPlakasi, lblTutar);

        }

        private void abonelikForm4_Load(object sender, EventArgs e)
        {
         _islemler.yukle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

        private void btnFiyatGoster_Click(object sender, EventArgs e)
        {
            _islemler.fiyatGoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.kaydet();
        }
        

    }
}
