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

        public Adatbazis(string server = "localhost", string user = "root", string password = "", string db = "tanulok")
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
            cmd.CommandText = "SELECT `id`, `nev`, `tantargy`, `datum`, `jelleg`, `jegy` FROM `tanulo` WHERE 1";
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

        public bool Hozzaad()
        {

            cmd.CommandText = "INSERT INTO `tanulo` (`id`, `nev`, `tantargy`, `datum`, `jelleg`, `jegy`) VALUES (NULL, @nev, @tantargy, @datum, @jelleg, @jegy)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", Program.tanuloFormInsert.InsertNev.Text);
            cmd.Parameters.AddWithValue("@tantargy", Program.tanuloFormInsert.InsertTantargy.Text);
            cmd.Parameters.AddWithValue("@datum", Program.tanuloFormInsert.InsertDatum.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@jelleg", Program.tanuloFormInsert.InsertJelleg.Text);
            cmd.Parameters.AddWithValue("@jegy", Program.tanuloFormInsert.InsertJegy.Value.ToString());
            kapcsolatNyit();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Adatot sikeresen rögzítettük!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.tanuloFormInsert.InsertID.Text = "";
                    Program.tanuloFormInsert.InsertNev.Text = "";
                    Program.tanuloFormInsert.InsertTantargy.Text = "";
                    Program.tanuloFormInsert.InsertDatum.ResetText();
                    Program.tanuloFormInsert.InsertJelleg.Text = "";
                    Program.tanuloFormInsert.InsertJegy.Minimum = 0;

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
