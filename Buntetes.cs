using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafipax_20250116
{
    internal class Buntetes
    {
        string rendszam;
        int mertseb;
        int osszeg;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int Mertseb { get => mertseb; set => mertseb = value; }
        public int Osszeg { get => osszeg; set => osszeg = value; }

        public Buntetes(string sor)
        {
            string[] db = sor.Split(';');
            rendszam = db[0];
            mertseb = Convert.ToInt32(db[1]);
            osszeg = Convert.ToInt32(db[2]);
        }

        public int BuntetesKategoria()
        {
            if(osszeg < 100)
            {
                return 0;
            }
            else if(100 <= osszeg || osszeg < 120)
            {
                return 1;
            }
            else if(120 <= osszeg || osszeg < 135)
            {
                return 2;
            }
            else if(135 <= osszeg || osszeg < 150)
            {
                return 3;
            }
            else if(150 <= osszeg || osszeg < 165)
            {
                return 4;
            }
            else if(165 <= osszeg || osszeg <= 180)
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }
    }
}
