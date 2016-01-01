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
    public partial class NovoVinoPodrum : Form
    {
        private vinoPodrum podrum = null;

        public NovoVinoPodrum()
        {
            InitializeComponent();
        }

        public NovoVinoPodrum(vinoPodrum odabranoVP) 
        {
            InitializeComponent();
            podrum = odabranoVP;
        }

        private void NovoVinoPodrum_Load(object sender, EventArgs e)
        {
            txtIdBerbe.Focus();
            if (podrum != null)
            {
                txtId.Text = podrum.idVino.ToString();
                txtIdBerbe.Text = podrum.idBerbe.ToString();
                txtOpis.Text = podrum.opis;
                txtKolicina.Text = podrum.kolicina.ToString();
                txtOstalo.Text = podrum.ostalo.ToString();
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (podrum == null)
            {
                podrum = new vinoPodrum();
            }
            podrum.opis = txtOpis.Text;
            podrum.kolicina = float.Parse(txtKolicina.Text);
            podrum.ostalo = float.Parse(txtOstalo.Text);
            podrum.idBerbe = int.Parse(txtIdBerbe.Text);

            podrum.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
