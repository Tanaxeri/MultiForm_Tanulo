using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm_Tanulo
{
    public partial class TanuloFormDelete : Form
    {
        Adatbazis adatbazisDelete = new Adatbazis();
        public TanuloFormDelete()
        {
            InitializeComponent();
        }

        private void TanuloFormDelete_Load(object sender, EventArgs e)
        {

            if (Program.nyitoForm.TanuloBox.SelectedIndex < 0)
            {

                return;

            };
            TanuloAdat kivalasztottTanuloDel = (TanuloAdat)Program.nyitoForm.TanuloBox.SelectedItem;
            DeleteID.Text = kivalasztottTanuloDel.Id.ToString();
            TorolNev.Text = kivalasztottTanuloDel.Nev;
            TorolTantargy.Text = kivalasztottTanuloDel.Tantargy;
            TorolDatum.Value = kivalasztottTanuloDel.Datum.Date;
            TorolJelleg.Text = kivalasztottTanuloDel.Jelleg;
            TorolJegy.Value = kivalasztottTanuloDel.Jegy;

        }

        private void TorolesButton_Click(object sender, EventArgs e)
        {

            if (adatbazisDelete.Torol(int.Parse(DeleteID.Text)))
            {

                Close();

            }

        }
    }
}
