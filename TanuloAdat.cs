using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm_Tanulo
{
    internal class TanuloAdat
    {

        int id;
        string nev;
        string tantargy;
        DateTime datum;
        string jelleg;
        int jegy;

        public int Id { get => id; set => id = value; }

        public string Nev { get => nev; set => nev = value; }

        public string Tantargy { get => tantargy; set => tantargy = value; }

        public DateTime Datum { get => datum; set => datum = value; }

        public string Jelleg { get => jelleg; set => jelleg = value; }

        public int Jegy { get => jegy; set => jegy = value; }

        public TanuloAdat(int id, string nev, string tantargy, DateTime datum, string jelleg, int jegy)
        {
            Id = id;
            Nev = nev;
            Tantargy = tantargy;
            Datum = datum;
            Jelleg = jelleg;
            Jegy = jegy;
        }

        public override string ToString()
        {
            return nev + " " + tantargy + " " + datum + " " + jelleg + " " + jegy;
        }

    }
}
