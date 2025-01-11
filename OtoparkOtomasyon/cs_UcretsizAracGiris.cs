using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_UcretsizAracGiris
    {
        private cs_Baglanti _baglanti;
        private DataGridView _datagridUcretsizGiris;
        private TextBox _txtUcretsizPlaka;
        private Label _lblUcretsizGiris;
        public cs_UcretsizAracGiris(DataGridView datagridUcretsizGiris, TextBox txtUcretsizPlaka, Label lblUcretsizGiris)
        {
            _baglanti = new cs_Baglanti();
            _datagridUcretsizGiris = datagridUcretsizGiris;
            _txtUcretsizPlaka = txtUcretsizPlaka;
            _lblUcretsizGiris = lblUcretsizGiris;
        }
        public void TumKayitlariGoster()
        {
            try
            {
                var entities = _baglanti.Entity();

                var ucretsizGirisler = (from liste in entities.UcretsizGiris
                                        select new
                                        {
                                            liste.UcretsizGirisID,
                                            liste.Plaka,
                                            liste.TanimlanmaTarihi
                                        }).ToList();

                _datagridUcretsizGiris.DataSource = ucretsizGirisler;
                _datagridUcretsizGiris.ClearSelection();
                _txtUcretsizPlaka.Clear();
                _lblUcretsizGiris.Text = "";
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void PlakaEkle(string plaka)
        {
            if (string.IsNullOrEmpty(plaka.Trim()))
            {
                cs_MesajGoster.BosPlaka();
            }
            else
            {
                plaka = plaka.Trim().ToUpper();

                if (cs_PlakaKontrolu.PlakaKontrol(plaka))
                {
                    try
                    {
                        var entities = _baglanti.Entity();

                        var plakaVarMi = entities.UcretsizGiris.Any(x => x.Plaka == plaka);

                        if (plakaVarMi)
                        {
                            cs_MesajGoster.KayitliPlaka();
                        }
                        else
                        {
                            UcretsizGiris ekle = new UcretsizGiris
                            {
                                Plaka = plaka,
                                TanimlanmaTarihi = DateTime.Now
                            };

                            entities.UcretsizGiris.Add(ekle);
                            entities.SaveChanges();
                            cs_MesajGoster.Bilgi("Kayıt Eklendi");
                            TumKayitlariGoster();
                        }
                    }
                    catch (Exception ex)
                    {
                        cs_MesajGoster.Hata(ex.Message);
                    }
                }
                else
                {
                    cs_MesajGoster.GecersizPlaka();
                    _txtUcretsizPlaka.Clear();
                }
            }
        }
        public void PlakaSil(int ucretsizGirisID)
        {
            try
            {
                var entities = _baglanti.Entity();
                var Ugiris = entities.UcretsizGiris.Find(ucretsizGirisID);
                entities.UcretsizGiris.Remove(Ugiris);
                cs_MesajGoster.Bilgi("Seçili Kayıt Silindi");
                entities.SaveChanges();
                TumKayitlariGoster();
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
