using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_AboneListele : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        cs_AboneListe _islemler;
        public frm_AboneListele()
        {
            InitializeComponent();
            _islemler = new cs_AboneListe(baglanti, datagridAboneListele, txtAboneSuresiSorgula, txtUcretSorgula, txtAracTuruSorgula, txtPlakaSorgula, dateTimePickerBaslangic);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi personelGirisi = new frm_PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void abonelistele_Load(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtUcretSorgula_TextChanged_1(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtAboneSuresiSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtAracTuruSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void txtPlakaSorgula_TextChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void dateTimePickerBaslangic_ValueChanged(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void btnSonuclariListele_Click(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
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
                frm_AboneListele ac = new frm_AboneListele();
                ac.Show();
            }
        }
    }
}
