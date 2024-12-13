using MySql.Data.MySqlClient;
using RestoranSiparisUygulaması.DAL;
using System;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        // Sipariş Ver Butonu
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği ürün adı ve adet bilgilerini alıyoruz.
            if (listViewMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string urunAdi = listViewMenu.SelectedItems[0].Text; // Seçilen ürün adı
            if (!int.TryParse(txtAdet.Text.Trim(), out int adet) || adet <= 0)
            {
                MessageBox.Show("Geçerli bir adet girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Örnek müşteri ID'si (giriş yapan kullanıcının ID'si olmalı)
            int musteriID = 1; // Test için sabit bir müşteri ID'si
            decimal urunFiyati = 25.00m; // Sabit fiyat (örneğin her ürün 25 TL)
            decimal toplamTutar = adet * urunFiyati;

            // Sipariş detaylarını veritabanına kaydetmek için
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Siparis (MusteriID, UrunAdi, Adet, SiparisDurumu, ToplamTutar) " +
                                   "VALUES (@MusteriID, @UrunAdi, @Adet, @SiparisDurumu, @ToplamTutar)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Parametreler
                    command.Parameters.AddWithValue("@MusteriID", musteriID);
                    command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    command.Parameters.AddWithValue("@Adet", adet);
                    command.Parameters.AddWithValue("@SiparisDurumu", "Hazırlanıyor");
                    command.Parameters.AddWithValue("@ToplamTutar", toplamTutar);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Sipariş başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // Form Yüklendiğinde Menü Ürünlerini Gösterme
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Menu"; // Menü tablosundan ürünler çekiliyor
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // ListView'e ürün ekleniyor
                        ListViewItem item = new ListViewItem(reader["UrunAdi"].ToString());
                        item.SubItems.Add(reader["Fiyat"].ToString());
                        listViewMenu.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
