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
    public partial class TanuloFormInsert : Form
    {
        Adatbazis adatbazisInsert = new Adatbazis();

        public TanuloFormInsert()
        {
            InitializeComponent();
        }

        private void TanuloFormInsert_Load(object sender, EventArgs e)
        {



        }

        private void HozzaadButton_Click(object sender, EventArgs e)
        {

            adatbazisInsert.Hozzaad();

        }
    }
}
