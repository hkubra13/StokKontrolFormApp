using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokKontrolFormApp
{
    public partial class CalisanForm : Form
    {
        string conDB = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True";
        public CalisanForm()
        {
            InitializeComponent();
        }

        private void verileriGöster(string veriler)
        {
            using (SqlConnection baglanti = new SqlConnection(conDB))
            {
                SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                calisanDataGrid.DataSource = ds.Tables[0];
            }
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(conDB))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM Calisan", baglanti);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    calisanDataGrid.DataSource = dt;
                    verileriGöster("SELECT * FROM Calisan");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void calisanEkle_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(calisanKod_txt.Text) || string.IsNullOrWhiteSpace(calisanAd_txt.Text) ||
                string.IsNullOrWhiteSpace(calisanSoyad_txt.Text) || string.IsNullOrWhiteSpace(departmanCalisan_combo.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection baglanti = new SqlConnection(conDB);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Calisan (calisanId,calisanAd,calisanSoyad,departmanId) values( @calisanId,@calisanAd, @calisanSoyad, @departmanId)", baglanti);
                komut.Parameters.AddWithValue("@calisanId", calisanKod_txt.Text);
                komut.Parameters.AddWithValue("@calisanAd", calisanAd_txt.Text);
                komut.Parameters.AddWithValue("@calisanSoyad", calisanSoyad_txt.Text);
                komut.Parameters.AddWithValue("@departmanId", departmanCalisan_combo.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla eklendi");
                verileriGöster("SELECT * FROM Calisan");

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void calisanSil_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conDB);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Calisan WHERE calisanId = @calisanId", baglanti);
                komut.Parameters.AddWithValue("@calisanId", calisanKod_txt.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla silindi.");
                verileriGöster("SELECT * FROM Calisan");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void calisanGuncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conDB);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Calisan SET calisanAd = @calisanAd, calisanSoyad = @calisanSoyad, departmanId = @departmanId WHERE calisanId = @calisanId", baglanti);

                komut.Parameters.AddWithValue("@calisanId", calisanKod_txt.Text);
                komut.Parameters.AddWithValue("@calisanAd", calisanAd_txt.Text);
                komut.Parameters.AddWithValue("@calisanSoyad", calisanSoyad_txt.Text);
                komut.Parameters.AddWithValue("@departmanId", departmanCalisan_combo.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla güncellendi.");
                verileriGöster("SELECT * FROM Calisan");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void calisanAra_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conDB);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Calisan WHERE calisanAd LIKE @calisanAd", baglanti);
                komut.Parameters.AddWithValue("@calisanAd", "%" + calisanAd_txt.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                calisanDataGrid.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void calisanDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = calisanDataGrid.Rows[e.RowIndex];

                calisanKod_txt.Text = row.Cells[0].Value.ToString();
                calisanAd_txt.Text = row.Cells[1].Value.ToString();
                calisanSoyad_txt.Text = row.Cells[2].Value.ToString();
                departmanCalisan_combo.Text = row.Cells[3].Value.ToString();
            }

        }
    }
}
