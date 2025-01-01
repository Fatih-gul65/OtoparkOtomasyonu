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
    public partial class abonelistele : Form
    {
        Baglanti baglanti = new Baglanti();
        AboneListe _islemler;

        public abonelistele()
        {
            InitializeComponent();
            _islemler = new AboneListe(baglanti , datagridAboneListele , txtAboneSuresiSorgula , txtUcretSorgula, txtAracTuruSorgula, txtPlakaSorgula, rdbtnTarihSorgula,
                rdbtnSureSorgula, rdbtnUcretSorgula, rdbtnAracTuruSorgula , rdbtnPlakaSorgula, dateTimePickerBaslangic);

            txtUcretSorgula.TextChanged += TxtUcretSorgula_TextChanged;
            txtAboneSuresiSorgula.TextChanged += txtAboneSuresiSorgula_TextChanged;
            txtAracTuruSorgula.TextChanged += txtAracTuruSorgula_TextChanged;
            txtPlakaSorgula.TextChanged += txtPlakaSorgula_TextChanged;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void abonelistele_Load(object sender, EventArgs e)
        {
            _islemler.Listele();
        }
        private void TxtUcretSorgula_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnUcretSorgula.Checked)
            {
                _islemler.UcretListele();
            }
        }
        private void txtAboneSuresiSorgula_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnSureSorgula.Checked)
            {
                _islemler.SureListele();
            }
        }
        private void txtAracTuruSorgula_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnAracTuruSorgula.Checked)
            {
                _islemler.AracTuruListele();
            }
        }
        private void txtPlakaSorgula_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnPlakaSorgula.Checked)
            {
                _islemler.PlakaListele();
            }
        }
        private void dateTimePickerBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (rdbtnTarihSorgula.Checked)
            {
               _islemler.TarihListele();
            }
        }
        private void btnSonuclariListele_Click(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
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
        private void rdbtnTarihSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnTarihSorgula.Checked)
            {
                dateTimePickerBaslangic.Visible = true;
            }
            else
            {
                dateTimePickerBaslangic.Visible = false;
            }
        }
        private void rdbtnSureSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            _islemler.Listele();
            if (rdbtnSureSorgula.Checked)
            {
                txtAboneSuresiSorgula.Visible = true;
            }
            else
            {
                txtAboneSuresiSorgula.Visible = false;
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
        private void rdbtnAracTuruSorgula_CheckedChanged(object sender, EventArgs e)
        {
            _islemler.Temizle();
            if (rdbtnAracTuruSorgula.Checked)
            {
                txtAracTuruSorgula.Visible = true;
            }
            else
            {
                txtAracTuruSorgula.Visible = false;
            }
        }
    }
}
