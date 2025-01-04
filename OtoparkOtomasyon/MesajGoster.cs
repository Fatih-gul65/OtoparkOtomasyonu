using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class MesajGoster
    {
        public static void Hata(string mesaj)
        {
            MessageBox.Show("Bir hata ile karşılaşıldı : " + mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Bilgi(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Uyari(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void GecersizPlaka()
        {
            Uyari("Plaka Geçersiz Lütfen Doğru Formatta Girin !");
        }
        public static void BosPlaka()
        {
            Uyari("Lütfen Araç Plakasını Girin !");
        }
        public static void KayitliPlaka()
        {
            Uyari("Bu Plaka Zaten Sistemde Kayıtlı!");
        }

        public static DialogResult OnayAl(string mesaj)
        {
            return MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
