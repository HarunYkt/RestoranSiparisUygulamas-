using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = DAL.DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Kullanici (Ad, Soyad, Eposta, Sifre, Telefon, Rol) VALUES (@Ad, @Soyad, @Eposta, @Sifre, @Telefon, @Rol)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Eposta", eposta);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Rol", "Müşteri"); // Varsayılan olarak müşteri rolü

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
