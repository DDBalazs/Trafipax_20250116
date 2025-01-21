using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafipax_20250116
{

    internal class Gyorshajtas
    {
        string rendszam;
        int mertseb;
        int buntetes;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int Mertseb { get => mertseb; set => mertseb = value; }
        public int Buntetes { get => buntetes; set => buntetes = value; }

        public Gyorshajtas(string sor)
        {
            string[] db = sor.Split(';');
            rendszam = db[0];
            mertseb = Convert.ToInt32(db[1]);
            buntetes = Convert.ToInt32(db[2]);
        }

        public int Gyorshajtasikategoria()
        {
            if (mertseb < 100)
            {
                return 0;
            }
            else if (mertseb < 120 || mertseb > 100)
            {
                return 1;
            }
            else if (mertseb >= 120 || mertseb < 135)
            {
                return 2;
            }
            else if (mertseb >= 135 || mertseb < 150)
            {
                return 3;
            }
            else if (mertseb >= 150 || mertseb < 165)
            {
                return 5;
            }
            else if (mertseb >= 165 || mertseb < 180)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }
    }
}
