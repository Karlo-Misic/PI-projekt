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
    internal class Zaposlenici
    {
        public static Zaposlenik GetZaposlenik(int Id_zaposlenik)
        {
            Zaposlenik zaposlenik = null;
            string sql = $"SELECT * FROM Zaposlenici WHERE Id_zaposlenik = {Id_zaposlenik}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }
        public static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int Id_zaposlenik = int.Parse(reader["Id_zaposlenik"].ToString());
            string KorIme = reader["KorIme"].ToString();
            string Lozinka = reader["Lozinka"].ToString();
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id_zaposlenik = Id_zaposlenik,
                KorIme = KorIme,
                Lozinka = Lozinka,
                Ime = Ime,
                Prezime = Prezime,
            };
            return zaposlenik;
        }
        public static List<Zaposlenik> GetZaposlenik()
        {
            List<Zaposlenik> zaposlenik = new List<Zaposlenik>();

            string sql = "SELECT * FROM Zaposlenici";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zaposlenik zaposlenik1 = CreateObject(reader);
                zaposlenik.Add(zaposlenik1);
            }

            reader.Close();
            DB.CloseConnection();

            return zaposlenik;
        }
        public static bool ProvjeriKorisnika(string korisnickoIme, string lozinka)
        {
            // Upit u bazi podataka za provjeru postoji li korisnik s odgovarajućim korisničkim imenom i lozinkom
            string sql = $"SELECT COUNT(*) FROM Zaposlenici WHERE KorIme = '{korisnickoIme}' AND Lozinka = '{lozinka}'";

            DB.OpenConnection();
            int count = (int)DB.GetScalar(sql);
            DB.CloseConnection();

            // Ako postoji korisnik s odgovarajućim korisničkim imenom i lozinkom, vrati true; inače vrati false
            return count > 0;
        }
        public static bool DodajZaposlenika(Zaposlenik noviZaposlenik)
        {
            try
            {
                // Provjera postojanja korisničkog imena
                string checkIfExistsQuery = $"SELECT COUNT(*) FROM Zaposlenici WHERE KorIme = '{noviZaposlenik.KorIme}'";
                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();

                int userCount = (int)DB.GetScalar(checkIfExistsQuery);

                if (userCount > 0)
                {
                    // Korisničko ime već postoji, provjeri ostale podatke i ažuriraj ili prikaži poruku
                    string selectQuery = $"SELECT * FROM Zaposlenici WHERE KorIme = '{noviZaposlenik.KorIme}'";
                    var reader = DB.GetDataReader(selectQuery);

                    if (reader.HasRows)
                    {
                        reader.Read();
                        Zaposlenik existingZaposlenik = CreateObject(reader);
                        reader.Close();

                        // Provjera promjene ostalih podataka
                        if (existingZaposlenik.Ime == noviZaposlenik.Ime &&
                            existingZaposlenik.Prezime == noviZaposlenik.Prezime &&
                            existingZaposlenik.Lozinka == noviZaposlenik.Lozinka)
                        {
                            MessageBox.Show("Zaposlenik s tim korisničkim imenom već postoji u bazi podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DB.CloseConnection();
                            return false;
                        }
                        else
                        {
                            // Izvrši ažuriranje podataka
                            string updateQuery = $"UPDATE Zaposlenici SET Ime = '{noviZaposlenik.Ime}', " +
                                                 $"Prezime = '{noviZaposlenik.Prezime}', " +
                                                 $"Lozinka = '{noviZaposlenik.Lozinka}' " +
                                                 $"WHERE KorIme = '{noviZaposlenik.KorIme}'";

                            DB.ExecuteCommand(updateQuery);
                            DB.CloseConnection();
                            return true;
                        }
                    }
                }

                // Dodavanje novog zapisa ako korisničko ime ne postoji
                string insertQuery = $"INSERT INTO Zaposlenici (KorIme, Lozinka, Ime, Prezime) " +
                                     $"VALUES ('{noviZaposlenik.KorIme}', '{noviZaposlenik.Lozinka}', '{noviZaposlenik.Ime}', '{noviZaposlenik.Prezime}')";

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
        public static bool IzbrisiZaposlenika(int Id_zaposlenik)
        {
            try
            {
                string deleteQuery = $"DELETE FROM Zaposlenici WHERE Id_zaposlenik = {Id_zaposlenik}";

                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();
                DB.ExecuteCommand(deleteQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom brisanja zaposlenika: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static Zaposlenik PretraziZaposlenika(string korisnickoIme)
        {
            Zaposlenik zaposlenik = null;
            string sql = $"SELECT * FROM Zaposlenici WHERE KorIme = '{korisnickoIme}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return zaposlenik;
        }
    }
}