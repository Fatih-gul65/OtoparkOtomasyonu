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
    public partial class otoparkdolulukForm6 : Form
    {
        Baglanti baglanti = new Baglanti();
        otoParkDolulukForm _islemler;

        public otoparkdolulukForm6()
        {
            InitializeComponent();
            _islemler = new otoParkDolulukForm(baglanti, lblDoluAlan, lblBosAlan, lblKapasite);


        }

        private void otoparkdolulukForm6_Load(object sender, EventArgs e)
        {
            _islemler.GuncelleDoluluk();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
    }
}
