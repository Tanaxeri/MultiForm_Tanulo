using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiForm_Tanulo
{
    internal class Adatbazis
    {

        MySqlConnection conn;
        MySqlCommand cmd;
        string hiba;

        public Adatbazis(string server = "localhost", string user = "root", string password = "", string db = "diakok")
        {

            conn = new MySqlConnection(kapcsolatString(server, user, password, db));
            if (kapcsolatNyit())
            {

                cmd = conn.CreateCommand();

            }
            else
            {

                MessageBox.Show(hiba, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hiba = null;

            }


        }

        public List<TanuloAdat> osszestanulo()
        {

            List<TanuloAdat> list = new List<TanuloAdat>();
            cmd.CommandText = "SELECT `id`, `nev`, `tantargy`, `datum`, `jelleg`, `jegy` FROM `diak` WHERE 1";
            if (kapcsolatNyit())
            {

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        TanuloAdat tanulo = new TanuloAdat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("tantargy"), dr.GetDateTime("datum"), dr.GetString("jelleg"), dr.GetInt32("jegy"));
                        list.Add(tanulo);

                    }

                }
                kapcsolatZar();

            }
            return list;

        }

        public void TanuloBox_ListBox_Update()
        {
            //Frissíti a ListBox-ot
            Program.nyitoForm.TanuloBox.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`, `tantargy`, `datum`, `jelleg`, `jegy` FROM `diak` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {

                    TanuloAdat uj = new TanuloAdat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("tantargy"), dr.GetDateTime("datum"), dr.GetString("jelleg"), dr.GetInt32("jegy"));
                    Program.nyitoForm.TanuloBox.Items.Add(uj);

                }

            }
            conn.Close();

        }

        public bool Hozzaad(string nev, string tantargy, DateTime datum, string jelleg, int jegy)
        {

            cmd.CommandText = "INSERT INTO `diak` (`id`, `nev`, `tantargy`, `datum`, `jelleg`, `jegy`) VALUES (NULL, @nev, @tantargy, @datum, @jelleg, @jegy)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", nev);
            cmd.Parameters.AddWithValue("@tantargy", tantargy);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@jelleg", jelleg);
            cmd.Parameters.AddWithValue("@jegy", jegy);
            kapcsolatNyit();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Adatot sikeresen rögzítettük!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                   

                    return true;
                }
                else
                {

                    MessageBox.Show("Adatot nem sikerült rögzíteni!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }


            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            kapcsolatZar();

            return true;

        }

        public bool Modosit(int id, string nev, string tantargy, DateTime datum, string jelleg, int jegy)
        {

            cmd.CommandText = "UPDATE `diak` SET `nev` = @nev, `tantargy` = @tantargy, `datum` = @datum, `jelleg` = @jelleg, `jegy` = @jegy WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nev", nev);
            cmd.Parameters.AddWithValue("@tantargy", tantargy);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@jelleg", jelleg);
            cmd.Parameters.AddWithValue("@jegy", jegy);
            kapcsolatNyit();
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adatok módosítása sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
                kapcsolatZar();

            }
            else
            {

                MessageBox.Show("Az adatok módosítása sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            return true;
        }

        public bool Torol(int id)
        {

            cmd.CommandText = "DELETE FROM `diak` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            kapcsolatNyit();
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adat törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;

                kapcsolatZar();
            }
            else
            {

                MessageBox.Show("Az adat törlése sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

        }

        private bool kapcsolatNyit()
        {

            //Megadott kapcsolati adatok alapján felépíti az  adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {

                    conn.Open();

                }
            }
            catch (MySqlException ex)
            {

                hiba = ex.Message;
                return false;

            }

            return true;
        }

        private bool kapcsolatZar()
        {

            //Megadott kapcsolati adatok alapján felépíti az  adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {

                    conn.Close();

                }
            }
            catch (MySqlException ex)
            {

                hiba = ex.Message;
                return false;

            }

            return true;
        }

        private string kapcsolatString(string server, string user, string password, string db)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            return builder.ConnectionString;

        }

    }
}
