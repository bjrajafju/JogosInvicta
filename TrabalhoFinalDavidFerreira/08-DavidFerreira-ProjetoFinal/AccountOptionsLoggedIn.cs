﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class AccountOptionsLoggedIn : UserControl
    {
        public event EventHandler? logout;
        public event EventHandler? perfilAccess;
        public event EventHandler? comprasPrevias;
        public AccountOptionsLoggedIn()
        {
            InitializeComponent();
        }

        private void btnLagOut_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                logout?.Invoke(this, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perfilAccess?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comprasPrevias?.Invoke(this, EventArgs.Empty);
        }
    }
}
