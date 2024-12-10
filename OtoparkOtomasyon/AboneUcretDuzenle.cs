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
    public partial class AboneUcretDuzenle : Form
    {
        public AboneUcretDuzenle()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris geri = new YoneticiGiris();
            geri.Show();
            this.Hide();
        }

        private void AboneUcretDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
