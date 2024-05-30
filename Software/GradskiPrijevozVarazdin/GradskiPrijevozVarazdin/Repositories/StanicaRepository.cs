using DBLayer;
using GradskiPrijevozVarazdin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradskiPrijevozVarazdin.Repositories
{
    internal class StanicaRepository
    {
        public static List<Stanica> GetStanice()
        {
            List<Stanica> stanice = new List<Stanica>();
            string sql = "SELECT * FROM Stanica";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Stanica stanica = CreateObject(reader);
                stanice.Add(stanica);
            }
            reader.Close();
            DB.CloseConnection();
            return stanice;
        }
        private static Stanica CreateObject(SqlDataReader reader)
        {
            int brstanice = int.Parse(reader["BrStanice"].ToString());
            string nazivadresastanice = reader["Adresa"].ToString();
            string opis = reader["Opis"].ToString();
            int brperonanastanici = int.Parse(reader["BrPerona"].ToString());
            string linija = reader["Linija"].ToString();
            int kapacitet = int.Parse(reader["Kapacitet"].ToString());

            var stanica = new Stanica
            {
                BrStanice = brstanice,
                NazivAdresaStanice = nazivadresastanice,
                Opis = opis,
                BrPeronaNaStanici = brperonanastanici,
                Linija = linija,
                Kapacitet = kapacitet
            };
            return stanica;
        }
    }
}
