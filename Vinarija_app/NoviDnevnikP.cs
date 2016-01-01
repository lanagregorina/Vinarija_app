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
    public partial class NoviDnevnikP : Form
    {
        private dnevnikPodrumara dnevnikP = null;

        public NoviDnevnikP()
        {
            InitializeComponent();
        }
        public NoviDnevnikP(dnevnikPodrumara odabraniDP) 
        {
            InitializeComponent();
            dnevnikP = odabraniDP;
        }
        private void NoviDnevnikP_Load(object sender, EventArgs e)
        {
            txtDatum.Focus();
            if (dnevnikP != null)
            {
                txtId.Text = dnevnikP.idDnevnikP.ToString();
                txtDatum.Text = dnevnikP.datum.ToString();
                txtIdVino.Text = dnevnikP.idVino.ToString();
                txtAktivnosti.Text = dnevnikP.aktivnosti;
                txtTemperatura.Text = dnevnikP.temperatura.ToString();
                txtAlkohol.Text = dnevnikP.alkohol.ToString();
                txtSecer.Text = dnevnikP.secer.ToString();
                txtpH.Text = dnevnikP.pH.ToString();
                txtUkupnaKiselost.Text = dnevnikP.ukupnaKiselost.ToString();
                txtHlapivaKiselost.Text = dnevnikP.hlapivaKiselost.ToString();
                txtSlobodniS.Text = dnevnikP.slobodniSO2.ToString();
                txtUkupniS.Text = dnevnikP.ukupniSO2.ToString();

            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (dnevnikP == null)
            {
                dnevnikP = new dnevnikPodrumara();
            }
            dnevnikP.datum = txtDatum.Text;
            dnevnikP.idVino = int.Parse(txtIdVino.Text);
            dnevnikP.aktivnosti = txtAktivnosti.Text;
            dnevnikP.temperatura = float.Parse(txtTemperatura.Text);
            dnevnikP.alkohol = float.Parse(txtAlkohol.Text);
            dnevnikP.secer = float.Parse(txtSecer.Text);
            dnevnikP.pH = float.Parse(txtpH.Text);
            dnevnikP.ukupnaKiselost = float.Parse(txtUkupnaKiselost.Text);
            dnevnikP.hlapivaKiselost = float.Parse(txtHlapivaKiselost.Text);
            dnevnikP.slobodniSO2 = float.Parse(txtSlobodniS.Text);
            dnevnikP.ukupniSO2 = float.Parse(txtUkupniS.Text);
            
            dnevnikP.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
