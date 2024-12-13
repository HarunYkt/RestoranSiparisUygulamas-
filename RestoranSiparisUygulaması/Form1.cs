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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("E-posta ve Şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = DAL.DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Kullanici WHERE Eposta = @Eposta AND Sifre = @Sifre";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Eposta", eposta);
                    command.Parameters.AddWithValue("@Sifre", sifre);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string rol = reader["Rol"].ToString();
                        MessageBox.Show($"Giriş başarılı! Rolünüz: {rol}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rol bazında yönlendirme
                        if (rol == "Müşteri")
                        {
                            MusteriForm musteriForm = new MusteriForm();
                            this.Hide(); // Form1'i gizler
                            musteriForm.ShowDialog(); // Müşteri formunu modal olarak açar
                            this.Show(); // Geri dönüldüğünde Form1'i tekrar gösterir
                        }
                        else
                        {
                            MessageBox.Show("Bu kullanıcı için müşteri ekranı yok!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-posta veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form2 kayitForm = new Form2();
            kayitForm.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
