using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class aracBulForm
    {
        private Baglanti _baglanti;
        private TextBox _txtPlaka;
        private Label _lblAracYeri;

        public aracBulForm(Baglanti baglanti, TextBox txtPlaka, Label lblAracYeri)
        {
            _baglanti = baglanti;
            _txtPlaka = txtPlaka;
            _lblAracYeri = lblAracYeri;
        }
        public void aracBul()
        {
            string plaka = _txtPlaka.Text.Trim(); // Kullanıcıdan alınan plaka

            if (string.IsNullOrEmpty(plaka))
            {
                MesajGoster.Uyari("Lütfen bir plaka girin!");
                return;
            }

            try
            {
                var entities = _baglanti.Entity();
                // Plakaya göre araç arama (case-insensitive)
                var aracgiris = entities.AracGiris
                    .FirstOrDefault(a => a.Plaka.ToLower() == plaka.ToLower());

                if (aracgiris != null)
                {
                    _lblAracYeri.Text = $"Şurada: {aracgiris.ParkYeri}";
                }
                else
                {
                    _lblAracYeri.Text = "Araç bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
