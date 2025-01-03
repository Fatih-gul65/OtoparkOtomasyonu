using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class KullaniciSifreDegistir : Form
    {
        YoneticiSifre _islemler;
        public KullaniciSifreDegistir()
        {
            InitializeComponent();
            _islemler = new YoneticiSifre(txtYoneticiAdi, txtYoneticiSifre);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.Show();
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Ekle();
        }
    }
}
