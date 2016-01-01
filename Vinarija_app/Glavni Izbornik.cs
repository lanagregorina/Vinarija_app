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
    public partial class Glavni_izbornik : Form
    {
        public Glavni_izbornik()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Forum forma = new Forum(); 
            forma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Prognoza forma = new Prognoza();
            forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vinograd forma = new Vinograd();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Berbe forma = new Berbe();
            forma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Podrum forma = new Podrum();
            forma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
