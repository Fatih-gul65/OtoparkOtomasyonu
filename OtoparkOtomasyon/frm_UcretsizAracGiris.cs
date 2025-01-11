using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_UcretsizAracGiris : Form
    {
        private cs_UcretsizAracGiris _islemler;
        public frm_UcretsizAracGiris()
        {
            InitializeComponent();
            _islemler = new cs_UcretsizAracGiris(datagridUcretsizGiris, txtUcretsizPlaka, lblUcretsizGiris);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiGiris yoneticiGiris = new frm_YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }
        private void UcretsizAraçGirisiTanimla_Load(object sender, EventArgs e)
        {
            _islemler.TumKayitlariGoster();
        }
        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            string plaka = txtUcretsizPlaka.Text.Trim();
            _islemler.PlakaEkle(plaka);
        }
        private void datagridUcretsizGiris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = datagridUcretsizGiris.SelectedCells[0].RowIndex;
            lblUcretsizGiris.Text = "Ücretsiz Giriş ID : " + datagridUcretsizGiris.Rows[secilenSatır].Cells[0].Value.ToString();
            txtUcretsizPlaka.Text = datagridUcretsizGiris.Rows[secilenSatır].Cells[1].Value.ToString();
        }
        private void btnSecilenPlakayiSil_Click(object sender, EventArgs e)
        {
            if (datagridUcretsizGiris.SelectedCells.Count > 0)
            {
                int ucretsizGirisID = Convert.ToInt32(lblUcretsizGiris.Text.Replace("Ücretsiz Giriş ID : ", ""));
                _islemler.PlakaSil(ucretsizGirisID);
            }
            else
            {
                cs_MesajGoster.Uyari("Lütfen Kayıt Seçiniz");
            }
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
                frm_UcretsizAracGiris ac = new frm_UcretsizAracGiris();
                ac.Show();
            }
        }
    }
}
