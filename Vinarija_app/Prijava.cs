﻿using System;
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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if ((txtKorIme.Text == "korisnik") && (txtLozinka.Text == "123456"))
            {
                Glavni_izbornik forma = new Glavni_izbornik();
                forma.Show();
            }
            else MessageBox.Show("Pogrešan unos! Pokušajte ponovno");

            txtLozinka.Text = "";
        }
    }
}
