using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class AboneUcretleriDuzenle
    {
        private Baglanti _baglanti;
        private RadioButton _rdbtnOtomobil, _rdbtnKamyonet, _rdbtnMinibus;
        private TextBox _txtAboneUcreti;

    public AboneUcretleriDuzenle(RadioButton rdbtnOtomobil, RadioButton rdbtnKamyonet, RadioButton rdbtnMinibus, TextBox txtAboneUcreti)
        {
            _baglanti = new Baglanti();
            _rdbtnOtomobil = rdbtnOtomobil;
            _rdbtnKamyonet = rdbtnKamyonet;
            _rdbtnMinibus = rdbtnMinibus;
            _txtAboneUcreti = txtAboneUcreti;
        }

        public void UcretYazdir(int aucretID)
        {
            try
            {
                var entities = _baglanti.Entity();

                var Yazdir = entities.AboneUcret.FirstOrDefault(x => x.AboneUcretID == aucretID);
                if (Yazdir != null)
                {
                    _txtAboneUcreti.Text = Yazdir.AboneUcreti.ToString();
                }
                else
                {
                    _txtAboneUcreti.Clear();
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void Ekle(int AUcretID , string AracTuru)
        {
            if (AUcretID == 0 || string.IsNullOrWhiteSpace(_txtAboneUcreti.Text))
            {
                MesajGoster.Uyari("Lütfen bir araç türü seçin ve abone ücretini girin!");
            }
            else
            {
                try
                {
                    var entities = _baglanti.Entity();

                    var aboneUcret = entities.AboneUcret.FirstOrDefault(x => x.AboneUcretID == AUcretID);

                    if (aboneUcret != null)
                    {
                        aboneUcret.AboneUcreti = Convert.ToDecimal(_txtAboneUcreti.Text.Trim());
                        entities.SaveChanges();
                        MesajGoster.Bilgi("Abone ücreti başarıyla güncellendi!");
                    }
                    else
                    {
                        AboneUcret Ekle = new AboneUcret();

                        Ekle.AboneUcretID = AUcretID;
                        Ekle.AboneAracTuru = AracTuru;
                        Ekle.AboneUcreti = Convert.ToDecimal(_txtAboneUcreti.Text.Trim());

                        entities.AboneUcret.Add(Ekle);
                        entities.SaveChanges();
                        MesajGoster.Bilgi("Yeni abone ücreti başarıyla eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MesajGoster.Hata(ex.Message);
                }
            }
        }
    } 
}
