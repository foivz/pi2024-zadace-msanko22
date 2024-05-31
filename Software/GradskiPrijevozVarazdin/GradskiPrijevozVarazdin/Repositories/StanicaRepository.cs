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
            string zaposlenik = reader["Zaposlenik"].ToString();

            var stanica = new Stanica
            {
                BrStanice = brstanice,
                NazivAdresaStanice = nazivadresastanice,
                Opis = opis,
                BrPeronaNaStanici = brperonanastanici,
                Linija = linija,
                Kapacitet = kapacitet,
                Zaposlenik = zaposlenik
            };
            return stanica;
        }

        public static void Brisi(int brstanice)
        {
            string sql = $"DELETE FROM Stanica WHERE BrStanice = {brstanice}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Stanica> Pretrazi(string searchText)
        {
            List<Stanica> stanice = new List<Stanica>();
            string sql = $"SELECT * FROM Stanica WHERE Linija LIKE '%{searchText}%' OR Kapacitet LIKE '%{searchText}%'";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Stanica stanica = new Stanica
                {
                    BrStanice = int.Parse(reader["BrStanice"].ToString()),
                    NazivAdresaStanice = reader["Adresa"].ToString(),
                    Opis = reader["Opis"].ToString(),
                    BrPeronaNaStanici = int.Parse(reader["BrPerona"].ToString()),
                    Linija = reader["Linija"].ToString(),
                    Kapacitet = int.Parse(reader["Kapacitet"].ToString()),
                    Zaposlenik = reader["Zaposlenik"].ToString()
                };
                stanice.Add(stanica);
            }
            reader.Close();
            DB.CloseConnection();
            return stanice;
        }
        public static void Dodaj(string adresa, string opis, string brperona, string linija, string kapacitet, string zaposlenik)
        {
            string sql = $"INSERT INTO Stanica(Adresa,Opis,BrPerona,Linija,Kapacitet,Zaposlenik) VALUES('{adresa}','{opis}','{brperona}','{linija}','{kapacitet}','{zaposlenik}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void Izmjena(string adresa, string opis, string brperona, string linija, string kapacitet, string zaposlenik, int brstanice)
        {
            string sql = $"UPDATE Stanica SET Adresa = '{adresa}', Opis = '{opis}', BrPerona = '{brperona}', Linija = '{linija}', Kapacitet = '{kapacitet}', Zaposlenik = '{zaposlenik}' WHERE BrStanice = '{brstanice}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
