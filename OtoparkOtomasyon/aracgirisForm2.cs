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
    public partial class aracgirisForm2 : Form
    {
        aracGirisForm _islemler;
        Baglanti baglanti = new Baglanti();
        public aracgirisForm2()
        {
            InitializeComponent();
            _islemler = new aracGirisForm(baglanti, txtMusteriAdi, txtMusteriSoyadi, txtPlaka, txtTelefonNo, cmbAracTuru, lblDogrulamaKodu, lblParkYeri);           
        }
        private void aracgirisForm2_Load(object sender, EventArgs e)
        {
            _islemler.yukle();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }       
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            _islemler.kaydet();
        }
        private async void btnIptal_Click_1(object sender, EventArgs e)
        {
            _islemler.TemizleForm();
            MesajGoster.Bilgi("İşlem iptal edildi. Alanlar temizlendi.");
            await Task.Delay(1000); // 1 saniye bekle
            _islemler.yukle();           
        }
        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else if (txtTelefonNo.Text.Length >= 10 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
