using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafipax_20250116
{
    public partial class frmstatisztika : Form
    {
        List<Buntetes> lista = new List<Buntetes>();
        void labelek()
        {
            int szam = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                szam++;
            }
            lbmeres.Text = "Mérések száma: "+szam.ToString()+" db";

            int osszeg = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i].Osszeg;
            }
            lbosszeg.Text = "Bírságok összege: " + osszeg.ToString() + " Ft";
        }
        void betoltes()
        {
            lista.Clear();
            dgadatok.Rows.Clear();
            FileStream fs = new FileStream("..\\..\\src\\gyorshajtasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Buntetes b = new Buntetes(sr.ReadLine());
                lista.Add(b);
                dgadatok.Rows.Add(b.Rendszam, b.Mertseb, b.Osszeg);
            }
            sr.Close();
            fs.Close();
        }
        public frmstatisztika()
        {
            InitializeComponent();
        }

        private void frmstatisztika_Load(object sender, EventArgs e)
        {
            rball.Checked = true;
            betoltes();
            labelek();
        }

        private void rbkategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbkategoria.Checked)
            {
                cbkategoriak.Visible= true;
            }
            else
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                }
                cbkategoriak.Visible= false;
            }
        }

        private void cbkategoriak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkategoriak.SelectedIndex == 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Mertseb < 100)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else if (cbkategoriak.SelectedIndex == 1)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (100 <= lista[i].Mertseb && lista[i].Mertseb < 120)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else if (cbkategoriak.SelectedIndex == 2)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (120 <= lista[i].Mertseb && lista[i].Mertseb < 135)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else if (cbkategoriak.SelectedIndex == 3)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (135 <= lista[i].Mertseb && lista[i].Mertseb < 150)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else if (cbkategoriak.SelectedIndex == 4)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (150 <= lista[i].Mertseb && lista[i].Mertseb < 165)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else if (cbkategoriak.SelectedIndex == 5)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (165 <= lista[i].Mertseb && lista[i].Mertseb < 180)
                    {
                        dgadatok.Rows.Clear();
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Osszeg);
                    }
                }
                labelek();
            }
            else
            {
                dgadatok.Rows.Clear();
            }
        }
    }
}
