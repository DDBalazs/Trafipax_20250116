﻿using System;
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
        int buntetesosszeg;
        int osszeg;
        int dbok;
        List<Gyorshajtas> lista = new List<Gyorshajtas>();
        void betoltes()
        {
            lista.Clear();
            dgadatok.Rows.Clear();
            FileStream fs = new FileStream("..\\..\\src\\gyorshajtasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Gyorshajtas g = new Gyorshajtas(sr.ReadLine());
                lista.Add(g);
                dgadatok.Rows.Add(g.Rendszam, g.Mertseb, g.Buntetes);
            }
            sr.Close();
            fs.Close();
            buntetesosszeg = 0;
            lbmeresek.Text = lista.Count.ToString()+" db";
            for (int i = 0; i<lista.Count; i++)
            {
                buntetesosszeg = buntetesosszeg+lista[i].Buntetes;
            }
            lbosszeg.Text = buntetesosszeg.ToString()+" ft";
        }
        public frmstatisztika()
        {
            InitializeComponent();
        }

        private void frmstatisztika_Load(object sender, EventArgs e)
        {
            rball.Checked = true;
            betoltes();
        }

        private void rball_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
            cbkategoriak.Visible = false;
        }

        private void rdkategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbkategoriak.Visible = true;
            dgadatok.Rows.Clear();
            lbosszeg.Text = "0 Ft";
            lbmeresek.Text = "0 db";
        }

        private void cbkategoriak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkategoriak.SelectedIndex == 0)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 0)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString()+" Ft";
                lbmeresek.Text = dbok.ToString()+" db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 1)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 1)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 2)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 2)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 3)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 3)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 4)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 4)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 5)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 5)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 6)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 6)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
            else if (cbkategoriak.SelectedIndex == 7)
            {
                dgadatok.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Gyorshajtasikategoria() == 7)
                    {
                        dgadatok.Rows.Add(lista[i].Rendszam, lista[i].Mertseb, lista[i].Buntetes);
                        osszeg += lista[i].Buntetes;
                        dbok++;
                    }
                }
                lbosszeg.Text = osszeg.ToString() + " Ft";
                lbmeresek.Text = dbok.ToString() + " db";
                osszeg = 0;
                dbok = 0;
            }
        }
    }
}
