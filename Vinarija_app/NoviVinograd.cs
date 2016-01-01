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
    public partial class NoviVinograd : Form
    {
        private mojVinograd vinograd = null;

        public NoviVinograd()
        {
            InitializeComponent();
        }

        public NoviVinograd(mojVinograd odabraniVin) 
        {
            InitializeComponent();
            vinograd = odabraniVin;
        }

        private void NoviVinograd_Load(object sender, EventArgs e)
        {
            txtNaziv.Focus();
            if (vinograd != null)
            {
                txtId.Text = vinograd.idVinograd.ToString();
                txtNaziv.Text = vinograd.naziv;
                txtLokacija.Text = vinograd.lokacija;
                txtBrCokota.Text = vinograd.brCokota.ToString();
                txtBrRedova.Text = vinograd.brRedova.ToString();

            }

        }

        private void Spremi_Click(object sender, EventArgs e)
        {
            if (vinograd == null)
            {
                vinograd = new mojVinograd();
            }
            vinograd.naziv = txtNaziv.Text;
            vinograd.lokacija = txtLokacija.Text;
            vinograd.brCokota = int.Parse(txtBrCokota.Text);
            vinograd.brRedova = int.Parse(txtBrRedova.Text);

            vinograd.Spremi();
            this.Close();
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
