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
    public partial class frmgyorshajtas : Form
    {
        int buntetes = 0;
        void szamolas()
        {
            if(txmertseb.Text.Length > 0)
            {
                if (100 <= Convert.ToInt32(txmertseb.Text) && Convert.ToInt32(txmertseb.Text) < 120)
                {
                    lbbuntetes.Text = "0 Ft";
                    lbkategoria.Text = "1.";
                }
                else if (120 <= Convert.ToInt32(txmertseb.Text) && Convert.ToInt32(txmertseb.Text) < 135)
                {
                    lbkategoria.Text = "2.";
                    lbbuntetes.Text = "39000 Ft";
                    buntetes = 39000;
                }
                else if (135 <= Convert.ToInt32(txmertseb.Text) && Convert.ToInt32(txmertseb.Text) < 150)
                {
                    lbkategoria.Text = "3.";
                    lbbuntetes.Text = "58500 Ft";
                    buntetes = 58500;
                }
                else if (150 <= Convert.ToInt32(txmertseb.Text) && Convert.ToInt32(txmertseb.Text) < 165)
                {
                    lbkategoria.Text = "4.";
                    lbbuntetes.Text = "78000 Ft";
                    buntetes = 78000;
                }
                else if (165 <= Convert.ToInt32(txmertseb.Text) && Convert.ToInt32(txmertseb.Text) < 180)
                {
                    lbkategoria.Text = "5.";
                    lbbuntetes.Text = "117000 Ft";
                    buntetes = 117000;
                }
            }
        }
        public frmgyorshajtas()
        {
            InitializeComponent();
        }

        private void txrendszam_TextChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = new DialogResult();
            uzenet = MessageBox.Show("Biztos elveti?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(uzenet == DialogResult.Yes)
            {
                Close();
                txmertseb.Clear();
                txrendszam.Clear();
            }
        }

        private void txmertseb_TextChanged(object sender, EventArgs e)
        {
            if(txmertseb.Text.Length > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txmertseb.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számot adjon meg!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txmertseb.Clear();
                    return;
                }
                if (int.Parse(txmertseb.Text) > 180)
                {
                    MessageBox.Show("A sebesség maximum 180 km/h lehet!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txmertseb.Clear();
                }
            }
            szamolas();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (File.Exists("..\\..\\src\\gyorshajtasok.txt"))
            {
                FileStream fs = new FileStream("..\\..\\src\\gyorshajtasok.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("\n" + txrendszam.Text.ToString() + ";" + txmertseb.Text.ToString() + ";" + buntetes.ToString());

                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\src\\gyorshajtasok.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("\n" + txrendszam.Text.ToString() + ";" + txmertseb.Text.ToString() + ";" + buntetes.ToString());

                sw.Close();
                fs.Close();
            }
            txmertseb.Clear();
            txrendszam.Clear();
            lbbuntetes.Text = "0 Ft";
            lbkategoria.Text = "Nincs gyorshajtás";
            MessageBox.Show("Sikeres bejelentés!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
