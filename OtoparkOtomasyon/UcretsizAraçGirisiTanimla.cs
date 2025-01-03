﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class UcretsizAraçGirisiTanimla : Form
    {
        private UcretsizAracGiris _islemler;
        public UcretsizAraçGirisiTanimla()
        {
            InitializeComponent();
            _islemler = new UcretsizAracGiris(datagridUcretsizGiris, txtUcretsizPlaka, lblUcretsizGiris);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }
        private void UcretsizAraçGirisiTanimla_Load(object sender, EventArgs e)
        {
            _islemler.TumKayitlariGoster();
        }
        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            string plaka = txtUcretsizPlaka.Text.Trim();
            _islemler.PlakaEkle(plaka);
        }
        private void datagridUcretsizGiris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = datagridUcretsizGiris.SelectedCells[0].RowIndex;
            lblUcretsizGiris.Text = "Ücretsiz Giriş ID : " + datagridUcretsizGiris.Rows[secilenSatır].Cells[0].Value.ToString();
            txtUcretsizPlaka.Text = datagridUcretsizGiris.Rows[secilenSatır].Cells[1].Value.ToString();
        }
        private void btnSecilenPlakayiSil_Click(object sender, EventArgs e)
        {
            if (datagridUcretsizGiris.SelectedCells.Count > 0)
            {
                int ucretsizGirisID = Convert.ToInt32(lblUcretsizGiris.Text.Replace("Ücretsiz Giriş ID : ", ""));
                _islemler.PlakaSil(ucretsizGirisID);
            }
            else
            {
                MesajGoster.Uyari("Lütfen Kayıt Seçiniz");
            }
        }       
    }
}
