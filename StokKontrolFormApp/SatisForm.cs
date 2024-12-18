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
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True");
        private void satisEkle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Satis (satisId ,satisFiyat , satisMiktar , satisTarih , calisanId,seriId) values (@satisid ,@satisfiyat , @satismiktar , @satistarih , @calisanid, @seriid)", baglanti);
            komut.Parameters.AddWithValue("@satisid", satisKod_txt.Text);
            komut.Parameters.AddWithValue("@satisfiyat", satisFiyat_txt.Text);
            komut.Parameters.AddWithValue("@satismiktar", satisMiktar_txt.Text);
            komut.Parameters.AddWithValue("@satistarih", satisTarih_picker.Value);
            komut.Parameters.AddWithValue("@calisanid", satisCalisan_combo.Text);
            komut.Parameters.AddWithValue("@seriid", satisSeriNo_combo.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from Satis ");
            MessageBox.Show("Eklendi");
            baglanti.Close();

        }

        private void satisSil_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Satis where satisId = @satisid", baglanti);
            komut.Parameters.AddWithValue("@satisid", satisKod_txt.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from Satis ");
            MessageBox.Show("Silindi");
            baglanti.Close();

        }

        private void satisGuncelle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Satis set satisId=@satisid, satisFiyat=@satisfiyat, satisMiktar=@satismiktar , calisanId=@calisanid , seriId=@seriid  where satisId=@satisid", baglanti);
            komut.Parameters.AddWithValue("@satisid", satisKod_txt.Text);
            komut.Parameters.AddWithValue("@satisfiyat", satisFiyat_txt.Text);
            komut.Parameters.AddWithValue("@satismiktar", satisMiktar_txt.Text);
            komut.Parameters.AddWithValue("@satistarih", satisTarih_picker.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@calisanid", satisCalisan_combo.Text);
            komut.Parameters.AddWithValue("@seriid", satisSeriNo_combo.Text);
            komut.ExecuteNonQuery();
            verilerigöster(" Select * from Satis ");
            MessageBox.Show("Güncellendi");
            baglanti.Close();

        }

        private void satisAra_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string srg = satisKod_txt.Text;
            string sorgu = "Select * from Satis where satisId Like " + srg;


            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Satis");
            satisDataGrid.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Satis", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            satisDataGrid.DataSource = ds.Tables[0];
        }
    }
}
