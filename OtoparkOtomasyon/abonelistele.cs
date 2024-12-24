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

        public abonelistele()
        {
            InitializeComponent();

        }

     

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

        private void abonelistele_Load(object sender, EventArgs e)
        {
            var entities = baglanti.Entity();
            var aboneler = entities.Abonelikler.OrderBy(a => a.AboneID).ToList();

            // DataGridView'e verileri aktar
            datagridAboneListele.DataSource = aboneler;
        }

       
    }
}
