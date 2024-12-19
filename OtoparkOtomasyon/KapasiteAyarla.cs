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

        public void KaydetVeyaGuncelle(string secim , int kapasiteDegeri)
        {
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

                if (secim == "Otomobil") kontrol.OtomobilKapasitesi = kapasiteDegeri;
                else if (secim == "Kamyonet") kontrol.KamyonetKapasitesi = kapasiteDegeri;
                else if (secim == "Minibüs/Kamyon") kontrol.MinibusKapasitesi = kapasiteDegeri;

                entities.SaveChanges();
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
                
                int kapasiteDegeri = Convert.ToInt32(_txtKapasiteAyarla.Text);
                KaydetVeyaGuncelle(secim, kapasiteDegeri);
                MesajGoster.Bilgi(secim + " Kapasiteniz : " + _txtKapasiteAyarla.Text + " Olarak Belirlendi.");
                _txtKapasiteAyarla.Clear();

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
                    // Seçilen araç türüne göre kapasiteyi yazdır
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
