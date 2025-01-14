using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OtoparkOtomasyon
{
    internal class cs_Rapor
    {
        private cs_Baglanti _baglanti;
        private Label _lblGunlukKazanc, _lblHaftalikKazanc, _lblAylikKazanc, _lblAboneGunluk , _lblAboneHaftalik, _lblAboneAylik;
        private TextBox _txtUcretSorgula, _txtAracTuruSorgula, _txtPlakaSorgula;
        private DateTimePicker _dateTimePickerGirisTarihi;
        private DataGridView _datagridRapor;
        public cs_Rapor(cs_Baglanti baglanti, DataGridView datagridRapor, TextBox txtUcretSorgula, TextBox txtAracTuruSorgula, TextBox txtPlakaSorgula,
            Label lblGunlukKazanc, Label lblHaftalikKazanc, Label lblAylikKazanc, Label lblAboneGunluk, Label lblAboneHaftalik, Label lblAboneAylik, DateTimePicker dateTimePickerGirisTarihi)
        {
            _baglanti = baglanti;
            _datagridRapor = datagridRapor;
            _txtUcretSorgula = txtUcretSorgula;
            _txtAracTuruSorgula = txtAracTuruSorgula;
            _txtPlakaSorgula = txtPlakaSorgula;
            _lblGunlukKazanc = lblGunlukKazanc;
            _lblHaftalikKazanc = lblHaftalikKazanc;
            _lblAylikKazanc = lblAylikKazanc;
            _lblAboneGunluk = lblAboneGunluk;
            _lblAboneHaftalik = lblAboneHaftalik;
            _lblAboneAylik = lblAboneAylik;
            _dateTimePickerGirisTarihi = dateTimePickerGirisTarihi;
        }
        public void Temizle()
        {
            _txtUcretSorgula.Clear();
            _txtAracTuruSorgula.Clear();
            _txtPlakaSorgula.Clear();
            _dateTimePickerGirisTarihi.Checked = false;
        }
        public void Listele()
        {
            try
            {
                var entities = _baglanti.Entity();
                var sorgu = (from rapor in entities.Rapor
                             join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                             join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                             select new
                             {
                                 aracGiris.Plaka,
                                 aracGiris.AracTuru,
                                 aracGiris.TelefonNo,
                                 aracGiris.ParkYeri,
                                 aracGiris.GirisTarihi,
                                 aracCikis.CikisTarihi,
                                 aracCikis.ToplamUcret,
                                 aracCikis.OdemeTuru,
                                 AboneID = aracCikis.AboneID.HasValue ? aracCikis.AboneID.Value.ToString() : "Yok",
                                 UcretsizGirisID = aracCikis.UcretsizGirisID.HasValue ? aracCikis.UcretsizGirisID.Value.ToString() : "Yok"
                             }).AsQueryable();

                if (_dateTimePickerGirisTarihi.Checked)
                {
                    DateTime secilenTarih = _dateTimePickerGirisTarihi.Value.Date;
                    sorgu = sorgu.Where(a => DbFunctions.TruncateTime(a.GirisTarihi) == secilenTarih);
                }

                if (decimal.TryParse(_txtUcretSorgula.Text.Trim(), out decimal ucret))
                {
                    sorgu = sorgu.Where(a => a.ToplamUcret.ToString().StartsWith(ucret.ToString()));
                }

                if (!string.IsNullOrEmpty(_txtAracTuruSorgula.Text.Trim()))
                {
                    sorgu = sorgu.Where(a => a.AracTuru.Contains(_txtAracTuruSorgula.Text.Trim()));
                }

                if (!string.IsNullOrEmpty(_txtPlakaSorgula.Text.Trim()))
                {
                    sorgu = sorgu.Where(a => a.Plaka.Contains(_txtPlakaSorgula.Text.Trim()));
                }
                var Liste = sorgu.ToList();

                _datagridRapor.DataSource = Liste;
                _datagridRapor.ClearSelection();

                _datagridRapor.Columns["Plaka"].HeaderText = "Araç Plakası";
                _datagridRapor.Columns["AracTuru"].HeaderText = "Araç Türü";
                _datagridRapor.Columns["TelefonNo"].HeaderText = "Telefon Numarası";
                _datagridRapor.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi";
                _datagridRapor.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";
                _datagridRapor.Columns["ToplamUcret"].HeaderText = "Ödenen Ücret";
                _datagridRapor.Columns["OdemeTuru"].HeaderText = "Ödeme Yöntemi";
                _datagridRapor.Columns["AboneID"].HeaderText = "Abone ID";
                _datagridRapor.Columns["UcretsizGirisID"].HeaderText = "Ücretsiz Giriş ID";
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void KazancHesapla()
        {
            double MusteriGunlukUcret = 0;
            double MusteriHaftalikUcret = 0;
            double MusteriAylikUcret = 0;

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
                            MusteriGunlukUcret += ucret;
                        }

                        if (girisTarihi.Value.Date >= birHaftaOnce)
                        {
                            MusteriHaftalikUcret += ucret;
                        }

                        if (girisTarihi.Value.Date >= birAyOnce)
                        {
                            MusteriAylikUcret += ucret;
                        }
                    }
                }
            }
            _lblGunlukKazanc.Text = $"Müşteri Günlük Kazanç: {MusteriGunlukUcret:C}";
            _lblHaftalikKazanc.Text = $"Müşteri Haftalık Kazanç: {MusteriHaftalikUcret:C}";
            _lblAylikKazanc.Text = $"Müşteri Aylık Kazanç: {MusteriAylikUcret:C}";

            double AboneGunlukUcret = 0;
            double AboneHaftalikUcret = 0;
            double AboneAylikUcret = 0;

            try { 
            var entities = _baglanti.Entity();
            
                var abonelikUcretleri = entities.Abonelikler
                    .Where(a => a.AbonelikBaslangicTarihi >= birAyOnce)
                    .Select(b => new { b.AbonelikBaslangicTarihi, b.AbonelikUcreti })
                    .ToList();

                foreach (var ucret in abonelikUcretleri)
                {
                    if (ucret.AbonelikBaslangicTarihi.Value.Date == bugun)
                    {
                        AboneGunlukUcret += Convert.ToDouble(ucret.AbonelikUcreti);
                    }

                    if (ucret.AbonelikBaslangicTarihi.Value.Date >= birHaftaOnce)
                    {
                        AboneHaftalikUcret += Convert.ToDouble(ucret.AbonelikUcreti);
                    }

                    if (ucret.AbonelikBaslangicTarihi.Value.Date >= birAyOnce)
                    {
                        AboneAylikUcret += Convert.ToDouble(ucret.AbonelikUcreti);
                    }
                }
                _lblAboneGunluk.Text = $"Abone Günlük Kazanç: {AboneGunlukUcret:C}";
                _lblAboneHaftalik.Text = $"Abone Haftalık Kazanç: {AboneHaftalikUcret:C}";
                _lblAboneAylik.Text = $"Abone Aylık Kazanç: {AboneAylikUcret:C}";
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
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
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
