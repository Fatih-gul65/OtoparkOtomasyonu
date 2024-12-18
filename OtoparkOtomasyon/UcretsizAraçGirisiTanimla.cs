using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class UcretsizAraçGirisiTanimla : Form
    {
        OtoparkOtomasyonEntities2 entities = new OtoparkOtomasyonEntities2();
        public UcretsizAraçGirisiTanimla()
        {
            InitializeComponent();
        }

        private void tumKayitlariGoster()
        {
            var UcretsizGirisler = (from liste in entities.UcretsizGiris 
                                    select new
                                    {
                                        liste.UcretsizGirisID,
                                        liste.Plaka,
                                        liste.TanimlanmaTarihi
                                    }).ToList();

            datagridUcretsizGiris.DataSource = UcretsizGirisler;
            datagridUcretsizGiris.ClearSelection();
            txtUcretsizPlaka.Clear();
            lblUcretsizGiris.Text = "";
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void UcretsizAraçGirisiTanimla_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }

        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUcretsizPlaka.Text.Trim()))
            {
                MessageBox.Show("Lütfen Araç Plakasını Girin !");
            }
            else { 
                string plaka = txtUcretsizPlaka.Text.Trim().ToUpper();

                if (PlakaKontrolu.PlakaKontrol(plaka))
                {
                    try
                    {
                        UcretsizGiris ekle = new UcretsizGiris();
                        ekle.Plaka = plaka;
                        ekle.TanimlanmaTarihi = DateTime.Now;
                        entities.UcretsizGiris.Add(ekle);
                        entities.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tumKayitlariGoster();
                    }

                    catch (Exception ex) {
                        MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Plaka Geçersiz Lütfen Doğru Formatta Girin !");
                    txtUcretsizPlaka.Clear();
                }
                
            }
        }
        private void datagridUcretsizGiris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = datagridUcretsizGiris.SelectedCells[0].RowIndex;
            lblUcretsizGiris.Text = "Ücretsiz Giriş ID : " + datagridUcretsizGiris.Rows[secilenSatır].Cells[0].Value.ToString();
            txtUcretsizPlaka.Text = datagridUcretsizGiris.Rows[secilenSatır].Cells[1].Value.ToString();
        }
        private void btnSecilenPlakayiSil_Click(object sender, EventArgs e)
        {
            try { 
            int ucretsizGirisID = Convert.ToInt32(lblUcretsizGiris.Text.Replace("Ücretsiz Giriş ID : " , ""));
            var Ugiris = entities.UcretsizGiris.Find(ucretsizGirisID);
            entities.UcretsizGiris.Remove(Ugiris);
            MessageBox.Show("Seçili Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            entities.SaveChanges();
            tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
            }

        }

        
    }
}
