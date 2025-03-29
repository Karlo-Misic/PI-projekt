using DBLayer;
using DSUGP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSUGP.Repozitoriji
{
    internal class VozneLinije
    {
        public static VoznaLinija GetVoznaLinija(int Id_linija)
        {
            VoznaLinija voznaLinija = null;
            string sql = $"SELECT * FROM VozneLinije WHERE Id_linija = {Id_linija}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznaLinija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return voznaLinija;
        }
        public static VoznaLinija CreateObject(SqlDataReader reader)
        {
            int Id_linija = int.Parse(reader["Id_linija"].ToString());
            string Naziv_linije = reader["Naziv_linije"].ToString();
            string Prva_stanica = reader["Prva_stanica"].ToString();
            string Zadnja_stanica = reader["Zadnja_stanica"].ToString();
            string Vrijeme_pocetka = reader["Vrijeme_pocetka"].ToString();
            string Vrijeme_zavrsetka = reader["Vrijeme_zavrsetka"].ToString();

            var voznaLinija = new VoznaLinija
            {
                Id_linija = Id_linija,
                Naziv_linije = Naziv_linije,
                Prva_stanica = Prva_stanica,
                Zadnja_stanica = Zadnja_stanica,
                Vrijeme_pocetka = Vrijeme_pocetka,
                Vrijeme_zavrsetka = Vrijeme_zavrsetka,
            };
            return voznaLinija;
        }
        public static List<VoznaLinija> GetVozneLinije()
        {
            List<VoznaLinija> vozneLinije = new List<VoznaLinija>();

            string sql = "SELECT * FROM VozneLinije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                VoznaLinija vozneLinije1 = CreateObject(reader);
                vozneLinije.Add(vozneLinije1);
            }

            reader.Close();
            DB.CloseConnection();

            return vozneLinije;
        }
        public static bool ProvjeriVoznuLiniju(string Naziv_Linije)
        {
            // Upit u bazi podataka za provjeru postoji li vozna linija s odgovarajućim nazivom linije
            string sql = $"SELECT COUNT(*) FROM VozneLinije WHERE Naziv_linije = '{Naziv_Linije}'";

            DB.OpenConnection();
            int count = (int)DB.GetScalar(sql);
            DB.CloseConnection();

            // Ako postoji vozna linija s odgovarajućim nazivom, vrati true; inače vrati false
            return count > 0;
        }
        public static bool DodajVoznuLiniju(VoznaLinija novaVoznaLinija)
        {
            try
            {
                // Provjera postojanja vozne linije s istim nazivom
                string checkIfExistsQuery = $"SELECT COUNT(*) FROM VozneLinije WHERE Naziv_linije = '{novaVoznaLinija.Naziv_linije}'";
                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();

                int voznaLinijaCount = (int)DB.GetScalar(checkIfExistsQuery);

                if (voznaLinijaCount > 0)
                {
                    MessageBox.Show("Vozna linija s tim nazivom već postoji u bazi podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.CloseConnection();
                    return false;
                }

                // Dodavanje nove vozne linije ako ne postoji vozna linija s istim nazivom
                string insertQuery = $"INSERT INTO VozneLinije (Naziv_linije, Prva_stanica, Zadnja_stanica, Vrijeme_pocetka, Vrijeme_zavrsetka) " +
                                     $"VALUES ('{novaVoznaLinija.Naziv_linije}', '{novaVoznaLinija.Prva_stanica}', '{novaVoznaLinija.Zadnja_stanica}', '{novaVoznaLinija.Vrijeme_pocetka}', '{novaVoznaLinija.Vrijeme_zavrsetka}')";

                DB.ExecuteCommand(insertQuery);
                DB.CloseConnection();

                //MessageBox.Show("Podaci su uspješno dodani u bazu podataka.", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom komunikacije s bazom podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static bool IzbrisiVoznuLiniju(int Id_linija)
        {
            try
            {
                string deleteQuery = $"DELETE FROM VozneLinije WHERE Id_linija = {Id_linija}";

                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();
                DB.ExecuteCommand(deleteQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom brisanja vozne linije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static VoznaLinija PretraziVoznuLiniju(string Naziv_linije)
        {
            VoznaLinija voznaLinija = null;
            string sql = $"SELECT * FROM  VozneLinije WHERE Naziv_linije = '{Naziv_linije}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznaLinija = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return voznaLinija;
        }
        public static bool AzurirajVoznuLiniju(VoznaLinija updatedLinija)
        {
            try
            {
                string updateQuery = $"UPDATE VozneLinije SET Naziv_linije = '{updatedLinija.Naziv_linije}', " +
                                    $"Prva_stanica = '{updatedLinija.Prva_stanica}', " +
                                    $"Zadnja_stanica = '{updatedLinija.Zadnja_stanica}', " +
                                    $"Vrijeme_pocetka = '{updatedLinija.Vrijeme_pocetka}', " +
                                    $"Vrijeme_zavrsetka = '{updatedLinija.Vrijeme_zavrsetka}' " +
                                    $"WHERE Id_linija = {updatedLinija.Id_linija}";

                DB.OpenConnection();
                DB.ExecuteCommand(updateQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom ažuriranja vozne linije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
    }
}