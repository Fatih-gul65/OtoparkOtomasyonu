using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class AboneListe
    {
        private Baglanti _baglanti;
        private DataGridView _datagridAboneListele;

        public AboneListe(Baglanti baglanti, DataGridView datagridAboneListele)
        {
            _baglanti = baglanti;
            _datagridAboneListele = datagridAboneListele;
        }

        public void Listele()
        {
            try
            {
                var entities = _baglanti.Entity();
                var aboneListesi = entities.Abonelikler.Join(entities.AboneUcret,
                    abone => abone.AboneUcretID,
                    ucret => ucret.AboneUcretID,
                    (abone, ucret) => new
                    {
                        abone.AbonePlaka,
                        abone.AbonelikTipi,
                        abone.AbonelikBaslangicTarihi,
                        abone.AbonelikBitisTarihi,
                        abone.AbonelikUcreti,
                        abone.OdemeYontemi,
                        ucret.AboneAracTuru
                    }).ToList();
                _datagridAboneListele.DataSource = aboneListesi;
                _datagridAboneListele.ClearSelection();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
