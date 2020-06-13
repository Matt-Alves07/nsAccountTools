﻿using System;
using System.IO;
using System.Windows.Forms;
using nsAccountTools.Utils;
using nsAccountTools.Views;

namespace nsAccountTools
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (Messages.SendQuestion("Deseja realmente sair?", "Sair") == DialogResult.Yes)
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

        public bool IsValid()
        {
            string caption = "Campo vazio";
            string rdbcaption = "Campo não selecionado";
            if (txtHost.Text == "")
            {
                Messages.SendError("O campo de endereço do servidor não pode ficar vazio.", caption);
                return false;

            } else if (txtPort.Text == "")
            {
                Messages.SendError("O campo da porta do servidor não pode ficar vazio.", caption);
                return false;

            } else if (txtUser.Text == "")
            {
                Messages.SendError("O campo de usuário do servidor não pode ficar vazio.", caption);
                return false;

            } else if (txtPass.Text == "")
            {
                Messages.SendError("O campo de senha do servidor não pode ficar vazio.", caption);
                return false;

            } else if (txtDatabase.Text == "")
            {
                Messages.SendError("O campo do nome do banco de dados não pode ficar vazio.", caption);
                return false;

            } else if ((!rdbCriar.Checked) && (!rdbNaoCriar.Checked))
            {
                Messages.SendError("É necessário escolher, pelo menos, uma das opções de criação do ambiente.", rdbcaption);
                return false;

            } else if ((!rdbManter.Checked) && (!rdbNaoManter.Checked))
            {
                Messages.SendError("É necessário escolher, pelo menos, uma das opções de manter funcionalidades.", rdbcaption);
                return false;

            } else
            {
                return true;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            string fileAdress = @"..\..\Scripts\CreateScript.txt";
            string script = "";

            if (IsValid())
            {
                string connString = string.Format(
                    "Server={0};Port={1};User Id={2};Password={3};Database={4}",
                    txtHost.Text, txtPort.Text, txtUser.Text, txtPass.Text, txtDatabase.Text
                );

                pgbCreate.Increment(25);

                if (rdbCriar.Checked)
                {
                    pgbCreate.Visible = true;
                    if (File.Exists(fileAdress))
                    {
                        pgbCreate.Increment(50);

                        script = File.ReadAllText(fileAdress);
                        script = script.Replace("\r", " ");
                        script = script.Replace("\n", " ");
                        script = script.Replace("\t", " ");
                        pgbCreate.Increment(75);

                        Cursor.Current = Cursors.WaitCursor;

                        Utils.Environment.ChangeEnviroment(connString, script);

                        Cursor.Current = Cursors.Default;
                        pgbCreate.Increment(100);

                    } else
                    {
                        Messages.SendError("Arquivo não encontrado no diretório padrão.\nEntre em contato com o administrador.", "Arquivo não encontrado");
                    }
                }

                pgbCreate.Visible = false;

                frmMenuPrincipal frm = new frmMenuPrincipal(connString, rdbManter.Checked);
                this.Hide();
                frm.Show();
            }
        }
    }
}
