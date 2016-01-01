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
    public partial class Dnevnik : Form
    {
        public Dnevnik()
        {
            InitializeComponent();
        }

        private void OsvjeziDnevnikP()
        {
            List<dnevnikPodrumara> listaDnevnikaP = dnevnikPodrumara.DohvatiDnevnikP();
            dgvDnevnikP.DataSource = listaDnevnikaP;
        }
        private void Dnevnik_Load(object sender, EventArgs e)
        {
            OsvjeziDnevnikP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDnevnikP.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDnevnikP.SelectedRows)
                {
                    dnevnikPodrumara odabraniDP = row.DataBoundItem as dnevnikPodrumara;
                    odabraniDP.Obrisi();
                }
            }
            OsvjeziDnevnikP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDnevnikP.SelectedRows.Count > 0)
            {
                dnevnikPodrumara odabraniDP = dgvDnevnikP.SelectedRows[0].DataBoundItem as dnevnikPodrumara;
                NoviDnevnikP frmNoviDnevnikP = new NoviDnevnikP(odabraniDP);
                frmNoviDnevnikP.ShowDialog();
                OsvjeziDnevnikP();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoviDnevnikP frmNoviDnevnikP = new NoviDnevnikP();
            frmNoviDnevnikP.ShowDialog();
            OsvjeziDnevnikP();
        }
    }
}
