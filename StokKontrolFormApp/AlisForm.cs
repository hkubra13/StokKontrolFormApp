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

namespace StokKontrolFormApp
{
    public partial class AlisForm : Form
    {
        public AlisForm()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True";

        private void alisEkle_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Alis (alisId, alisFiyat, alisMiktar, alisTarih, urunId, tedarikId) " +
                               "VALUES (@Id, @Fiyat, @Miktar, @Tarih, @Urun, @Tedarikci)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", alisKod_txt.Text);
                    cmd.Parameters.AddWithValue("@Fiyat", alisFiyat_txt.Text);
                    cmd.Parameters.AddWithValue("@Miktar", alisMiktar_txt.Text);
                    cmd.Parameters.AddWithValue("@Tarih", alisTarih_picker.Value);
                    cmd.Parameters.AddWithValue("@Urun", alisUrun_combo.Text);
                    cmd.Parameters.AddWithValue("@Tedarikci", alisTedarikci_combo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi.");
                    Temizle();
                    verilerigöster("Select * from Alis");
                }
            }

        }

        private void alisGuncelle_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Alis SET alisFiyat = @Fiyat, alisMiktar = @Miktar, " +
                               "alisTarih = @Tarih, urunId = @Urun, tedarikId = @Tedarikci WHERE alisId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", alisKod_txt.Text);
                    cmd.Parameters.AddWithValue("@Fiyat", alisFiyat_txt.Text);
                    cmd.Parameters.AddWithValue("@Miktar", alisMiktar_txt.Text);
                    cmd.Parameters.AddWithValue("@Tarih", alisTarih_picker.Value);
                    cmd.Parameters.AddWithValue("@Urun", alisUrun_combo.Text);
                    cmd.Parameters.AddWithValue("@Tedarikci", alisTedarikci_combo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla güncellendi.");
                    verilerigöster("Select * from Alis");
                    Temizle();
                }
            }

        }

        private void alisSil_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Alis WHERE alisId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", alisKod_txt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla silindi.");
                    Temizle();
                    verilerigöster("Select * from Alis");
                }
            }

        }

        private void alisAra_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Alis WHERE alisId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", alisKod_txt.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        alisFiyat_txt.Text = reader["alisFiyat"].ToString();
                        alisMiktar_txt.Text = reader["alisMiktar"].ToString();
                        alisTarih_picker.Value = Convert.ToDateTime(reader["alisTarih"]);
                        alisUrun_combo.Text = reader["urunId"].ToString();
                        alisTedarikci_combo.Text = reader["tedarikId"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt bulunamadı.");
                    }
                }
            }

        }

        private void Temizle()
        {
            alisKod_txt.Clear();
            alisFiyat_txt.Clear();
            alisMiktar_txt.Clear();
            alisUrun_combo.SelectedIndex = -1;
            alisTedarikci_combo.SelectedIndex = -1;
            alisTarih_picker.Value = DateTime.Now;
        }

        private void AlisForm_Load(object sender, EventArgs e)
        {
            verilerigöster("Select * from Alis");
        }
        public void verilerigöster(string veriler)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            alisDataGrid.DataSource = ds.Tables[0];
        }
    }
}
