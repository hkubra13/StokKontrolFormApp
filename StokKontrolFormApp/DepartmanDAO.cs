using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrolFormApp
{
    public class DepartmanDAO
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=StokKontrolDB;User ID=sa;Password=123456;Integrated Security=True; TrustServerCertificate=True";

        public List<Departman> TumDepartmanlar()
        {
            List<Departman> departmanListe = new List<Departman>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT departmanId, departmanAd FROM Departman", connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Departman departman = new Departman();

                    departman.departmanId = reader.GetInt32(0);
                    departman.departmanAd = !reader.IsDBNull(1) ? reader.GetString(1) : "Bilinmiyor";
                    departmanListe.Add(departman);
                }
            }
            connection.Close();
            return departmanListe;
        }
    }
}
