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

            SqlCommand command = new SqlCommand("SELECT urunId, urunAd, urunStok, departmanAd, seriId FROM Urun LEFT JOIN Departman ON Urun.departmanId = Departman.departmanId", connection);

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
                    urunListe.Add(urun);
                }
            }
            connection.Close();
            return urunListe;
        }

    }
}
