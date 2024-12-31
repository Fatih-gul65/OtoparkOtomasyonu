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
    internal class AboneListe
    {
        private Baglanti _baglanti;
        private DataGridView _datagridAboneListele;
        private TextBox _txtAboneSuresiSorgula, _txtUcretSorgula, _txtAracTuruSorgula, _txtPlakaSorgula;
        private RadioButton _rdbtnTarihSorgula , _rdbtnSureSorgula , _rdbtnUcretSorgula , _rdbtnAracTuruSorgula , _rdbtnPlakaSorgula;
        private DateTimePicker _dateTimePickerBaslangic;

        public AboneListe(Baglanti baglanti, DataGridView datagridAboneListele , TextBox txtAboneSuresiSorgula , TextBox txtUcretSorgula , TextBox txtAracTuruSorgula , TextBox txtPlakaSorgula,
            RadioButton rdbtnTarihSorgula , RadioButton rdbtnSureSorgula , RadioButton rdbtnUcretSorgula , RadioButton rdbtnAracTuruSorgula , RadioButton rdbtnPlakaSorgula , DateTimePicker dateTimePickerBaslangic)
        {
            _baglanti = baglanti;
            _datagridAboneListele = datagridAboneListele;
            _txtAboneSuresiSorgula = txtAboneSuresiSorgula;
            _txtUcretSorgula = txtUcretSorgula;
            _txtAracTuruSorgula = txtAracTuruSorgula;
            _txtPlakaSorgula = txtPlakaSorgula;
            _rdbtnTarihSorgula = rdbtnTarihSorgula;
            _rdbtnSureSorgula = rdbtnSureSorgula;
            _rdbtnUcretSorgula = rdbtnUcretSorgula;
            _rdbtnAracTuruSorgula = rdbtnAracTuruSorgula;
            _rdbtnPlakaSorgula = rdbtnPlakaSorgula;
            _dateTimePickerBaslangic = dateTimePickerBaslangic;
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

                _datagridAboneListele.Columns["AbonePlaka"].HeaderText = "Plaka";
                _datagridAboneListele.Columns["AbonelikTipi"].HeaderText = "Abonelik Süresi";
                _datagridAboneListele.Columns["AbonelikBaslangicTarihi"].HeaderText = "Başlangıç Tarihi";
                _datagridAboneListele.Columns["AbonelikBitisTarihi"].HeaderText = "Bitiş Tarihi";
                _datagridAboneListele.Columns["AbonelikUcreti"].HeaderText = "Ücret";
                _datagridAboneListele.Columns["OdemeYontemi"].HeaderText = "Ödeme Yöntemi";
                _datagridAboneListele.Columns["AboneAracTuru"].HeaderText = "Araç Türü";

                _txtAboneSuresiSorgula.Clear();
                _txtUcretSorgula.Clear();
                _txtAracTuruSorgula.Clear();
                _txtPlakaSorgula.Clear();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void UcretListele()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (decimal.TryParse(_txtUcretSorgula.Text.Trim(), out decimal ucret))
                {
                    var liste = entities.Abonelikler
                        .Join(entities.AboneUcret,
                            abone => abone.AboneUcretID,
                            ucretEntity => ucretEntity.AboneUcretID,
                            (abone, ucretEntity) => new
                            {
                                abone.AbonePlaka,
                                abone.AbonelikTipi,
                                abone.AbonelikBaslangicTarihi,
                                abone.AbonelikBitisTarihi,
                                abone.AbonelikUcreti,
                                abone.OdemeYontemi,
                                ucretEntity.AboneAracTuru
                            })
                        .Where(a => a.AbonelikUcreti.ToString().StartsWith(ucret.ToString()))
                        .ToList();

                    _datagridAboneListele.DataSource = liste;
                    _datagridAboneListele.ClearSelection();
                }
                else if (string.IsNullOrEmpty(_txtUcretSorgula.Text.Trim()))
                {
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void SureListele()
        {
            try
            {
                var entities = _baglanti.Entity();
                string girilenSure = _txtAboneSuresiSorgula.Text;

                var aboneListesi = entities.Abonelikler
                    .Where(abone => abone.AbonelikTipi.Contains(girilenSure))
                    .Join(entities.AboneUcret,
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
        public void AracTuruListele()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (!string.IsNullOrEmpty(_txtAracTuruSorgula.Text.Trim()))
                {
                    var liste = entities.Abonelikler.Join(entities.AboneUcret,
                        a => a.AboneUcretID,
                        u => u.AboneUcretID,
                        (a, u) => new
                        {
                            a.AbonePlaka,                
                            a.AbonelikTipi,             
                            a.AbonelikBaslangicTarihi,   
                            a.AbonelikBitisTarihi,      
                            a.AbonelikUcreti,           
                            a.OdemeYontemi,             
                            u.AboneAracTuru              
                        })
                        .Where(u => u.AboneAracTuru.Contains(_txtAracTuruSorgula.Text.Trim()))
                        .ToList();

                    _datagridAboneListele.DataSource = liste;
                    _datagridAboneListele.ClearSelection();
                }
                else if (string.IsNullOrEmpty(_txtAracTuruSorgula.Text.Trim()))
                {
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void PlakaListele()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (!string.IsNullOrEmpty(_txtPlakaSorgula.Text.Trim()))
                {
                    var liste = entities.Abonelikler.Join(entities.AboneUcret,
                        a => a.AboneUcretID,
                        u => u.AboneUcretID,
                        (a, u) => new
                        {
                            a.AbonePlaka,                
                            a.AbonelikTipi,             
                            a.AbonelikBaslangicTarihi,   
                            a.AbonelikBitisTarihi,       
                            a.AbonelikUcreti,            
                            a.OdemeYontemi,              
                            u.AboneAracTuru              
                        })
                        .Where(a => a.AbonePlaka.Contains(_txtPlakaSorgula.Text.Trim()))
                        .ToList();

                    _datagridAboneListele.DataSource = liste;
                    _datagridAboneListele.ClearSelection();
                }
                else if (string.IsNullOrEmpty(_txtPlakaSorgula.Text.Trim()))
                {
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
        public void TarihListele()
        {
            try
            {
                var entities = _baglanti.Entity();
                DateTime secilenTarih = _dateTimePickerBaslangic.Value.Date;

                var tarihler = (from abone in entities.Abonelikler
                                join ucret in entities.AboneUcret on abone.AboneUcretID equals ucret.AboneUcretID
                                where DbFunctions.TruncateTime(abone.AbonelikBaslangicTarihi) == secilenTarih
                                select new
                                {
                                    abone.AbonePlaka,
                                    abone.AbonelikTipi,
                                    abone.AbonelikBaslangicTarihi,
                                    abone.AbonelikBitisTarihi,
                                    abone.AbonelikUcreti,
                                    abone.OdemeYontemi,
                                    ucret.AboneAracTuru
                                }).ToList();

                _datagridAboneListele.DataSource = tarihler;
                _datagridAboneListele.ClearSelection();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
