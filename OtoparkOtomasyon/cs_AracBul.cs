﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_AracBul
    {
        private cs_Baglanti _baglanti;
        private TextBox _txtPlaka;
        private Label _lblAracYeri;
        public cs_AracBul(cs_Baglanti baglanti, TextBox txtPlaka, Label lblAracYeri)
        {
            _baglanti = baglanti;
            _txtPlaka = txtPlaka;
            _lblAracYeri = lblAracYeri;
        }
        public void aracBul()
        {
            try
            {
                var entities = _baglanti.Entity();
                string plaka = _txtPlaka.Text.Trim(); // Kullanıcıdan alınan plaka

                if (string.IsNullOrEmpty(plaka))
                {
                    cs_MesajGoster.Uyari("Lütfen bir plaka girin!");
                    return;
                }
                // Önce araç çıkış yapmış mı kontrol edelim
                var aracCikisKontrol = entities.AracCikis.FirstOrDefault(c => c.Plaka.ToLower() == plaka.ToLower());
                if (aracCikisKontrol != null)
                {
                    cs_MesajGoster.Uyari("Bu araç çıkış yapmış.");
                    return;
                }
                // Plakaya göre aracın bilgilerini alıyoruz
                var arac = entities.AracGiris.FirstOrDefault(a => a.Plaka.ToLower() == plaka.ToLower());

                if (arac == null)
                {
                    cs_MesajGoster.Uyari("Araç bulunamadı!");
                    return;
                }

                // Araçla ilişkili park yeri bilgisine erişim
                var parkyeriBul = entities.AracGiris
                    .FirstOrDefault(k => k.ParkYeri == arac.ParkYeri);

                if (parkyeriBul != null)
                {
                    // Sadece park yeri bilgisini ekranda göster
                    _lblAracYeri.Text = $"Şurada: {parkyeriBul.ParkYeri}"; 
                }
                else
                {
                    _lblAracYeri.Text = "Araç için park yeri bilgisi bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı gösterimi
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
