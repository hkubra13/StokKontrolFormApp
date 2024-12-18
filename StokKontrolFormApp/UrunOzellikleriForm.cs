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
    public partial class UrunOzellikleriForm : Form
    {
        public UrunOzellikleriForm()
        {
            InitializeComponent();
        }
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            urunOzellikleriDataGrid.DataSource = ds.Tables[0];
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True");

        private void urunOzellikleriEkle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            using (SqlCommand komut = new SqlCommand("INSERT INTO UrunOzellikleri (seriId, renk, beden, cinsiyet,marka,tur) VALUES (@seriId, @renk, @beden, @cinsiyet,@marka,@tur)", baglanti))
            {
                komut.Parameters.AddWithValue("@seriId", urunOzellikleriKod_txt.Text);
                komut.Parameters.AddWithValue("@renk", urunOzellikleriRenk_txt.Text);
                komut.Parameters.AddWithValue("@beden", urunOzellikleriBeden_txt.Text);
                komut.Parameters.AddWithValue("@cinsiyet", urunOzellikleriCinsiyet_txt.Text);
                komut.Parameters.AddWithValue("@marka", urunOzellikleriMarka_txt.Text);
                komut.Parameters.AddWithValue("@tur", urunOzellikleriTur_txt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigöster("Select * from UrunOzellikleri");

            }
        }

        private void urunOzellikleriDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunOzellikleriKod_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            urunOzellikleriRenk_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            urunOzellikleriBeden_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            urunOzellikleriCinsiyet_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            urunOzellikleriMarka_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            urunOzellikleriTur_txt.Text = urunOzellikleriDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void urunOzellikleriSil_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from UrunOzellikleri where seriId=@seriId", baglanti);
            komut.Parameters.AddWithValue("seriId", urunOzellikleriKod_txt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün özellikleri silindi");
            verilerigöster("Select * from UrunOzellikleri");
            baglanti.Close();

        }

        private void urunOzellikleriGuncelle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update UrunOzellikleri set   renk=@renk , beden=@beden , cinsiyet=@cinsiyet , marka=@marka , tur=@tur where seriId=@seriId", baglanti);

            komut.Parameters.AddWithValue("@seriId", urunOzellikleriKod_txt.Text);
            komut.Parameters.AddWithValue("@renk", urunOzellikleriRenk_txt.Text);
            komut.Parameters.AddWithValue("@beden", urunOzellikleriBeden_txt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", urunOzellikleriCinsiyet_txt.Text);
            komut.Parameters.AddWithValue("@marka", urunOzellikleriMarka_txt.Text);
            komut.Parameters.AddWithValue("@tur", urunOzellikleriTur_txt.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster("Select* from UrunOzellikleri");
            MessageBox.Show("Güncellendi");

        }

        private void urunOzellikleriAra_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string yazi = urunOzellikleriKod_txt.Text;
            string sorgu = "Select * from UrunOzellikleri where seriId Like '" + yazi + "'";


            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "UrunOzellikleri");
            urunOzellikleriDataGrid.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void UrunOzellikleriForm_Load(object sender, EventArgs e)
        {
            verilerigöster("Select * from UrunOzellikleri");
        }
    }
}
