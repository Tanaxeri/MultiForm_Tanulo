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
            TorolNev.Text = kivalasztottTanuloDel.Nev;
            TorolTantargy.Text = kivalasztottTanuloDel.Tantargy;
            TorolDatum.Value = kivalasztottTanuloDel.Datum.Date;
            TorolJelleg.Text = kivalasztottTanuloDel.Jelleg;
            TorolJegy.Value = kivalasztottTanuloDel.Jegy;

        }
    }
}
