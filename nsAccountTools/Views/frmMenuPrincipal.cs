using System;
using System.IO;
using System.Windows.Forms;
using nsAccountTools.Utils;

namespace nsAccountTools.Views
{
    public partial class frmMenuPrincipal : Form
    {
        string connString = "";
        public frmMenuPrincipal(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void DestroyEnvironment()
        {
            string fileAdress = @"..\..\Scripts\DropScript.txt";
            if (!File.Exists(fileAdress))
            {
                Messages.SendWarning("Não foi possível encontrar o script para exclusão das funcionalidades criadas neste banco.", "Arquivo não encontrado");
                return;
            }

            string script = File.ReadAllText(fileAdress);
            script = script.Replace("\r", " ");
            script = script.Replace("\n", " ");
            script = script.Replace("\t", " ");

            Utils.Environment.ChangeEnviroment(connString, script);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (Messages.SendQuestionWithCancel("Deseja realmente sair?", "Sair") == DialogResult.Yes)
            {
                DestroyEnvironment();
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Messages.SendQuestionWithCancel("Deseja realmente voltar a tela inicial?", "Voltar") == DialogResult.Yes)
            {
                DestroyEnvironment();
                Application.Restart();
            }
        }

        private void btnDePara_Click(object sender, EventArgs e)
        {
            frmListaDePara form = new frmListaDePara(connString);
            form.ShowDialog();
        }

        private void btnFolha_Click(object sender, EventArgs e)
        {
            frmOpcoesFolha form = new frmOpcoesFolha(connString);
            form.ShowDialog();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            frmLIstas form = new frmLIstas(connString);
            form.ShowDialog();
        }
    }
}