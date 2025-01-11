using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_AracUcretDuzenle
    {
        private cs_Baglanti _baglanti;
        private RadioButton _rdbtnOtomobil, _rdbtnKamyonet, _rdbtnMinibus;
        private TextBox _txt_0_3_Saat, _txt_3_6_Saat, _txt_6_24_Saat, _txt_24_SaatUzeri;
        public cs_AracUcretDuzenle(RadioButton rdbtnOtomobil , RadioButton rdbtnKamyonet , RadioButton rdbtnMinibus,
           TextBox txt_0_3_Saat, TextBox txt_3_6_Saat, TextBox txt_6_24_Saat, TextBox txt_24_SaatUzeri )
        {
            _baglanti = new cs_Baglanti();
            _rdbtnOtomobil = rdbtnOtomobil;
            _rdbtnKamyonet = rdbtnKamyonet;
            _rdbtnMinibus = rdbtnMinibus;
            _txt_0_3_Saat = txt_0_3_Saat;
            _txt_3_6_Saat = txt_3_6_Saat;
            _txt_6_24_Saat = txt_6_24_Saat;
            _txt_24_SaatUzeri = txt_24_SaatUzeri;
        }
        public void UcretYazdir(int AracID)
        {
            try
            {
                var entities = _baglanti.Entity();

                var Yazdir = entities.AracUcretleri.FirstOrDefault(x => x.AracUcretID == AracID);
                if (Yazdir != null)
                {
                    _txt_0_3_Saat.Text = Yazdir.AracUcret03.ToString();
                    _txt_3_6_Saat.Text = Yazdir.AracUcret36.ToString();
                    _txt_6_24_Saat.Text = Yazdir.AracUcret61.ToString();
                    _txt_24_SaatUzeri.Text = Yazdir.AracUcretBirGunUzeri.ToString();
                }
                else
                {
                    _txt_0_3_Saat.Clear();
                    _txt_3_6_Saat.Clear();
                    _txt_6_24_Saat.Clear();
                    _txt_24_SaatUzeri.Clear();
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void Ekle(int AracID , string aracTuru)
        {
            if (AracID == 0 || string.IsNullOrWhiteSpace(_txt_0_3_Saat.Text) ||
                string.IsNullOrWhiteSpace(_txt_3_6_Saat.Text) ||
                string.IsNullOrWhiteSpace(_txt_6_24_Saat.Text) ||
                string.IsNullOrWhiteSpace(_txt_24_SaatUzeri.Text))
            {
                cs_MesajGoster.Uyari("Lütfen tüm alanları doldurun ve araç türünü seçin!");
            }
            else
            {
                try
                {
                    var entities = _baglanti.Entity();

                    if (AracID == 1 || AracID == 2 || AracID == 3)
                    {
                        var aracUcret = entities.AracUcretleri.FirstOrDefault(x => x.AracUcretID == AracID);
                        if (aracUcret != null)
                        {
                            aracUcret.AracUcret03 = Convert.ToDecimal((_txt_0_3_Saat.Text.Trim()));
                            aracUcret.AracUcret36 = Convert.ToDecimal((_txt_3_6_Saat.Text.Trim()));
                            aracUcret.AracUcret61 = Convert.ToDecimal((_txt_6_24_Saat.Text.Trim()));
                            aracUcret.AracUcretBirGunUzeri = Convert.ToDecimal((_txt_24_SaatUzeri.Text.Trim()));

                            entities.SaveChanges();
                            cs_MesajGoster.Bilgi("Ücretler başarıyla güncellendi!");
                        }
                        else
                        {
                            AracUcretleri ekle = new AracUcretleri();
                            ekle.AracUcretID = AracID;
                            ekle.AracUcret03 = Convert.ToDecimal((_txt_0_3_Saat.Text.Trim()));
                            ekle.AracUcret36 = Convert.ToDecimal((_txt_3_6_Saat.Text.Trim()));
                            ekle.AracUcret61 = Convert.ToDecimal((_txt_6_24_Saat.Text.Trim()));
                            ekle.AracUcretBirGunUzeri = Convert.ToDecimal((_txt_24_SaatUzeri.Text.Trim()));
                            ekle.AracTuru = aracTuru;
                            entities.AracUcretleri.Add(ekle);
                            entities.SaveChanges();
                            cs_MesajGoster.Bilgi("Yeni ücret kaydı başarıyla eklendi!");
                        }
                    }
                    else
                    {
                        cs_MesajGoster.Uyari("Geçersiz araç türü seçildi. Lütfen geçerli bir araç türü seçin!");
                    }
                }
                catch (Exception ex)
                {
                    cs_MesajGoster.Hata(ex.Message);
                }
            }
        }
    }
}
