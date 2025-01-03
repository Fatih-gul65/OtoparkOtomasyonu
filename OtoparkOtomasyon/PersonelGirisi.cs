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
    public partial class PersonelGirisi : Form
    {
        public PersonelGirisi()
        {
            InitializeComponent();
        }
        private void btnAracGiris_Click_1(object sender, EventArgs e)
        {
            aracgirisForm2 form2 = new aracgirisForm2();
            form2.Show();
            this.Close();
        }
        private void btnAracCikis_Click_1(object sender, EventArgs e)
        {
            aracikisForm3 form3 = new aracikisForm3();
            form3.Show();
            this.Close();
        }
        private void btnOtoparkDoluluk_Click_1(object sender, EventArgs e)
        {
            otoparkdolulukForm6 form4 = new otoparkdolulukForm6();
            form4.Show();
            this.Close();
        }
        private void btnAracBul_Click_1(object sender, EventArgs e)
        {
            aracbul form5 = new aracbul();
            form5.Show();
            this.Close();
        }
        private void btnAboneEkle_Click_1(object sender, EventArgs e)
        {
            abonelikForm4 form6 = new abonelikForm4();
            form6.Show();
            this.Close();
        }
        private void btnAboneListele_Click_1(object sender, EventArgs e)
        {
            abonelistele form7 = new abonelistele();
            form7.Show();
            this.Close();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelDogrula personeldogrula = new PersonelDogrula();
            personeldogrula.Show();
            this.Close();
        }
    }   
}
