namespace SansOyunu.UI
{
    public partial class Form1 : Form
    {
        List<string> secenekler = new List<string> { "Kırmızı", "Mavi", "Yeşil", "Sarı", "Mor" };
        Random rnd = new Random();
        Label lblDurum;

        public Form1()
        {
            InitializeComponent();
            cmbSecim.Items.Clear(); // Önce temizle
            cmbSecim.Items.AddRange(secenekler.ToArray()); // Seçenekleri ekle

            // Sonuç etiketi
            lblDurum = new Label();
            lblDurum.ForeColor = Color.Black;
            lblDurum.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(100, 400);
            Controls.Add(lblDurum);
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (cmbSecim.SelectedItem != null)
            {
                string kullaniciSecimi = cmbSecim.SelectedItem.ToString();
                string rastgeleSecim = secenekler[rnd.Next(secenekler.Count)];

                listBoxSonuclar.Items.Add("Senin Seçimin: " + kullaniciSecimi);
                listBoxSonuclar.Items.Add("Şanslı Seçim: " + rastgeleSecim);

                if (kullaniciSecimi == rastgeleSecim)
                {
                    lblSonuc.Text = "Tebrikler! Kazandın 🎉";
                    lblSonuc.ForeColor = Color.Green;
                    BackColor = Color.LightGreen;
                    lblDurum.Text = "Kazandınız!";
                }
                else
                {
                    lblSonuc.Text = "Maalesef kaybettiniz! 😞";
                    lblSonuc.ForeColor = Color.Red;
                    BackColor = Color.DarkRed;
                    lblDurum.Text = "Kaybettiniz!";
                }

                // Şanslı seçim rengine göre sonucu renklendir
                switch (rastgeleSecim)
                {
                    case "Kırmızı":
                        lblSonuc.ForeColor = Color.Red;
                        BackColor = Color.Red;
                        break;
                    case "Mavi":
                        lblSonuc.ForeColor = Color.Blue;
                        BackColor = Color.Blue;
                        break;
                    case "Yeşil":
                        lblSonuc.ForeColor = Color.Green;
                        BackColor = Color.Green;
                        break;
                    case "Sarı":
                        lblSonuc.ForeColor = Color.Yellow;
                        BackColor = Color.Yellow;
                        break;
                    case "Mor":
                        lblSonuc.ForeColor = Color.Purple;
                        BackColor = Color.Purple;
                        break;
                }

                cmbSecim.Enabled = false; // Seçim yapıldıktan sonra ComboBox devre dışı bırakılır
                btnOyna.Enabled = false; // Oyna butonu devre dışı bırakılır
                btnTekrar.Enabled = true; // Tekrar butonu aktif edilir
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            cmbSecim.SelectedIndex = -1;
            listBoxSonuclar.Items.Clear();
            lblSonuc.Text = "";
            lblSonuc.ForeColor = Color.Yellow; // Varsayılan renk
            BackColor = Color.DarkBlue; // Varsayılan arka plan rengi
            lblDurum.Text = ""; // Sonuç metnini temizle

            cmbSecim.Enabled = true; // ComboBox tekrar aktif edilir
            btnOyna.Enabled = true; // Oyna butonu tekrar aktif edilir
            btnTekrar.Enabled = false; // Tekrar butonu pasif hale getirilir
        }
    }
}