using DBLayer;
using DSUGP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSUGP.Repozitoriji
{
    internal class AutobusneStanice
    {
        public static AutobusnaStanica GetAutobusnaStanica(int Id_stanice)
        {
            AutobusnaStanica autobusnaStanica = null;
            string sql = $"SELECT * FROM AutobusneStanice WHERE Id_stanice = {Id_stanice}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                autobusnaStanica = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return autobusnaStanica;
        }
        public static AutobusnaStanica GetNazivStanica(int Id_stanice)
        {
            AutobusnaStanica autobusnaStanica = null;
            string sql = $"SELECT Naziv_stanica FROM AutobusneStanice WHERE Id_stanice = {Id_stanice}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                autobusnaStanica = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return autobusnaStanica;
        }
        public static AutobusnaStanica CreateObject(SqlDataReader reader)
        {
            int Id_stanice = int.Parse(reader["Id_stanice"].ToString());
            string Naziv_stanice = reader["Naziv_stanice"].ToString();
            string Broj_stanice = reader["Broj_stanice"].ToString();

            var autobusnaStanica = new AutobusnaStanica
            {
                Id_stanice = Id_stanice,
                Naziv_stanice = Naziv_stanice,
                Broj_stanice = Broj_stanice,
            };
            return autobusnaStanica;
        }
        public static List<AutobusnaStanica> GetAutobusneStanice()
        {
            List<AutobusnaStanica> autobusneStanice = new List<AutobusnaStanica>();

            string sql = "SELECT * FROM AutobusneStanice";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                AutobusnaStanica autobusnaStanica = CreateObject(reader);
                autobusneStanice.Add(autobusnaStanica);
            }

            reader.Close();
            DB.CloseConnection();

            return autobusneStanice;
        }
        public static bool ProvjeriAutobusnuStanicu(string Naziv_stanice)
        {
            string sql = $"SELECT COUNT(*) FROM AutobusneStanice WHERE Naziv_stanice = '{Naziv_stanice}'";

            DB.OpenConnection();
            int count = (int)DB.GetScalar(sql);
            DB.CloseConnection();

            return count > 0;
        }
        public static bool DodajAutobusnuStanicu(AutobusnaStanica noviAutobusnaStanica)
        {
            try
            {
                string checkIfExistsQuery = $"SELECT COUNT(*) FROM AutobusneStanice WHERE Naziv_stanice = '{noviAutobusnaStanica.Naziv_stanice}'";
                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();

                int autobusnaStanicaCount = (int)DB.GetScalar(checkIfExistsQuery);

                if (autobusnaStanicaCount > 0)
                {
                    MessageBox.Show("Autobusna stanica s tim nazivom već postoji u bazi podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.CloseConnection();
                    return false;
                }

                string insertQuery = $"INSERT INTO AutobusneStanice (Naziv_stanice, Broj_stanice) " +
                                     $"VALUES ('{noviAutobusnaStanica.Naziv_stanice}', '{noviAutobusnaStanica.Broj_stanice}')";

                DB.ExecuteCommand(insertQuery);
                DB.CloseConnection();

                MessageBox.Show("Podaci su uspješno dodani u bazu podataka.", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom komunikacije s bazom podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static bool IzbrisiAutobusnuStanicu(int Id_stanice)
        {
            try
            {
                string deleteQuery = $"DELETE FROM AutobusneStanice WHERE Id_stanice = {Id_stanice}";

                DB.OpenConnection();
                DB.ExecuteCommand(deleteQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom brisanja autobusne stanice: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static AutobusnaStanica PretraziAutobusneStanice(string Naziv_stanice)
        {
            AutobusnaStanica autobusneStanice = null;
            string sql = $"SELECT * FROM  AutobusneStanice WHERE Naziv_stanice = '{Naziv_stanice}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                autobusneStanice = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return autobusneStanice;
        }
        public static bool AzurirajAutobusnuStanicu(AutobusnaStanica updatedStanica)
        {
            try
            {
                string updateQuery = $"UPDATE AutobusneStanice SET Naziv_stanice = '{updatedStanica.Naziv_stanice}', " +
                                     $"Broj_stanice = '{updatedStanica.Broj_stanice}' " +
                                     $"WHERE Id_stanice = {updatedStanica.Id_stanice}";

                DB.OpenConnection();
                DB.ExecuteCommand(updateQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom ažuriranja autobusne stanice: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
    }
}