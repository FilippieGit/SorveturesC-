﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorvetures
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 2;
                lblNumSplash.Text = pgbSplash.Value.ToString() + "%";
            }
            else
            {
                tmrSplash.Enabled = false;
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
