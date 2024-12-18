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
    public partial class DepartmanForm : Form
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True";
        public DepartmanForm()
        {
            InitializeComponent();
        }

        private void DepartmanForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Departman", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            departmanDataGrid.DataSource = dt;
            baglanti.Close();

        }

        private void departmanEkle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into departman(departmanId, departmanAd)values (@departmanid,@departmanad)", baglanti);
            komut.Parameters.AddWithValue("@departmanid", departmanKod_txt.Text);
            komut.Parameters.AddWithValue("@departmanad", departmanAd_txt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void yenile_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Departman", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            departmanDataGrid.DataSource = dt;
            baglanti.Close();

        }

        private void departmanSil_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Departman WHERE departmanId = @departmanid", baglanti);
            komut.Parameters.AddWithValue("@departmanid", departmanKod_txt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void departmanGuncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Departman SET departmanAd = @departmanad WHERE departmanId = @departmanid", baglanti);
            komut.Parameters.AddWithValue("@departmanid", departmanKod_txt.Text);
            komut.Parameters.AddWithValue("@departmanad", departmanAd_txt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void departmanAra_btn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Departman WHERE departmanAd LIKE @departmanad", baglanti);
            string yazi = "%" + departmanAd_txt.Text + "%";
            komut.Parameters.AddWithValue("@departmanad", yazi);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            departmanDataGrid.DataSource = dt;
            baglanti.Close();

        }
    }
}
