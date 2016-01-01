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
    public partial class NovaSorta : Form
    {
        private sorte popis = null;

        public NovaSorta()
        {
            InitializeComponent();
        }

        public NovaSorta(sorte odabranaS) 
        {
            InitializeComponent();
            popis = odabranaS;
        }

        private void NovaSorta_Load(object sender, EventArgs e)
        {
            txtNazivS.Focus();

            if (popis != null)
            {
                txtId.Text = popis.idSorte.ToString();
                txtNazivS.Text = popis.naziv;

            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (popis == null)
            {
                popis = new sorte();
            }
            popis.naziv = txtNazivS.Text;
            
            popis.Spremi();
            this.Close();
        }

        private void odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
