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

    public partial class NyitoForm : Form
    {
        Adatbazis adatbazisNyit = new Adatbazis();

        public NyitoForm()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (nincsadat())
            {

                return;

            }
            Program.tanuloFormInsert.ShowDialog();

        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (nincsadat())
            {

                return;

            }
            Program.tanuloUpdate.ShowDialog();

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (nincsadat())
            {

                return;

            }
            Program.tanuloFormDelete.ShowDialog();

        }

        private void TanulokBetoltese()
        {

            TanuloBox.Items.Clear();
            foreach (var item in adatbazisNyit.osszestanulo())
            {

                TanuloBox.Items.Add(item);

            }

        }

        private bool nincsadat()
        {
            //Ellenőrzi hogy van-e adat
            if (string.IsNullOrEmpty(NevText.Text))
            {

                MessageBox.Show("Adjon meg egy nevet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NevText.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(TantargyText.Text))
            {

                MessageBox.Show("Adjon meg egy tantárgyat!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TantargyText.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(JellegText.Text))
            {

                MessageBox.Show("Adjon meg egy jelleget!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JellegText.Focus();
                return true;

            }
            return false;

        }

        private void NyitoForm_Load(object sender, EventArgs e)
        {

            TanulokBetoltese();
            if (TanuloBox.SelectedIndex < 0)
            {

                return;

            };
            TanuloAdat kivalasztottTanuloNyit = (TanuloAdat)TanuloBox.SelectedItem;
            NevText.Text = kivalasztottTanuloNyit.Nev;
            TantargyText.Text = kivalasztottTanuloNyit.Tantargy;
            DatumTime.Value = kivalasztottTanuloNyit.Datum.Date;
            JellegText.Text = kivalasztottTanuloNyit.Jelleg;
            JegyNum.Value = kivalasztottTanuloNyit.Jegy;

        }
    }
}
