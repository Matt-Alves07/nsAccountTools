﻿using System;
using System.Windows.Forms;

namespace nsAccountTools.Views
{
    public partial class frmOpcoesFolha : Form
    {
        string connString = "";
        public frmOpcoesFolha(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterarHistorico_Click(object sender, EventArgs e)
        {
            frmAlterarHistorico form = new frmAlterarHistorico(connString);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            frmContabilizarParcial form = new frmContabilizarParcial(connString);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnReverter_Click(object sender, EventArgs e)
        {
            frmContabilizarParcial form = new frmContabilizarParcial(connString, "reverter");
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
