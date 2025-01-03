using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class UcretsizAracGiris
    {
        private Baglanti _baglanti;
        private DataGridView _datagridUcretsizGiris;
        private TextBox _txtUcretsizPlaka;
        private Label _lblUcretsizGiris;
        public UcretsizAracGiris(DataGridView datagridUcretsizGiris, TextBox txtUcretsizPlaka, Label lblUcretsizGiris)
        {
            _baglanti = new Baglanti();
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
                MesajGoster.Hata(ex.Message);
            }
        }
        public void PlakaEkle(string plaka)
        {
            if (string.IsNullOrEmpty(plaka.Trim()))
            {
                MesajGoster.BosPlaka();
            }
            else
            {
                plaka = plaka.Trim().ToUpper();

                if (PlakaKontrolu.PlakaKontrol(plaka))
                {
                    try
                    {
                        var entities = _baglanti.Entity();

                        var plakaVarMi = entities.UcretsizGiris.Any(x => x.Plaka == plaka);

                        if (plakaVarMi)
                        {
                            MesajGoster.KayitliPlaka();
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
                            MesajGoster.Bilgi("Kayıt Eklendi");
                            TumKayitlariGoster();
                        }
                    }
                    catch (Exception ex)
                    {
                        MesajGoster.Hata(ex.Message);
                    }
                }
                else
                {
                    MesajGoster.GecersizPlaka();
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
                MesajGoster.Bilgi("Seçili Kayıt Silindi");
                entities.SaveChanges();
                TumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
