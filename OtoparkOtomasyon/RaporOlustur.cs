using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class RaporOlustur : Form
    {
        Baglanti baglanti = new Baglanti();
        RaporSinif _islemler;
        public RaporOlustur()
        {
            InitializeComponent();
            _islemler = new RaporSinif(baglanti, datagridRapor, txtUcretSorgula, txtAracTuruSorgula, 
                txtPlakaSorgula, lblGunlukKazanc, lblHaftalikKazanc, lblAylikKazanc, rdbtnTarihSorgula, 
                rdbtnUcretSorgula, rdbtnAracTuruSorgula, rdbtnPlakaSorgula, dateTimePickerGirisTarihi);

            txtUcretSorgula.TextChanged += txtUcretSorgula_TextChanged;
            txtAracTuruSorgula.TextChanged += txtAracTuruSorgula_TextChanged;
            txtPlakaSorgula.TextChanged += txtPlakaSorgula_TextChanged;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }
        private void RaporOlustur_Load(object sender, EventArgs e)
        {
            _islemler.Listele();
            _islemler.KazancHesapla();
        }
        private void btnSonuclariListele_Click(object sender, EventArgs e)
        {
            _islemler.Listele();
            _islemler.Temizle();
            _islemler.RadioButonlariTemizle();
        }
        private void txtAracTuruSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.AracTuruListele();
        }
        private void txtUcretSorgula_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnUcretSorgula.Checked)
            {
                _islemler.UcretListele();
            }
        }
        private void txtPlakaSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.PlakaListele();
        }
        private void rdbtnUcretSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnUcretSorgula.Checked)
            {
                txtUcretSorgula.Visible = true;
            }
            else
            {
                txtUcretSorgula.Visible = false;
            }
        }
        private void dateTimePickerGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (rdbtnTarihSorgula.Checked)
            {
                _islemler.BaslangicTarihiListele();
            }
        }
        private void rdbtnTarihSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnTarihSorgula.Checked)
            {
                dateTimePickerGirisTarihi.Visible = true;
            }
            else
            {
                dateTimePickerGirisTarihi.Visible = false;
            }
        }
        private void rdbtnAracTuruSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnAracTuruSorgula.Checked)
            {
                txtAracTuruSorgula.Visible = true;
            }
            else
            {
                txtAracTuruSorgula.Visible = false;
            }
        }
        private void rdbtnPlakaSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnPlakaSorgula.Checked)
            {
                txtPlakaSorgula.Visible = true;
            }
            else
            {
                txtPlakaSorgula.Visible = false;
            }
        }
        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            _islemler.ExcelAktar(datagridRapor);
        }
    }
}
