using MySql.Data.MySqlClient;
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


            Program.tanuloFormInsert.ShowDialog();
            adatbazisNyit.TanuloBox_ListBox_Update();

        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.tanuloUpdate.ShowDialog();
            adatbazisNyit.TanuloBox_ListBox_Update();

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.tanuloFormDelete.ShowDialog();
            adatbazisNyit.TanuloBox_ListBox_Update();

        }

        private void TanulokBetoltese()
        {

            Program.nyitoForm.TanuloBox.Items.Clear();
            foreach (var item in adatbazisNyit.osszestanulo())
            {

                Program.nyitoForm.TanuloBox.Items.Add(item);

            }

        }

        private void NyitoForm_Load(object sender, EventArgs e)
        {

            adatbazisNyit.osszestanulo();
            TanulokBetoltese();
            if (Program.nyitoForm.TanuloBox.SelectedIndex < 0)
            {

                return;

            };

        }
    }
}
