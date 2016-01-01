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
    public partial class NoviDnevnik : Form
    {
        private dnevnikVinogradara dnevnik = null;

        public NoviDnevnik()
        {
            InitializeComponent();
        }

        public NoviDnevnik(dnevnikVinogradara odabraniDnev) 
        {
            InitializeComponent();
            dnevnik = odabraniDnev;
        }

        private void NoviDnevnik_Load(object sender, EventArgs e)
        {
            txtDatum.Focus();
            if (dnevnik != null)
            {
                txtId.Text = dnevnik.idDnevnikV.ToString();
                txtDatum.Text = dnevnik.datum.ToString();
                txtAktivnosti.Text = dnevnik.aktivnosti;
                txtOpazanja.Text = dnevnik.opazanja;
                txtIdVinograd.Text = dnevnik.idVinograd.ToString();

            }
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (dnevnik == null)
            {
                dnevnik = new dnevnikVinogradara();
            }
            dnevnik.datum = txtDatum.Text;
            dnevnik.aktivnosti = txtAktivnosti.Text;
            dnevnik.opazanja = txtOpazanja.Text;
            dnevnik.idVinograd = int.Parse(txtIdVinograd.Text);
            

            dnevnik.Spremi();
            this.Close();
        }
    }
}
