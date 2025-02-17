﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_PersonelTanimla : Form
    {
        cs_PersonelTanimla _islemler;
        public frm_PersonelTanimla()
        {
            InitializeComponent();
            _islemler = new cs_PersonelTanimla(txtKullaniciID, txtKullaniciAdi, txtKullaniciSifre, datagridPersonelTanimla);            
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiGiris yoneticiGiris = new frm_YoneticiGiris();
            yoneticiGiris.Show();
            this.Close();         
        }
        private void PersonelTanimla_Load(object sender, EventArgs e)
        {
            _islemler.TumKayitlariGoster();
        }
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            _islemler.Ekle();
        }
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            _islemler.Sil();
        }
        private void btnSecilenKullaniciyiGuncelle_Click(object sender, EventArgs e)
        {
            _islemler.Guncelle();
        }
        private void datagridPersonelTanimla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = datagridPersonelTanimla.SelectedCells[0].RowIndex;
            txtKullaniciID.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[1].Value.ToString();
            txtKullaniciSifre.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[2].Value.ToString();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = cs_MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                frm_PersonelTanimla ac = new frm_PersonelTanimla();
                ac.Show();
            }
        }
    }
}
