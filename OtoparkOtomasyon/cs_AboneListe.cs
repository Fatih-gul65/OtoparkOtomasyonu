using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_AboneListe
    {
        private cs_Baglanti _baglanti;
        private DataGridView _datagridAboneListele;
        private TextBox _txtAboneSuresiSorgula, _txtUcretSorgula, _txtAracTuruSorgula, _txtPlakaSorgula;
        private DateTimePicker _dateTimePickerBaslangic;
        public cs_AboneListe(cs_Baglanti baglanti, DataGridView datagridAboneListele, TextBox txtAboneSuresiSorgula, TextBox txtUcretSorgula,
                          TextBox txtAracTuruSorgula, TextBox txtPlakaSorgula, DateTimePicker dateTimePickerBaslangic)
        {
            _baglanti = baglanti;
            _datagridAboneListele = datagridAboneListele;
            _txtAboneSuresiSorgula = txtAboneSuresiSorgula;
            _txtUcretSorgula = txtUcretSorgula;
            _txtAracTuruSorgula = txtAracTuruSorgula;
            _txtPlakaSorgula = txtPlakaSorgula;
            _dateTimePickerBaslangic = dateTimePickerBaslangic;
        }
        public void Temizle()
        {
            _txtAboneSuresiSorgula.Clear();
            _txtUcretSorgula.Clear();
            _txtAracTuruSorgula.Clear();
            _txtPlakaSorgula.Clear();
            _dateTimePickerBaslangic.Checked = false;
        }
        public void Listele()
        {
            try
            {
                var entities = _baglanti.Entity();

                var sorgu = entities.Abonelikler.Join(entities.AboneUcret,
                    abone => abone.AboneUcretID,
                    u => u.AboneUcretID,
                    (abone, u) => new
                    {
                        abone.AbonePlaka,
                        abone.AbonelikTipi,
                        abone.AbonelikBaslangicTarihi,
                        abone.AbonelikBitisTarihi,
                        abone.AbonelikUcreti,
                        abone.OdemeYontemi,
                        u.AboneAracTuru
                    }).AsQueryable();

                if (_dateTimePickerBaslangic.Checked)
                {
                    DateTime secilenTarih = _dateTimePickerBaslangic.Value.Date;
                    sorgu = sorgu.Where(a => DbFunctions.TruncateTime(a.AbonelikBaslangicTarihi) == secilenTarih);
                }

                if (decimal.TryParse(_txtUcretSorgula.Text.Trim(), out decimal ucret))
                {
                    sorgu = sorgu.Where(a => a.AbonelikUcreti.ToString().StartsWith(ucret.ToString()));
                }

                if (!string.IsNullOrEmpty(_txtAracTuruSorgula.Text.Trim()))
                {
                    sorgu = sorgu.Where(a => a.AboneAracTuru.Contains(_txtAracTuruSorgula.Text.Trim()));
                }

                if (!string.IsNullOrEmpty(_txtPlakaSorgula.Text.Trim()))
                {
                    sorgu = sorgu.Where(a => a.AbonePlaka.Contains(_txtPlakaSorgula.Text.Trim()));
                }

                if (!string.IsNullOrEmpty(_txtAboneSuresiSorgula.Text.Trim()))
                {
                    var girilensure = _txtAboneSuresiSorgula.Text.Trim();
                    sorgu = sorgu.Where(a => a.AbonelikTipi.Contains(girilensure));
                }

                var aboneListesi = sorgu.ToList();

                _datagridAboneListele.DataSource = aboneListesi;
                _datagridAboneListele.ClearSelection();

                _datagridAboneListele.Columns["AbonePlaka"].HeaderText = "Plaka";
                _datagridAboneListele.Columns["AbonelikTipi"].HeaderText = "Abonelik Süresi";
                _datagridAboneListele.Columns["AbonelikBaslangicTarihi"].HeaderText = "Başlangıç Tarihi";
                _datagridAboneListele.Columns["AbonelikBitisTarihi"].HeaderText = "Bitiş Tarihi";
                _datagridAboneListele.Columns["AbonelikUcreti"].HeaderText = "Ücret";
                _datagridAboneListele.Columns["OdemeYontemi"].HeaderText = "Ödeme Yöntemi";
                _datagridAboneListele.Columns["AboneAracTuru"].HeaderText = "Araç Türü";
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
