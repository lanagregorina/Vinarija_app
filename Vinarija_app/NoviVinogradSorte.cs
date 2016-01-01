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
    public partial class NoviVinogradSorte : Form
    {
        private vinogradSorte vinogradS = null;

        public NoviVinogradSorte()
        {
            InitializeComponent();
        }

        public NoviVinogradSorte(vinogradSorte odabraniVinS) 
        {
            InitializeComponent();
            vinogradS = odabraniVinS;
        }

        private void NoviVinogradSorte_Load(object sender, EventArgs e)
        {
            txtIdVinograd.Focus();
            if (vinogradS != null)
            {
                txtId.Text = vinogradS.idVinogradSorte.ToString();
                txtIdVinograd.Text = vinogradS.idVinograd.ToString();
                txtIdSorte.Text = vinogradS.idSorte.ToString();
                txtBrCokota.Text = vinogradS.brCokota.ToString();
                txtSmjestaj.Text = vinogradS.smjestaj;
                txtDatumSadnje.Text = vinogradS.datumSadnje;
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (vinogradS == null)
            {
                vinogradS = new vinogradSorte();
            }
            vinogradS.idVinograd = int.Parse(txtIdVinograd.Text);
            vinogradS.idSorte = int.Parse(txtIdSorte.Text);
            vinogradS.brCokota = int.Parse(txtBrCokota.Text);
            vinogradS.smjestaj = txtSmjestaj.Text;
            vinogradS.datumSadnje = txtDatumSadnje.Text;

            vinogradS.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
