﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_PersonelTanimla
    {
        private cs_Baglanti _baglanti;
        private TextBox _txtKullaniciID, _txtKullaniciAdi, _txtKullaniciSifre;
        private DataGridView _datagridPersonelTanimla;
        public cs_PersonelTanimla(TextBox txtKullaniciID, TextBox txtKullaniciAdi, TextBox txtKullaniciSifre, DataGridView datagridPersonelTanimla)
        {
            _baglanti = new cs_Baglanti();
            _txtKullaniciID = txtKullaniciID;
            _txtKullaniciAdi = txtKullaniciAdi;
            _txtKullaniciSifre = txtKullaniciSifre;
            _datagridPersonelTanimla = datagridPersonelTanimla;
        }
        public void TumKayitlariGoster()
        {
            try { 
                var entities = _baglanti.Entity();
                var personeller = entities.PersonelGirisTanimla.ToList();
                _datagridPersonelTanimla.DataSource = personeller;
                _datagridPersonelTanimla.ClearSelection();
                KutulariBosalt();
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void KutulariBosalt()
        {
            _txtKullaniciID.Clear();
            _txtKullaniciAdi.Clear();
            _txtKullaniciSifre.Clear();
        }
        public void Ekle()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (string.IsNullOrEmpty(_txtKullaniciAdi.Text.Trim()) || string.IsNullOrEmpty(_txtKullaniciSifre.Text.Trim()))
                {
                    cs_MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    bool kullaniciVarMi = entities.PersonelGirisTanimla.Any(x => x.KullaniciAdi == _txtKullaniciAdi.Text.Trim());

                    if (kullaniciVarMi)
                    {
                        cs_MesajGoster.Uyari("Bu Kullanıcı Adına Sahip Başka Bir Kayıt Bulunmaktadır \n Başka Bir Kullanıcı Adı Belirleyiniz Veya Varolan Kullanıcıyı Güncelleyiniz !");
                    }
                    else
                    {
                        PersonelGirisTanimla Ekle = new PersonelGirisTanimla();
                        Ekle.KullaniciAdi = _txtKullaniciAdi.Text.Trim();
                        Ekle.KullaniciSifre = _txtKullaniciSifre.Text.Trim();
                        Ekle.TanimlanmaTarihi = DateTime.Now;
                        entities.PersonelGirisTanimla.Add(Ekle);
                        entities.SaveChanges();
                        cs_MesajGoster.Bilgi("Kayıt Eklendi");
                        TumKayitlariGoster();
                    }
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void Sil()
        {
            try
            {
                var entities = _baglanti.Entity();
                if (_datagridPersonelTanimla.SelectedCells.Count > 0)
                {
                    int KullaniciId = Convert.ToInt32(_txtKullaniciID.Text);
                    var kullanici = entities.PersonelGirisTanimla.Find(KullaniciId);
                    entities.PersonelGirisTanimla.Remove(kullanici);
                    entities.SaveChanges();
                    cs_MesajGoster.Bilgi("Seçili Kayıt Silindi");
                    TumKayitlariGoster();
                }
                else
                {
                    cs_MesajGoster.Uyari("Lütfen Silme İşlemi Yapmak İçin Bir Kayıt Seçiniz !");
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void Guncelle()
        {
            try
            {
                var entities = _baglanti.Entity();

                int KullaniciId = Convert.ToInt32(_txtKullaniciID.Text);
                var kullanici = entities.PersonelGirisTanimla.Find(KullaniciId);

                if (kullanici.KullaniciAdi == _txtKullaniciAdi.Text && kullanici.KullaniciSifre == _txtKullaniciSifre.Text)
                {
                    cs_MesajGoster.Uyari("Güncelleme İşlemi Başarısız. \n Girilen Bilgiler İle Mevcut Bilgiler Aynıdır !");
                }
                else
                {
                    if (_txtKullaniciAdi.Text == "" || _txtKullaniciSifre.Text == "")
                    {
                        cs_MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                    }
                    else
                    {
                        bool kullaniciVarMi = entities.PersonelGirisTanimla.Any(x => x.KullaniciAdi == _txtKullaniciAdi.Text && x.KullaniciID != KullaniciId);
                        if (kullaniciVarMi)
                        {
                            cs_MesajGoster.Uyari("Güncelleme İşlemi Başarısız! \n Bu Kullanıcı Adına Sahip Başka Bir Kayıt Bulunmaktadır.");
                        }
                        else
                        {
                            kullanici.KullaniciAdi = _txtKullaniciAdi.Text.Trim();
                            kullanici.KullaniciSifre = _txtKullaniciSifre.Text.Trim();
                            entities.SaveChanges();
                            cs_MesajGoster.Bilgi("Seçili Kayıt Güncellendi");
                            TumKayitlariGoster();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
