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
        void betoltes()
        {
            lista.Clear();
            dgadatok.Rows.Clear();
            FileStream fs = new FileStream("..\\..\\src\\buntetesek.txt", FileMode.Open);
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
            betoltes();
        }
    }
}
