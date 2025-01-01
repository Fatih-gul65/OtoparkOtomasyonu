using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OtoparkOtomasyon
{
    internal class RaporSinif
    {
        private Baglanti _baglanti;
        private RadioButton _rdbtnTarihSorgula, _rdbtnUcretSorgula, _rdbtnAracTuruSorgula, _rdbtnPlakaSorgula;
        private Label _lblGunlukKazanc, _lblHaftalikKazanc, _lblAylikKazanc;
        private TextBox _txtUcretSorgula, _txtAracTuruSorgula, _txtPlakaSorgula;
        private DateTimePicker _dateTimePickerGirisTarihi;
        private DataGridView _datagridRapor;
        public RaporSinif(Baglanti baglanti, DataGridView datagridRapor, TextBox txtUcretSorgula, TextBox txtAracTuruSorgula, TextBox txtPlakaSorgula,
            Label lblGunlukKazanc, Label lblHaftalikKazanc, Label lblAylikKazanc,
            RadioButton rdbtnTarihSorgula, RadioButton rdbtnUcretSorgula, RadioButton rdbtnAracTuruSorgula, RadioButton rdbtnPlakaSorgula, DateTimePicker dateTimePickerGirisTarihi)
        {
            _baglanti = baglanti;
            _datagridRapor = datagridRapor;
            _txtUcretSorgula = txtUcretSorgula;
            _txtAracTuruSorgula = txtAracTuruSorgula;
            _txtPlakaSorgula = txtPlakaSorgula;
            _lblGunlukKazanc = lblGunlukKazanc;
            _lblHaftalikKazanc = lblHaftalikKazanc;
            _lblAylikKazanc = lblAylikKazanc;
            _rdbtnTarihSorgula = rdbtnTarihSorgula;
            _rdbtnUcretSorgula = rdbtnUcretSorgula;
            _rdbtnAracTuruSorgula = rdbtnAracTuruSorgula;
            _rdbtnPlakaSorgula = rdbtnPlakaSorgula;
            _dateTimePickerGirisTarihi = dateTimePickerGirisTarihi;
        }
        public void Temizle()
        {
            _txtUcretSorgula.Clear();
            _txtAracTuruSorgula.Clear();
            _txtPlakaSorgula.Clear();
        }
        public void RadioButonlariTemizle()
        {
            _rdbtnTarihSorgula.Checked = false;
            _rdbtnUcretSorgula.Checked = false;
            _rdbtnAracTuruSorgula.Checked = false;
            _rdbtnPlakaSorgula.Checked = false;
        }
        public void Listele()
        {
            try
            {
                var entities = _baglanti.Entity();

                var raporVerileri = (from rapor in entities.Rapor
                                     join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                     join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                     join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                     select new
                                     {
                                         aracGiris.MusteriAdi,
                                         aracGiris.MusteriSoyadi,
                                         aracGiris.Plaka,
                                         aracGiris.AracTuru,
                                         aracGiris.TelefonNo,
                                         aracGiris.ParkYeri,
                                         aracGiris.GirisTarihi,
                                         aracCikis.CikisTarihi,
                                         aracCikis.ToplamUcret,
                                         aracCikis.OdemeTuru,
                                         AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                         UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok",
                                         otoparkDurumu.ToplamDoluAlan,
                                         otoparkDurumu.ToplamBosAlan,
                                         otoparkDurumu.ToplamKapasite
                                     }).ToList();
                _datagridRapor.DataSource = raporVerileri;
                _datagridRapor.ClearSelection();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
            _datagridRapor.Columns["MusteriAdi"].HeaderText = "Müşteri Adı";
            _datagridRapor.Columns["MusteriSoyadi"].HeaderText = "Müşteri Soyadı";
            _datagridRapor.Columns["Plaka"].HeaderText = "Araç Plakası";
            _datagridRapor.Columns["AracTuru"].HeaderText = "Araç Türü";
            _datagridRapor.Columns["TelefonNo"].HeaderText = "Telefon Numarası";
            _datagridRapor.Columns["AracTuru"].HeaderText = "Araç Türü";
            _datagridRapor.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi";
            _datagridRapor.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";
            _datagridRapor.Columns["ToplamUcret"].HeaderText = "Ödenen Ücret";
            _datagridRapor.Columns["OdemeTuru"].HeaderText = "Ödeme Yöntemi";
            _datagridRapor.Columns["AboneID"].HeaderText = "Abone ID";
            _datagridRapor.Columns["UcretsizGirisID"].HeaderText = "Ücretsiz Giriş ID";
            _datagridRapor.Columns["ToplamDoluAlan"].HeaderText = "Toplam Dolu Alan";
            _datagridRapor.Columns["ToplamBosAlan"].HeaderText = "Toplam Boş Alan";
            _datagridRapor.Columns["ToplamKapasite"].HeaderText = "Toplam Kapasite";
        }
        public void UcretListele()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (decimal.TryParse(_txtUcretSorgula.Text.Trim(), out decimal ucret))
                {
                    var raporVerileri = (from rapor in entities.Rapor
                                         join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                         join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                         join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                         select new
                                         {
                                             aracGiris.MusteriAdi,
                                             aracGiris.MusteriSoyadi,
                                             aracGiris.Plaka,
                                             aracGiris.AracTuru,
                                             aracGiris.TelefonNo,
                                             aracGiris.ParkYeri,
                                             aracGiris.GirisTarihi,
                                             aracCikis.CikisTarihi,
                                             aracCikis.ToplamUcret,
                                             aracCikis.OdemeTuru,
                                             AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                             UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok",
                                             otoparkDurumu.ToplamDoluAlan,
                                             otoparkDurumu.ToplamBosAlan,
                                             otoparkDurumu.ToplamKapasite
                                         }).Where(a => a.ToplamUcret.ToString().StartsWith(ucret.ToString())).ToList();

                    _datagridRapor.DataSource = raporVerileri;
                    _datagridRapor.ClearSelection();
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
        public void BaslangicTarihiListele()
        {
            try
            {
                var entities = _baglanti.Entity();
                DateTime secilenTarih = _dateTimePickerGirisTarihi.Value.Date;

                var tarihler = (from rapor in entities.Rapor
                                join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                where DbFunctions.TruncateTime(aracGiris.GirisTarihi) == secilenTarih
                                select new
                                {
                                    aracGiris.MusteriAdi,
                                    aracGiris.MusteriSoyadi,
                                    aracGiris.Plaka,
                                    aracGiris.AracTuru,
                                    aracGiris.TelefonNo,
                                    aracGiris.ParkYeri,
                                    aracGiris.GirisTarihi,
                                    aracCikis.CikisTarihi,
                                    aracCikis.ToplamUcret,
                                    aracCikis.OdemeTuru,
                                    AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                    UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok",
                                    otoparkDurumu.ToplamDoluAlan,
                                    otoparkDurumu.ToplamBosAlan,
                                    otoparkDurumu.ToplamKapasite
                                }).ToList();

                _datagridRapor.DataSource = tarihler;
                _datagridRapor.ClearSelection();
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
                    var raporVerileri = (from rapor in entities.Rapor
                                         join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                         join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                         join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                         select new
                                         {
                                             aracGiris.MusteriAdi,
                                             aracGiris.MusteriSoyadi,
                                             aracGiris.Plaka,
                                             aracGiris.AracTuru,
                                             aracGiris.TelefonNo,
                                             aracGiris.ParkYeri,
                                             aracGiris.GirisTarihi,
                                             aracCikis.CikisTarihi,
                                             aracCikis.ToplamUcret,
                                             aracCikis.OdemeTuru,
                                             AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                             UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok",
                                             otoparkDurumu.ToplamDoluAlan,
                                             otoparkDurumu.ToplamBosAlan,
                                             otoparkDurumu.ToplamKapasite
                                         })
                        .Where(a => a.Plaka.Contains(_txtPlakaSorgula.Text.Trim()))
                        .ToList();

                    _datagridRapor.DataSource = raporVerileri;
                    _datagridRapor.ClearSelection();
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
        public void AracTuruListele()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (!string.IsNullOrEmpty(_txtAracTuruSorgula.Text.Trim()))
                {
                    var liste = (from rapor in entities.Rapor
                                 join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                 join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                 join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                 select new
                                 {
                                     aracGiris.MusteriAdi,
                                     aracGiris.MusteriSoyadi,
                                     aracGiris.Plaka,
                                     aracGiris.AracTuru,
                                     aracGiris.TelefonNo,
                                     aracGiris.ParkYeri,
                                     aracGiris.GirisTarihi,
                                     aracCikis.CikisTarihi,
                                     aracCikis.ToplamUcret,
                                     aracCikis.OdemeTuru,
                                     AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                     UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok",
                                     otoparkDurumu.ToplamDoluAlan,
                                     otoparkDurumu.ToplamBosAlan,
                                     otoparkDurumu.ToplamKapasite
                                 })
                                .Where(u => u.AracTuru.Contains(_txtAracTuruSorgula.Text.Trim())).ToList();
                    _datagridRapor.DataSource = liste;
                    _datagridRapor.ClearSelection();
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
        public void KazancHesapla()
        {
            double toplamUcretBugun = 0;
            double toplamUcretHaftalik = 0;
            double toplamUcretAylik = 0;

            DateTime bugun = DateTime.Today;
            DateTime birHaftaOnce = bugun.AddDays(-7);
            DateTime birAyOnce = bugun.AddMonths(-1);

            foreach (DataGridViewRow satir in _datagridRapor.Rows)
            {
                if (satir.Cells["ToplamUcret"]?.Value != null)
                {
                    double ucret;
                    DateTime? girisTarihi = satir.Cells["GirisTarihi"]?.Value as DateTime?;

                    if (double.TryParse(satir.Cells["ToplamUcret"].Value.ToString(), out ucret) && girisTarihi.HasValue)
                    {
                        if (girisTarihi.Value.Date == bugun)
                        {
                            toplamUcretBugun += ucret;
                        }

                        if (girisTarihi.Value.Date >= birHaftaOnce)
                        {
                            toplamUcretHaftalik += ucret;
                        }

                        if (girisTarihi.Value.Date >= birAyOnce)
                        {
                            toplamUcretAylik += ucret;
                        }
                    }
                }
            }
            double gunlukKazanc = toplamUcretBugun;
            double haftalikKazanc = toplamUcretHaftalik;
            double aylikKazanc = toplamUcretAylik;

            _lblGunlukKazanc.Text = $"Günlük Kazanç: {gunlukKazanc:C}";
            _lblHaftalikKazanc.Text = $"Haftalık Kazanç: {haftalikKazanc:C}";
            _lblAylikKazanc.Text = $"Aylık Kazanç: {aylikKazanc:C}";
        }
        public void ExcelAktar(DataGridView dataGridView)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    excelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }
                excelApp.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                excelApp = null;
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
