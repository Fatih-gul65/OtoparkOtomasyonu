using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class RaporOlustur : Form
    {

        public RaporOlustur()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void RaporOlustur_Load(object sender, EventArgs e)
        {
            try
            {
                Baglanti baglanti = new Baglanti();
                var entities = baglanti.Entity();

                var raporVerileri = (from rapor in entities.Rapor
                                     join aracGiris in entities.AracGiris on rapor.GirisID equals aracGiris.GirisID
                                     join aracCikis in entities.AracCikis on rapor.CikisID equals aracCikis.CikisID
                                     join otoparkDurumu in entities.OtoparkDurumu on rapor.OtoparkID equals otoparkDurumu.OtoparkID
                                     select new
                                     {
                                         aracGiris.MusteriAdi,
                                         aracGiris.MusteriSoyadi,
                                         aracGiris.Plaka,
                                         aracGiris.AracTuru,
                                         aracGiris.TelefonNo,
                                         aracGiris.ParkYeri,
                                         aracGiris.GirisTarihi,
                                         aracCikis.CikisTarihi,
                                         aracCikis.ToplamUcret,
                                         aracCikis.OdemeTuru,
                                         otoparkDurumu.Doluluk,
                                         otoparkDurumu.BosAlan
                                     }).ToList();

                datagridRapor.DataSource = raporVerileri;
                
            }
            catch(Exception ex) {
                MesajGoster.Hata(ex.Message);
            }

            datagridRapor.Columns["MusteriAdi"].HeaderText = "Müşteri Adı";
        }

        private void btnSonuclariListele_Click(object sender, EventArgs e)
        {
            
        }
    }
}
