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
            _islemler = new AboneListe(baglanti , datagridAboneListele);
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

       
    }
}
