using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafipax_20250116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsrogzit_Click(object sender, EventArgs e)
        {
            frmgyorshajtas gyorshajtas = new frmgyorshajtas();
            gyorshajtas.ShowDialog();
        }
    }
}
