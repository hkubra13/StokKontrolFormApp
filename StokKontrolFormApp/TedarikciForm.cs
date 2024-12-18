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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            tedarikciDataGrid.DataSource = ds.Tables[0];
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True");

        private void tedarikciEkle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            using (SqlCommand komut = new SqlCommand("INSERT INTO Tedarikci (tedarikId, tedarikAd, tedarikTel) VALUES (@tedarikId, @tedarikAd, @tedarikTel)", baglanti))
            {
                komut.Parameters.AddWithValue("@tedarikId", tedarikciKod_txt.Text);
                komut.Parameters.AddWithValue("@tedarikAd", tedarikciAd_txt.Text);
                komut.Parameters.AddWithValue("@tedarikTel", tedarikciTel_txt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigöster("Select * from Tedarikci");
            }

        }

        private void tedarikciSil_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tedarikci where tedarikId=@tedarikId", baglanti);
            komut.Parameters.AddWithValue("@tedarikId", tedarikciKod_txt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Tedarikci silindi");
            verilerigöster("Select * from Tedarikci");
            baglanti.Close();

        }

        private void tedarikciGuncelle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tedarikci set   tedarikAd=@tedarikAd , tedarikTel=@tedarikTel where tedarikId=@tedarikId", baglanti);

            komut.Parameters.AddWithValue("@tedarikId", tedarikciKod_txt.Text);
            komut.Parameters.AddWithValue("@tedarikAd", tedarikciAd_txt.Text);
            komut.Parameters.AddWithValue("@tedarikTel", tedarikciTel_txt.Text);


            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster("Select* from Tedarikci");
            MessageBox.Show("Güncellendi.");

        }

        private void tedarikciAra_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string yazi = tedarikciAd_txt.Text;
            string sorgu = "Select * from Tedarikci where tedarikAd Like '" + yazi + "'";


            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "tedarikci");
            tedarikciDataGrid.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            verilerigöster("Select * from Tedarikci");

        }

        private void tedarikciDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tedarikciKod_txt.Text = tedarikciDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tedarikciAd_txt.Text = tedarikciDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            tedarikciTel_txt.Text = tedarikciDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
