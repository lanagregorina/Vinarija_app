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
    public partial class Vinograd : Form
    {
        public Vinograd()
        {
            InitializeComponent();
        }

        private void OsvjeziVinograd()
        {
            List<mojVinograd> listaVinograda = mojVinograd.DohvatiVinograd();
            dgvVinograd.DataSource = listaVinograda;
        }
        private void OsvjeziDnevnik()
        {
            List<dnevnikVinogradara> listaDnevnika = dnevnikVinogradara.DohvatiDnevnik();
            dgvDnevnik.DataSource = listaDnevnika;
        }
        private void OsvjeziSorte()
        {
            List<sorte> listaSorta = sorte.DohvatiSorte();
            dgvSorte.DataSource = listaSorta;
        }

        private void OsvjeziVinogradSorte()
        {
            List<vinogradSorte> listaSorta = vinogradSorte.DohvatiVinogradSorte();
            dgvVinogradSorte.DataSource = listaSorta;
        }
        private void Vinograd_Load(object sender, EventArgs e)
        {
            OsvjeziVinograd();
            OsvjeziDnevnik();
            OsvjeziSorte();
            OsvjeziVinogradSorte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvVinograd.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVinograd.SelectedRows)
                {
                    mojVinograd odabraniVin = row.DataBoundItem as mojVinograd;
                    odabraniVin.Obrisi();
                }
            }
            OsvjeziVinograd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVinograd.SelectedRows.Count > 0)
            {
                mojVinograd odabraniVin = dgvVinograd.SelectedRows[0].DataBoundItem as mojVinograd;
                NoviVinograd frmNoviVinograd = new NoviVinograd(odabraniVin);
                frmNoviVinograd.ShowDialog();
                OsvjeziVinograd();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoviVinograd frmNoviVinograd = new NoviVinograd();
            frmNoviVinograd.ShowDialog();
            OsvjeziVinograd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDnevnik.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDnevnik.SelectedRows)
                {
                    dnevnikVinogradara odabraniDnev = row.DataBoundItem as dnevnikVinogradara;
                    odabraniDnev.Obrisi();
                }
            }
            OsvjeziDnevnik();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvDnevnik.SelectedRows.Count > 0)
            {
                dnevnikVinogradara odabraniDnev = dgvDnevnik.SelectedRows[0].DataBoundItem as dnevnikVinogradara;
                NoviDnevnik frmNoviDnevnik = new NoviDnevnik(odabraniDnev);
                frmNoviDnevnik.ShowDialog();
                OsvjeziDnevnik();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NoviDnevnik frmNoviDnevnik = new NoviDnevnik();
            frmNoviDnevnik.ShowDialog();
            OsvjeziDnevnik();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvSorte.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSorte.SelectedRows)
                {
                    sorte odabranaS = row.DataBoundItem as sorte;
                    odabranaS.Obrisi();
                }
            }
            OsvjeziSorte();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvSorte.SelectedRows.Count > 0)
            {
                sorte odabranaS = dgvSorte.SelectedRows[0].DataBoundItem as sorte;
                NovaSorta frmNovaSorta = new NovaSorta (odabranaS);
                frmNovaSorta.ShowDialog();
                OsvjeziSorte();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NovaSorta frmNovaSorta = new NovaSorta();
            frmNovaSorta.ShowDialog();
            OsvjeziSorte();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dgvVinogradSorte.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVinogradSorte.SelectedRows)
                {
                    vinogradSorte odabraniVinS = row.DataBoundItem as vinogradSorte;
                    odabraniVinS.Obrisi();
                }
            }
            OsvjeziVinogradSorte();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dgvVinogradSorte.SelectedRows.Count > 0)
            {
                vinogradSorte odabraniVinS = dgvVinogradSorte.SelectedRows[0].DataBoundItem as vinogradSorte;
                NoviVinogradSorte frmNoviVinogradSorte = new NoviVinogradSorte(odabraniVinS);
                frmNoviVinogradSorte.ShowDialog();
                OsvjeziVinogradSorte();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NoviVinogradSorte frmNoviVinogradSorte = new NoviVinogradSorte();
            frmNoviVinogradSorte.ShowDialog();
            OsvjeziVinogradSorte();
        }
    }
}
