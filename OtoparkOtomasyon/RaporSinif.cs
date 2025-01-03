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
        private Label _lblGunlukKazanc, _lblHaftalikKazanc, _lblAylikKazanc;
        private TextBox _txtUcretSorgula, _txtAracTuruSorgula, _txtPlakaSorgula;
        private DateTimePicker _dateTimePickerGirisTarihi;
        private DataGridView _datagridRapor;
        public RaporSinif(Baglanti baglanti, DataGridView datagridRapor, TextBox txtUcretSorgula, TextBox txtAracTuruSorgula, TextBox txtPlakaSorgula,
            Label lblGunlukKazanc, Label lblHaftalikKazanc, Label lblAylikKazanc, DateTimePicker dateTimePickerGirisTarihi)
        {
            _baglanti = baglanti;
            _datagridRapor = datagridRapor;
            _txtUcretSorgula = txtUcretSorgula;
            _txtAracTuruSorgula = txtAracTuruSorgula;
            _txtPlakaSorgula = txtPlakaSorgula;
            _lblGunlukKazanc = lblGunlukKazanc;
            _lblHaftalikKazanc = lblHaftalikKazanc;
            _lblAylikKazanc = lblAylikKazanc;
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
