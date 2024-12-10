using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class AracUcretDuzenle : Form
    {
        public AracUcretDuzenle()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris geri = new YoneticiGiris();
            geri.Show();
            this.Close();
        }

        private void AracUcretDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
