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
    public partial class AboneUcretDuzenle : Form
    {
        private AboneUcretleriDuzenle _islemler;
        public AboneUcretDuzenle()
        {
            InitializeComponent();
            _islemler = new AboneUcretleriDuzenle(rdbtnOtomobil, rdbtnKamyonet, rdbtnMinibus, txtAboneUcreti);
        }

        int AUcretID = 0;
        string AracTuru = "";
        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris geri = new YoneticiGiris();
            geri.Show();
            this.Close();
        }
        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                AUcretID = 1;
                AracTuru = "Otomobil";
                _islemler.UcretYazdir(AUcretID);
            }
        }
        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                AUcretID = 2;
                AracTuru = "Kamyonet";
                _islemler.UcretYazdir(AUcretID);
            }
        }
        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                AUcretID = 3;
                AracTuru = "Minibüs / Kamyon";
                _islemler.UcretYazdir(AUcretID);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Ekle(AUcretID, AracTuru);
        }
        private void txtAboneUcreti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (txtAboneUcreti.Text.Length >= 10 && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                AboneUcretDuzenle ac = new AboneUcretDuzenle();
                ac.Show();
            }
        }
    }
}
