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
    internal class VozniRed
    {
        public static vozniRed GetVozniRed(int Id_vozni_red)
        {
            vozniRed voznired = null;
            string sql = $"SELECT * FROM VozniRed WHERE Id_vozni_red = {Id_vozni_red}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznired = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return voznired;
        }
        public static vozniRed CreateObject(SqlDataReader reader)
        {
            int Id_vozni_red = int.Parse(reader["Id_vozni_red"].ToString());
            //int Id_linije = int.Parse(reader["Id_linije"].ToString());
           // int Id_stanice = int.Parse(reader["Id_stanice"].ToString());
            //int Id_vozni_park = int.Parse(reader["Id_vozni_park"].ToString());
            string Naziv_stanice = reader["Naziv_stanice"].ToString();
            string Naziv_linije = reader["Naziv_linije"].ToString();
            string Naziv_vozila = reader["Naziv_vozila"].ToString();

            var voznired = new vozniRed
            {
                Id_vozni_red = Id_vozni_red,
                //Id_linije = Id_linije,
                //Id_stanice = Id_stanice,
                //Id_vozni_park = Id_vozni_park,
                Naziv_stanice = Naziv_stanice,
                Naziv_linije = Naziv_linije,
                Naziv_vozila = Naziv_vozila,
            };
            return voznired;
        }
        public static List<vozniRed> GetVozniRed()
        {
            List<vozniRed> voznired = new List<vozniRed>();

            string sql = "SELECT * FROM VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                vozniRed voznired1 = CreateObject(reader);
                voznired.Add(voznired1);
            }

            reader.Close();
            DB.CloseConnection();

            return voznired;
        }
        public static bool ProvjeriVozniRed(int Id_vozni_red)
        {
            string sql = $"SELECT COUNT(*) FROM VozniRed WHERE Id_vozni_red = '{Id_vozni_red}'";

            DB.OpenConnection();
            int count = (int)DB.GetScalar(sql);
            DB.CloseConnection();

            return count > 0;
        }
        public static bool DodajVozniRed(vozniRed novivozniRed)
        {
            try
            {
                string checkIfExistsQuery = $"SELECT COUNT(*) FROM VozniRed WHERE Id_vozni_red = '{novivozniRed.Id_vozni_red}'";
                DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
                DB.OpenConnection();

                int vozniRedCount = (int)DB.GetScalar(checkIfExistsQuery);

                if (vozniRedCount > 0)
                {
                    MessageBox.Show("Vozni red već postoji u bazi podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.CloseConnection();
                    return false;
                }

                string insertQuery = $"INSERT INTO VozniRed (Id_linije, Id_vozni_park, Naziv_stanice, Naziv_linije, Naziv_vozila) " +
                                     $"VALUES ('{novivozniRed.Id_linije}', '{novivozniRed.Id_vozni_park}', '{novivozniRed.Naziv_stanice}', '{novivozniRed.Naziv_linije}', '{novivozniRed.Naziv_vozila}')";

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
        public static bool IzbrisiVozniRed(int Id_vozni_red)
        {
            try
            {
                string deleteQuery = $"DELETE FROM VozniRed WHERE Id_vozni_red = {Id_vozni_red}";

                DB.OpenConnection();
                DB.ExecuteCommand(deleteQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom brisanja voznog reda: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
        public static DSUGP.Models.vozniRed PretraziVozniRed(int Id_vozni_red)
        {
            DSUGP.Models.vozniRed vozniRed = null;
            string sql = $"SELECT * FROM  VozniRed WHERE Id_vozni_red = '{Id_vozni_red}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozniRed = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return vozniRed;
        }
        public static bool AzurirajVozniRed(int Id_vozni_red, vozniRed updatedRed)
        {
            try
            {
                string updateQuery = $"UPDATE VozniRed SET Naziv_stanice= '{updatedRed.Naziv_stanice}', " +
                                     $"Naziv_linije = '{updatedRed.Naziv_linije}', " +
                                     $"Naziv_vozila = '{updatedRed.Naziv_vozila}' " +
                                     $"WHERE Id_vozni_red = {Id_vozni_red}";

                DB.OpenConnection();
                DB.ExecuteCommand(updateQuery);
                DB.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom ažuriranja voznog reda: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.CloseConnection();
                return false;
            }
        }
    }
}