using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class abonelikForm4 : Form
    {
        Baglanti baglanti = new Baglanti();
        abonelikForm _islemler;
        public abonelikForm4()
        {
            InitializeComponent();
            _islemler = new abonelikForm(baglanti, cmbAracTuru, cmbAbonelikSuresi, txtAracPlakasi, rdbtnNakit ,rdbtnKrediKart,lblTutar , lblOtomobilAbone , lblMinibusAbone , lblKamyonetAbone);
        }
        private void abonelikForm4_Load(object sender, EventArgs e)
        {
         _islemler.yukle();
        _islemler.AboneUcretGoster();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.kaydet();
        }
        private void cmbAracTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            _islemler.fiyatGoster();
        }
        private void cmbAbonelikSuresi_SelectedIndexChanged(object sender, EventArgs e)
        {
            _islemler.fiyatGoster();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                abonelikForm4 ac = new abonelikForm4();
                ac.Show();
            }
        }
    }
}
