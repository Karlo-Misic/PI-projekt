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
    internal class VozniPark
    {
        public static vozniPark GetVozniPark(int Id_vozni_park)
        {
            vozniPark voznipark = null;
            string sql = $"SELECT * FROM VozniPark WHERE Id_vozni_park = {Id_vozni_park}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznipark = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return voznipark;
        }
        public static vozniPark CreateObject(SqlDataReader reader)
        {
            int Id_vozni_park = int.Parse(reader["Id_vozni_park"].ToString());
            string Naziv_vozila = reader["Naziv_vozila"].ToString();
            string Broj_tablice = reader["Broj_tablice"].ToString();
            string Broj_mjesta = reader["Broj_mjesta"].ToString();

            var voznipark = new vozniPark
            {
                Id_vozni_park = Id_vozni_park,
                Naziv_vozila = Naziv_vozila,
                Broj_tablice = Broj_tablice,
                Broj_mjesta = Broj_mjesta,
            };
            return voznipark;
        }
        public static List<vozniPark> GetVozniPark()
        {
            List<vozniPark> voznipark = new List<vozniPark>();

            string sql = "SELECT * FROM VozniPark";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                vozniPark voznipark1 = CreateObject(reader);
                voznipark.Add(voznipark1);
            }

            reader.Close();
            DB.CloseConnection();

            return voznipark;
        }
        public static bool ProvjeriVozniPark(string Broj_tablice)
        {
            string sql = $"SELECT COUNT(*) FROM VozniPark WHERE Broj_tablice = '{Broj_tablice}'";

            DB.OpenConnection();
            int count = (int)DB.GetScalar(sql);
            DB.CloseConnection();

            return count > 0;
        }
        public static bool DodajVozniPark(vozniPark novivozniPark)
        {
            try
            {
                string checkIfExistsQuery = $"SELECT COUNT(*) FROM VozniPark WHERE Broj_tablice = '{novivozniPark.Broj_tablice}'";
                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();

                int vozniParkCount = (int)DB.GetScalar(checkIfExistsQuery);

                if (vozniParkCount > 0)
                {
                    MessageBox.Show("Vozilo s tim brojem tablice već postoji u bazi podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.CloseConnection();
                    return false;
                }

                string insertQuery = $"INSERT INTO VozniPark (Naziv_vozila, Broj_tablice, Broj_mjesta) " +
                                     $"VALUES ('{novivozniPark.Naziv_vozila}', '{novivozniPark.Broj_tablice}', '{novivozniPark.Broj_mjesta}')";

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
        public static bool IzbrisiVozniPark(int Id_vozni_park)
        {
            try
            {
                string deleteQuery = $"DELETE FROM VozniPark WHERE Id_vozni_park = {Id_vozni_park}";

                DB.OpenConnection();
                DB.ExecuteCommand(deleteQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom brisanja vozila iz voznog parka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static vozniPark PretraziVozniPark(string Broj_tablice)
        {
            vozniPark voznipark = null;
            string sql = $"SELECT * FROM  VozniPark WHERE Broj_tablice = '{Broj_tablice}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznipark = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return voznipark;
        }
        public static bool AzurirajVozniPark(int Id_vozni_red, vozniPark updatedPark)
        {
            try
            {
                string updateQuery = $"UPDATE VozniPark SET Naziv_vozila = '{updatedPark.Naziv_vozila}', " +
                                    $"Broj_tablice = '{updatedPark.Broj_tablice}', " +
                                    $"Broj_mjesta = '{updatedPark.Broj_mjesta}' " +
                                    $"WHERE Id_vozni_park = {updatedPark.Id_vozni_park}";


                DB.OpenConnection();
                DB.ExecuteCommand(updateQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom ažuriranja voznog parka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
    }
}