using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrolFormApp
{
    public class UrunDAO
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True";

        public List<Urun> TumUrunler()
        {
            List<Urun> urunListe = new List<Urun>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT urunId, urunAd, urunStok, departmanAd, seriId, Departman.departmanId FROM Urun LEFT JOIN Departman ON Urun.departmanId = Departman.departmanId", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Urun urun = new Urun();

                    urun.urunId = reader.GetInt32(0);
                    urun.urunAd = !reader.IsDBNull(1) ? reader.GetString(1) : "Bilinmiyor";
                    urun.urunStok = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
                    urun.departmanAd = !reader.IsDBNull(3) ? reader.GetString(3) : "Bilinmiyor";
                    urun.seriId = !reader.IsDBNull(4) ? reader.GetString(4) : "Bilinmiyor";
                    urun.departmanId = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0;
                    urunListe.Add(urun);
                }
            }
            connection.Close();
            return urunListe;
        }

        public List<Urun> UrunArama(string aramaTerimi)
        {
            List<Urun> urunListe = new List<Urun>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string urunAramaTerimi = "%" + aramaTerimi + "%";

            SqlCommand command = new SqlCommand("SELECT urunId, urunAd, urunStok, departmanAd, seriId, Departman.departmanId FROM Urun LEFT JOIN Departman ON Urun.departmanId = Departman.departmanId WHERE urunAd LIKE @urunAd", connection);
            command.Parameters.AddWithValue("@urunAd", urunAramaTerimi);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Urun urun = new Urun();

                    urun.urunId = reader.GetInt32(0);
                    urun.urunAd = !reader.IsDBNull(1) ? reader.GetString(1) : "Bilinmiyor";
                    urun.urunStok = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
                    urun.departmanAd = !reader.IsDBNull(3) ? reader.GetString(3) : "Bilinmiyor";
                    urun.seriId = !reader.IsDBNull(4) ? reader.GetString(4) : "Bilinmiyor";
                    urun.departmanId = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0;
                    urunListe.Add(urun);
                }
            }
            connection.Close();
            return urunListe;
        }

        public int UrunEkle(Urun urun)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Urun (urunId, urunAd, departmanId, seriId, urunStok) VALUES (@urunId, @urunAd, @departmanId, @seriId, @urunStok)", connection);
            command.Parameters.AddWithValue("@urunId", urun.urunId);
            command.Parameters.AddWithValue("@urunAd", urun.urunAd);
            command.Parameters.AddWithValue("@departmanId", urun.departmanId);
            command.Parameters.AddWithValue("@seriId", urun.seriId);
            command.Parameters.AddWithValue("@urunStok", urun.urunStok);
            int yeniUrun = command.ExecuteNonQuery();

            connection.Close();
            return yeniUrun;
        }

        public int UrunGuncelle (Urun urun)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Urun SET urunAd = @urunAd, departmanId = @departmanId, seriId = @seriId, urunStok = @urunStok WHERE urunId = @urunId", connection);
            command.Parameters.AddWithValue("@urunId", urun.urunId);
            command.Parameters.AddWithValue("@urunAd", urun.urunAd);
            command.Parameters.AddWithValue("@departmanId", urun.departmanId);
            command.Parameters.AddWithValue("@seriId", urun.seriId);
            command.Parameters.AddWithValue("@urunStok", urun.urunStok);
            int guncelUrun = command.ExecuteNonQuery();

            connection.Close();
            return guncelUrun;
        }

        public int UrunSil (int urunId)
        {
            SqlConnection connection = new SqlConnection (connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Urun WHERE urunId = @urunId", connection);
            command.Parameters.AddWithValue("@urunId", urunId);
            int sonuc = command.ExecuteNonQuery();

            connection.Close();
            return sonuc;
        }
    }
}
