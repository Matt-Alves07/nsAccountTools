using System;
using System.Windows.Forms;
using nsAccountTools.Utils;

namespace nsAccountTools
{
    public partial class frmInicial : Form
    {
        Messages messages = new Messages();
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (messages.SendQuestion("Deseja realmente sair?", "Sair") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmInicial_Shown(object sender, EventArgs e)
        {
            txtHost.Focus();
            rdbCriar.Checked = true;
            rdbNaoManter.Checked = true;
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            messages.SendWarning("Essa funcionalidade não está implementada.\nTenha paciência, jovem Padawan.", "Ainda por vir...");
        }
    }
}
