using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class otoParkDolulukForm
    {
        private Baglanti _baglanti;
        private FlowLayoutPanel _otomobilPanel;
        private FlowLayoutPanel _kamyonetPanel;
        private FlowLayoutPanel _minibusPanel;

        public otoParkDolulukForm(Baglanti baglanti, FlowLayoutPanel otomobilPanel, FlowLayoutPanel kamyonetPanel, FlowLayoutPanel minibusPanel)
        {
            _baglanti = baglanti;
            _otomobilPanel = otomobilPanel;
            _kamyonetPanel = kamyonetPanel;
            _minibusPanel = minibusPanel;

            ParkYeriGetir();
        }

        private void ParkYeriGetir()
        {
            try
            {
                var entities = _baglanti.Entity();
                var kapasite = entities.AracKapasitesi.FirstOrDefault();

                if (kapasite != null)
                {
                    // Nullable değerleri sıfırla veya bir değer ata
                    int otomobilKapasitesi = kapasite.OtomobilKapasitesi ?? 0;
                    int kamyonetKapasitesi = kapasite.KamyonetKapasitesi ?? 0;
                    int minibusKapasitesi = kapasite.MinibusKapasitesi ?? 0;


                    // Kapasitelere göre panelleri doldur
                    ButonYap(_otomobilPanel, otomobilKapasitesi, "A");
                    ButonYap(_kamyonetPanel, kamyonetKapasitesi, "B");
                    ButonYap(_minibusPanel, minibusKapasitesi, "C");
                }
                else
                {
                    MessageBox.Show("Veritabanında kapasite bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Park yerlerini al
                var parkYerleri = entities.ParkYeri.ToList();

                // Park yerlerini her araç tipine göre işle
                foreach (var parkYeri in parkYerleri)
                {
                    FlowLayoutPanel panel = null;  // Paneli burada tanımlıyoruz
                    Button btn = null;

                    // Araç tipi kontrolü
                    if (parkYeri.ParkYeri1.Contains("A"))
                    {
                        panel = _otomobilPanel;
                    }
                    else if (parkYeri.ParkYeri1.Contains("B"))
                    {
                        panel = _kamyonetPanel;
                    }
                    else if (parkYeri.ParkYeri1.Contains("C"))
                    {
                        panel = _minibusPanel;
                    }

                    // Eğer panel bulunduysa, butonu kontrol et
                    if (panel != null)
                    {
                        string parkYerii = $"{parkYeri.ParkYeri1}"; // Park yeri etiketi oluştur

                        // Park yeri etiketi ile mevcut butonu bul
                        btn = panel.Controls
                                    .Cast<Button>()
                                    .FirstOrDefault(b => b.Text == parkYerii);

                        // Eğer buton bulunursa, doluluk durumuna göre rengini değiştir
                        if (btn != null)
                        {
                            // Araç varsa, buton rengini kırmızı yap
                            if (parkYeri.ParkYeriID != 0) // Eğer park yerinde araç varsa
                            {
                                btn.BackColor = Color.Red; // Dolu
                            }
                            else
                            {
                                btn.BackColor = Color.Green; // Boş
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Park yerleri getirilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButonYap(FlowLayoutPanel panel, int kapasite, string aracTipi)
        {
            try
            {
                panel.Controls.Clear(); // Paneli temizle

                if (kapasite == 0)
                {
                    Label lbl = new Label
                    {
                        Text = $"{aracTipi} kapasitesi bulunamadı.",
                        ForeColor = Color.Red, // Hata mesajı kırmızı
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Width = 200,
                        Height = 100,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    panel.Controls.Add(lbl);
                }
                else
                {
                    for (int i = 1; i <= kapasite; i++)
                    {
                        Button btn = new Button
                        {
                            Text = $"{aracTipi}{i}",
                            BackColor = Color.Chartreuse, // Başlangıçta boş
                            Width = 100,
                            Height = 50,
                            Enabled = false // Tıklanamaz
                        };
                        panel.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Butonlar oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
