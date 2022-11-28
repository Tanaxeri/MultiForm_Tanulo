using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm_Tanulo
{
    internal static class Program
    {

        static public TanuloFormUpdate tanuloUpdate = null;
        static public TanuloFormInsert tanuloFormInsert = null;
        static public TanuloFormDelete tanuloFormDelete = null;
        static public NyitoForm nyitoForm = null;
        static public Adatbazis adatbazis = null;

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tanuloUpdate = new TanuloFormUpdate();
            tanuloFormInsert = new TanuloFormInsert();
            tanuloFormDelete = new TanuloFormDelete();
            nyitoForm = new NyitoForm();
            Application.Run(nyitoForm);


        }
    }
}
