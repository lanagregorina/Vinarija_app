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
    public partial class Berbe : Form
    {
        public Berbe()
        {
            InitializeComponent();
        }

        private void OsvjeziBerbe()
        {
            List<berba> listaBerbi = berba.DohvatiBerbu();
            dgvBerbe.DataSource = listaBerbi;
        }

        private void Berbe_Load(object sender, EventArgs e)
        {
            OsvjeziBerbe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBerbe.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBerbe.SelectedRows)
                {
                    berba odabranaB = row.DataBoundItem as berba;
                    odabranaB.Obrisi();
                }
            }
            OsvjeziBerbe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvBerbe.SelectedRows.Count > 0)
            {
                berba odabranaB = dgvBerbe.SelectedRows[0].DataBoundItem as berba;
                NovaBerba frmNovaBerba = new NovaBerba (odabranaB);
                frmNovaBerba.ShowDialog();
                OsvjeziBerbe();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovaBerba frmNovaBerba = new NovaBerba();
            frmNovaBerba.ShowDialog();
            OsvjeziBerbe();
        }
    }
}
