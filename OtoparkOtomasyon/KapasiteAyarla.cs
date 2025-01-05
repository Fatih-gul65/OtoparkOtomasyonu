using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class KapasiteAyarla
    {
        private Baglanti _baglanti;
        private RadioButton _rdbtnOtomobil, _rdbtnKamyonet, _rdbtnMinibus;
        private TextBox _txtKapasiteAyarla;

        public KapasiteAyarla(RadioButton rdbtnOtomobil, RadioButton rdbtnKamyonet, RadioButton rdbtnMinibus, TextBox txtKapasiteAyarla) 
        {
            _baglanti = new Baglanti();
            _rdbtnOtomobil = rdbtnOtomobil;
            _rdbtnKamyonet = rdbtnKamyonet;
            _rdbtnMinibus = rdbtnMinibus;
            _txtKapasiteAyarla = txtKapasiteAyarla;
        }
        public void KaydetVeyaGuncelle(string secim , int kapasiteDegeri ,out bool basarili)
        {
            basarili = false;
            try
            {
                var entities = _baglanti.Entity();

                var kontrol = entities.AracKapasitesi.FirstOrDefault(x => x.KapasiteID == 1);

                if (kontrol == null)
                {
                    kontrol = new AracKapasitesi();
                    kontrol.KapasiteID = 1;
                    entities.AracKapasitesi.Add(kontrol);
                }

                int mevcutAracSayisi = 0;
                if (secim == "Otomobil")
                {
                    mevcutAracSayisi = entities.AracGiris.Count(x => x.AracTuru == "Otomobil");
                }
                else if (secim == "Kamyonet")
                {
                    mevcutAracSayisi = entities.AracGiris.Count(x => x.AracTuru == "Kamyonet");
                }
                else if (secim == "Minibüs/Kamyon")
                {
                    mevcutAracSayisi = entities.AracGiris.Count(x => x.AracTuru == "Minibüs/Kamyon");
                }

                if (mevcutAracSayisi > 0)
                {
                    MesajGoster.Uyari($"İçeride {secim} türünde araç(lar) olduğu için kapasite değiştirilemez!");
                    return;
                }

                if (secim == "Otomobil") kontrol.OtomobilKapasitesi = kapasiteDegeri;
                else if (secim == "Kamyonet") kontrol.KamyonetKapasitesi = kapasiteDegeri;
                else if (secim == "Minibüs/Kamyon") kontrol.MinibusKapasitesi = kapasiteDegeri;

                entities.SaveChanges();
                basarili = true;
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void Ekle()
        {
            string secim = "";
            if (_rdbtnOtomobil.Checked) secim = "Otomobil";
            else if (_rdbtnKamyonet.Checked) secim = "Kamyonet";
            else if (_rdbtnMinibus.Checked) secim = "Minibüs/Kamyon";

            if (string.IsNullOrWhiteSpace(_txtKapasiteAyarla.Text) || secim == "")
            {
                MesajGoster.Uyari("Lütfen bir araç türü seçin ve otoparkın seçtiğiniz araç türü için kapasitesini girin!");
            }
            else
            {
                bool basarili = false;
                int kapasiteDegeri = Convert.ToInt32(_txtKapasiteAyarla.Text);
                KaydetVeyaGuncelle(secim, kapasiteDegeri, out basarili);

                if (basarili)
                {
                    MesajGoster.Bilgi(secim + " Kapasiteniz : " + _txtKapasiteAyarla.Text + " Olarak Belirlendi.");
                }
            }
        }
        public void AracKapasitesiniYazdir(string secim)
        {
            try
            {
                var entities = _baglanti.Entity();
                var kapasite = entities.AracKapasitesi.FirstOrDefault(x => x.KapasiteID == 1);

                if (kapasite != null)
                {
                    if (secim == "Otomobil")
                    {
                        _txtKapasiteAyarla.Text = kapasite.OtomobilKapasitesi.ToString();
                    }
                    else if (secim == "Kamyonet")
                    {
                        _txtKapasiteAyarla.Text = kapasite.KamyonetKapasitesi.ToString();
                    }
                    else if (secim == "Minibüs/Kamyon")
                    {
                        _txtKapasiteAyarla.Text = kapasite.MinibusKapasitesi.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
