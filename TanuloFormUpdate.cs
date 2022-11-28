using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiForm_Tanulo
{
    public partial class TanuloFormUpdate : Form
    {
        Adatbazis adatbazisUpdate = new Adatbazis();
        public TanuloFormUpdate()
        {
            InitializeComponent();
        }

        private void TanuloFormUpdate_Load(object sender, EventArgs e)
        {

            MessageBox.Show(Program.nyitoForm.NevText.Text + " adatainak a módosítása");

            if (Program.nyitoForm.TanuloBox.SelectedIndex < 0)
            {

                return;

            };
            TanuloAdat kivalasztottTanuloUpdate = (TanuloAdat)Program.nyitoForm.TanuloBox.SelectedItem;
            UpdateNev.Text = kivalasztottTanuloUpdate.Nev;
            UpdateTantargy.Text = kivalasztottTanuloUpdate.Tantargy;
            UpdateDatum.Value = kivalasztottTanuloUpdate.Datum.Date;
            UpdateJelleg.Text = kivalasztottTanuloUpdate.Jelleg;
            UpdateJegy.Value = kivalasztottTanuloUpdate.Jegy;

        }

        private void ModositButton_Click(object sender, EventArgs e)
        {

            

        }
    }
}
