using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinarija_app
{
    public partial class Podrum : Form
    {
        public Podrum()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ambalaza forma = new Ambalaza();
            forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dnevnik forma = new Dnevnik();
            forma.Show();
        }
    }
}
