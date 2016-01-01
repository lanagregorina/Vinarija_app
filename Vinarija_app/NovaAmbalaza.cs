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
    public partial class NovaAmbalaza : Form
    {
        private vrstaAmbalaze ambalaza = null;

        public NovaAmbalaza()
        {
            InitializeComponent();
        }

        public NovaAmbalaza(vrstaAmbalaze odabranaAmb) 
        {
            InitializeComponent();
            ambalaza = odabranaAmb;
        }
        private void NovaAmbalaza_Load(object sender, EventArgs e)
        {
            txtVrsta.Focus();
            if (ambalaza != null)
            {
                txtId.Text = ambalaza.idAmbalaza.ToString();
                txtVrsta.Text = ambalaza.vrsta;
                txtZapremnina.Text = ambalaza.zapremnina.ToString();
                
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (ambalaza == null)
            {
                ambalaza = new vrstaAmbalaze();
            }
            ambalaza.vrsta = txtVrsta.Text;
            ambalaza.zapremnina = float.Parse(txtZapremnina.Text);
            
            ambalaza.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
