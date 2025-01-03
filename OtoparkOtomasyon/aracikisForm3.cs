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
    public partial class aracikisForm3 : Form
    {
        aracCikisForm _islemler;
        Baglanti baglanti = new Baglanti();
        public aracikisForm3()
        {
            InitializeComponent();
            _islemler = new aracCikisForm(baglanti, txtAracPlakasi, txtDogrulamaKodu, lblTutar, lblKalinanSure, rdbtnNakit,rdbtnKrediKart);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void btnUcretHesapla_Click_1(object sender, EventArgs e)
        {
            _islemler.Hesapla();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Kaydet();
        }
    }
}
