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
    public partial class frm_Rapor : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        cs_Rapor _islemler;
        public frm_Rapor()
        {
            InitializeComponent();
            _islemler = new cs_Rapor(baglanti, datagridRapor, txtUcretSorgula, txtAracTuruSorgula, 
                txtPlakaSorgula, lblGunlukKazanc, lblHaftalikKazanc, lblAylikKazanc, lblAboneGunluk , lblAboneHaftalik, lblAboneAylik, dateTimePickerGirisTarihi);

            txtUcretSorgula.TextChanged += txtUcretSorgula_TextChanged;
            txtAracTuruSorgula.TextChanged += txtAracTuruSorgula_TextChanged;
            txtPlakaSorgula.TextChanged += txtPlakaSorgula_TextChanged;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiGiris yoneticiGiris = new frm_YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }
        private void RaporOlustur_Load(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            _islemler.KazancHesapla();
        }
        private void btnSonuclariListele_Click(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            _islemler.KazancHesapla();
        }
        private void txtAracTuruSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtUcretSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtPlakaSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void dateTimePickerGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            _islemler.ExcelAktar(datagridRapor);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = cs_MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                frm_Rapor ac = new frm_Rapor();
                ac.Show();
            }
        }
    }
}
