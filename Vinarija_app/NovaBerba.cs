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
    public partial class NovaBerba : Form
    {
        private berba Berba = null;
        
        public NovaBerba()
        {
            InitializeComponent();
        }

        public NovaBerba(berba odabranaB) 
        {
            InitializeComponent();
            Berba = odabranaB;
        }

        private void NovaBerba_Load(object sender, EventArgs e)
        {
            txtDatum.Focus();
            if (Berba != null)
            {
                txtId.Text = Berba.idBerbe.ToString();
                txtDatum.Text = Berba.datum;
                txtKolicina.Text = Berba.kolicina.ToString();
                txtVinogradSorte.Text = Berba.idVinogradSorte.ToString();
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (Berba == null)
            {
                Berba = new berba();
            }
            Berba.datum = txtDatum.Text;
            Berba.kolicina = float.Parse(txtKolicina.Text);
            Berba.idVinogradSorte = int.Parse(txtVinogradSorte.Text);

            Berba.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
