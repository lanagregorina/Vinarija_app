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
    public partial class Ambalaza : Form
    {
        public Ambalaza()
        {
            InitializeComponent();
        }

        private void OsvjeziAmbalazu()
        {
            List<vrstaAmbalaze> listaAmbalaze = vrstaAmbalaze.DohvatiAmbalazu();
            dgvVrstaAmbalaze.DataSource = listaAmbalaze;
        }

        private void OsvjeziPodrum()
        {
            List<vinoPodrum> listaPodrum = vinoPodrum.DohvatiPodrum();
            dgvVinoPodrum.DataSource = listaPodrum;
        }

        private void OsvjeziVinoAmbalaza()
        {
            List<vinoAmbalaza> listaVinoAmbalaza = vinoAmbalaza.DohvatiVinoAmbalaza();
            dgvVinoAmbalaza.DataSource = listaVinoAmbalaza;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvVrstaAmbalaze.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVrstaAmbalaze.SelectedRows)
                {
                    vrstaAmbalaze odabranaAmb = row.DataBoundItem as vrstaAmbalaze;
                    odabranaAmb.Obrisi();
                }
            }
            OsvjeziAmbalazu();
        }

        private void Ambalaza_Load(object sender, EventArgs e)
        {
            OsvjeziAmbalazu();
            OsvjeziPodrum();
            OsvjeziVinoAmbalaza();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVrstaAmbalaze.SelectedRows.Count > 0)
            {
                vrstaAmbalaze odabranaAmb = dgvVrstaAmbalaze.SelectedRows[0].DataBoundItem as vrstaAmbalaze;
                NovaAmbalaza frmNovaAmbalaza = new NovaAmbalaza(odabranaAmb);
                frmNovaAmbalaza.ShowDialog();
                OsvjeziAmbalazu();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovaAmbalaza frmNovaAmbalaza = new NovaAmbalaza();
            frmNovaAmbalaza.ShowDialog();
            OsvjeziAmbalazu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvVinoPodrum.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVinoPodrum.SelectedRows)
                {
                    vinoPodrum odabranoVP = row.DataBoundItem as vinoPodrum;
                    odabranoVP.Obrisi();
                }
            }
            OsvjeziPodrum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvVinoPodrum.SelectedRows.Count > 0)
            {
                vinoPodrum odabranoVP = dgvVinoPodrum.SelectedRows[0].DataBoundItem as vinoPodrum;
                NovoVinoPodrum frmNovoVinoPodrum = new NovoVinoPodrum(odabranoVP);
                frmNovoVinoPodrum.ShowDialog();
                OsvjeziPodrum();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NovoVinoPodrum frmNovoVinoPodrum = new NovoVinoPodrum();
            frmNovoVinoPodrum.ShowDialog();
            OsvjeziPodrum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvVinoAmbalaza.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVinoAmbalaza.SelectedRows)
                {
                    vinoAmbalaza odabranoVA = row.DataBoundItem as vinoAmbalaza;
                    odabranoVA.Obrisi();
                }
            }
            OsvjeziVinoAmbalaza();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvVinoAmbalaza.SelectedRows.Count > 0)
            {
                vinoAmbalaza odabranoVA = dgvVinoAmbalaza.SelectedRows[0].DataBoundItem as vinoAmbalaza;
                NovoVinoAmbalaza frmNovoVinoAmbalaza = new NovoVinoAmbalaza(odabranoVA);
                frmNovoVinoAmbalaza.ShowDialog();
                OsvjeziVinoAmbalaza();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NovoVinoAmbalaza frmNovoVinoAmbalaza = new NovoVinoAmbalaza();
            frmNovoVinoAmbalaza.ShowDialog();
            OsvjeziVinoAmbalaza();
        }
    }
}
