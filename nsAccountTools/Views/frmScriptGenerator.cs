using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsAccountTools.Utils;

namespace nsAccountTools.Views
{
    public partial class frmScriptGenerator : Form
    {
        List<string> registros = new List<string>();
        public frmScriptGenerator(List<string> _registros)
        {
            InitializeComponent();
            registros = _registros;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlterUpdateFields(bool _disable = true)
        {
            if (_disable)
            {
                rdbAmbas.Checked = false;
                rdbAmbas.Enabled = false;
                rdbDebito.Checked = false;
                rdbDebito.Enabled = false;
                rdbCredito.Checked = false;
                rdbCredito.Enabled = false;
            } else
            {
                rdbAmbas.Checked = true;
                rdbAmbas.Enabled = true;
                rdbDebito.Enabled = true;
                rdbCredito.Enabled = true;
            }
        }

        private void rdbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDelete.Checked)
            {
                rdbUpdate.Checked = false;
                AlterUpdateFields();
            }
        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUpdate.Checked)
            {
                rdbDelete.Checked = false;
                AlterUpdateFields(false);
                rdbAmbas.Checked = true;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string script = "";
            if (rdbDelete.Checked)
            {
                script = "DELETE FROM contabilizacao.dadosusuarios WHERE dadousuario IN (";

                int i = registros.Count() - 1;
                foreach (string registro in registros)
                {
                    script += registro;
                    if (i > 0)
                    {
                        script += ",";
                    }

                    i -= 1;
                }

                script += ");";
            } else if (rdbUpdate.Checked)
            {
                script = "UPDATE contabilizacao.dadosusuarios SET ";

                if (rdbAmbas.Checked)
                {
                    script += $"contadebito = '{txtConta.Text}', contacredito = '{txtConta.Text}' WHERE dadousuario IN (";
                } else if (rdbDebito.Checked)
                {
                    script += $"contadebito = '{txtConta.Text}' WHERE dadousuario IN (";
                } else if (rdbCredito.Checked)
                {
                    script += $"contacredito = '{txtConta.Text}' WHERE dadousuario IN (";
                } else
                {
                    Messages.SendWarning("É necessário escolher, ao menos, uma das opções de natureza da conta.", "Campo desmarcado");
                }

                int i = registros.Count() - 1;
                foreach (string registro in registros)
                {
                    script += registro;
                    if (i > 0)
                    {
                        script += ",";
                    }

                    i -= 1;
                }

                script += ");";
            } else
            {
                Messages.SendWarning("É necessário escolher ao menos uma das opções.", "Campo desmarcado");
            }

            if (script == "")
            {
                Messages.SendError("Ocorreu um erro ao gerar o script desejado", "Erro");
            } else
            {
                txtScript.Text = script;
            }
        }
    }
}
