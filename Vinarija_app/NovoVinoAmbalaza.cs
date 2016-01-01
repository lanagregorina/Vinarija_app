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
    public partial class NovoVinoAmbalaza : Form
    {
        private vinoAmbalaza VinoAmbalaza = null;

        public NovoVinoAmbalaza()
        {
            InitializeComponent();
        }

        public NovoVinoAmbalaza(vinoAmbalaza odabranoVA) 
        {
            InitializeComponent();
            VinoAmbalaza = odabranoVA;
        }

        private void NovoVinoAmbalaza_Load(object sender, EventArgs e)
        {
            txtIdVino.Focus();
            if (VinoAmbalaza != null)
            {
                txtId.Text = VinoAmbalaza.idAmbalazaVina.ToString();
                txtIdVino.Text = VinoAmbalaza.idVino.ToString();
                txtIdAmbalaza.Text = VinoAmbalaza.idAmbalaza.ToString();
                txtKolicina.Text = VinoAmbalaza.kolicina.ToString();
                txtDatum.Text = VinoAmbalaza.datum.ToString();
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (VinoAmbalaza == null)
            {
                VinoAmbalaza = new vinoAmbalaza();
            }
            VinoAmbalaza.datum = txtDatum.Text;
            VinoAmbalaza.kolicina = float.Parse(txtKolicina.Text);
            VinoAmbalaza.idAmbalaza = int.Parse(txtIdAmbalaza.Text);
            VinoAmbalaza.idVino = int.Parse(txtIdVino.Text);

            VinoAmbalaza.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
