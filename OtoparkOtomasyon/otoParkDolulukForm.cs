using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class otoParkDolulukForm
    {
        private Baglanti _baglanti;
        private Label _lblDoluAlan, _lblBosAlan, _lblKapasite;

        public otoParkDolulukForm(Baglanti baglanti, Label lblDoluAlan, Label lblBosAlan, Label lblKapasite)
        {
            _baglanti = baglanti;
            _lblDoluAlan = lblDoluAlan;
            _lblBosAlan = lblBosAlan;
            _lblKapasite = lblKapasite;
        }
        public void GuncelleDoluluk()
        {
            try
            {
                var entities = _baglanti.Entity ();
                // AracGiris tablosundaki kayıtları sayıyoruz
                var aracGirisSayisi = entities.AracGiris.Count();

                // Otopark kapasitesini öğreniyoruz
                var otopark = entities.OtoparkDurumu.FirstOrDefault();

                if (otopark != null)
                {
                    // Kapasiteyi nullable int'den int'e dönüştürüyoruz
                    int kapasite = otopark.KapasiteID.HasValue ? otopark.KapasiteID.Value : 0;

                    // Dolu alanları belirliyoruz
                    int doluAlanlar = aracGirisSayisi;

                    // Boş alanları hesaplıyoruz
                    int bosAlanlar = kapasite - doluAlanlar;

                    // Labellere bu verileri yazıyoruz
                    _lblDoluAlan.Text = $"Dolu Alan: {doluAlanlar} araç";
                    _lblBosAlan.Text = $"Boş Alan: {bosAlanlar} araç";

                    // Kapasiteyi de yazmak isterseniz
                    _lblKapasite.Text = $"Toplam Kapasite: {kapasite} araç";
                }
                else
                {
                    MesajGoster.Uyari("Otopark kapasitesi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
