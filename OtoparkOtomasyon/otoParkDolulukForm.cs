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
                var entities = _baglanti.Entity();

                var kapasiteBilgisi = entities.AracKapasitesi.FirstOrDefault();
                if (kapasiteBilgisi != null)
                {
                    int otomobilKapasite = kapasiteBilgisi.OtomobilKapasitesi.HasValue ? kapasiteBilgisi.OtomobilKapasitesi.Value : 0;
                    int otomobilGiris = entities.AracGiris.Count(ag => ag.AracTuru == "Otomobil");
                    int otomobilCikis = entities.AracCikis.Count(ac => entities.AracGiris.Any(ag => ag.GirisID == ac.GirisID && ag.AracTuru == "Otomobil"));
                    int otomobilDolu = otomobilGiris - otomobilCikis;
                    int otomobilBos = otomobilKapasite - otomobilDolu;

                    int kamyonetKapasite = kapasiteBilgisi.KamyonetKapasitesi.HasValue ? kapasiteBilgisi.KamyonetKapasitesi.Value : 0;
                    int kamyonetGiris = entities.AracGiris.Count(ag => ag.AracTuru == "Kamyonet");
                    int kamyonetCikis = entities.AracCikis.Count(ac => entities.AracGiris.Any(ag => ag.GirisID == ac.GirisID && ag.AracTuru == "Kamyonet"));
                    int kamyonetDolu = kamyonetGiris - kamyonetCikis;
                    int kamyonetBos = kamyonetKapasite - kamyonetDolu;

                    int minibusKapasite = kapasiteBilgisi.MinibusKapasitesi.HasValue ? kapasiteBilgisi.MinibusKapasitesi.Value : 0;
                    int minibusGiris = entities.AracGiris.Count(ag => ag.AracTuru == "Minibüs/Kamyon");
                    int minibusCikis = entities.AracCikis.Count(ac => entities.AracGiris.Any(ag => ag.GirisID == ac.GirisID && ag.AracTuru == "Minibüs/Kamyon"));
                    int minibusDolu = minibusGiris - minibusCikis;
                    int minibusBos = minibusKapasite - minibusDolu;

                    string sonucKapasite = $"Otomobil Kapasitesi : {otomobilKapasite} \nKamyonet Kapasitesi : {kamyonetKapasite} \nMinibüs/Kamyon Kapasitesi : {minibusKapasite} \n \nToplam Kapasite : " + (otomobilKapasite + kamyonetKapasite + minibusKapasite);
                    string sonucDolu = $"Otomobil Dolu Alan : {otomobilDolu} \nKamyonet Dolu Alan : {kamyonetDolu} \nMinibüs/Kamyon Dolu Alan : {minibusDolu} \n \nToplam Dolu Alan : " + (otomobilDolu + kamyonetDolu + minibusDolu);
                    string sonucBos = $"Otomobil Bos Alan : {otomobilBos} \nKamyonet Bos Alan : {kamyonetBos} \nMinibüs/Kamyon Bos Alan : {minibusBos} \n \nToplam Bos Alan : " + (otomobilBos + kamyonetBos + minibusBos);
                    
                    _lblKapasite.Text = sonucKapasite;
                    _lblDoluAlan.Text = sonucDolu; 
                    _lblBosAlan.Text = sonucBos;                    
                }
                else
                {
                    throw new Exception("Otopark kapasitesi bilgileri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
