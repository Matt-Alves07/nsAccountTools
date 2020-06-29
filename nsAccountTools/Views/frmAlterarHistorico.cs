using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using nsAccountTools.DAO;
using nsAccountTools.Utils;

namespace nsAccountTools.Views
{
    public partial class frmAlterarHistorico : Form
    {
        string connString = "";
        Error error = new Error();
        DadosBase dadosBase = new DadosBase();
        //Lista de fatos/capitulos
        List<fatos> fatos = new List<fatos>();
        List<capitulos> capitulos = new List<capitulos>();
        //Lista de grupos empresariais/empresas
        List<gruposEmpresariais> grupos = new List<gruposEmpresariais>();
        List<empresas> empresas = new List<empresas>();

        public frmAlterarHistorico(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void Clear(bool _grupo = true, bool _empresa = true, bool _fato = true, bool _capitulo = true, bool _historico = true, bool _status = true)
        {
            if (_grupo)
            {
                cbbGrupo.Items.Clear();
                cbbGrupo.Items.Add("<SELECIONE>");
                cbbGrupo.Text = "<SELECIONE>";
                lblGrupoEmpresarial.Text = "<SELECIONE>";
            }

            if (_empresa)
            {
                cbbEmpresa.Items.Clear();
                cbbEmpresa.Items.Add("<SELECIONE>");
                cbbEmpresa.Text = "<SELECIONE>";
                lblEmpresa.Text = "<SELECIONE>";
            }

            if (_fato)
            {
                cbbFato.Items.Clear();
                cbbFato.Items.Add("<SELECIONE>");
                cbbFato.Text = "<SELECIONE>";
                lblFato.Text = "<SELECIONE>";
            }

            if (_capitulo)
            {
                cbbCapitulo.Items.Clear();
                cbbCapitulo.Items.Add("<SELECIONE>");
                cbbCapitulo.Text = "<SELECIONE>";
                lblCapitulo.Text = "<SELECIONE>";
            }

            if (_historico)
            {
                txtHistorico.Text = "";
            }

            if (_status)
            {
                lblStatus.Text = "";
            }
        }

        private bool Validar()
        {
            string campoInvalido = "Campo Inválido";
            if ((cbbGrupo.Text == "") || (cbbGrupo.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione um grupo empresarial válido antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((cbbEmpresa.Text == "") || (cbbEmpresa.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione uma empresa válida antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((cbbFato.Text == "") || (cbbFato.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione um fato válido antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((cbbCapitulo.Text == "") || (cbbCapitulo.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione um capítulo válido antes de prosseguir.", campoInvalido);
                return false;
            }

            if (txtHistorico.Text == "")
            {
                Messages.SendWarning("Preencha um histórico válido antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((!(rdbLancamentos.Checked)) && (!(rdbRubricas.Checked)))
            {
                Messages.SendWarning("Selecione uma das opções entre lançamentos ou rubricas antes de prosseguir.", campoInvalido);
                return false;
            }

            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlterarHistorico_Shown(object sender, EventArgs e)
        {
            Clear();

            error = dadosBase.GetGruposEmpresariais(connString, ref grupos);
            if (error.retorno == Error.tipoRetorno.sucesso)
            {
                foreach (gruposEmpresariais grupo in grupos)
                {
                    cbbGrupo.Items.Add(grupo.codigo);
                }
            } else
            {
                if (error.codigo != "")
                {
                    Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                } else
                {
                    Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                }
            }

            error = dadosBase.GetFatos(connString, ref fatos);
            if (error.retorno == Error.tipoRetorno.sucesso)
            {
                foreach (fatos fato in fatos)
                {
                    cbbFato.Items.Add(fato.descricao);
                }
            }
            else
            {
                if (error.codigo != "")
                {
                    Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                }
                else
                {
                    Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                }
            }
        }

        private void cbbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            Clear(false, true, false, false, false, false);
            if ((cbbGrupo.Text == "<SELECIONE>") || (cbbGrupo.Text == ""))
            {
                descricao = "<SELECIONE>";
            } else
            {
                string grupoempresarial = "";
                foreach (gruposEmpresariais grupo in grupos)
                {
                    if (grupo.codigo == cbbGrupo.Text)
                    {
                        grupoempresarial = grupo.grupoEmpresarial;
                        descricao = grupo.descricao;
                        break;
                    }
                }

                if (empresas.Count() > 0)
                {
                    empresas.Clear();
                }

                error = dadosBase.GetEmpresas(connString, grupoempresarial, ref empresas);
                if (error.retorno == Error.tipoRetorno.sucesso)
                {
                    foreach (empresas empresa in empresas)
                    {
                        cbbEmpresa.Items.Add(empresa.codigo);
                    }
                }
                else
                {
                    if (error.codigo != "")
                    {
                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                    }
                    else
                    {
                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                    }
                }
            }

            lblGrupoEmpresarial.Text = descricao;
        }

        private void cbbEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            if ((cbbEmpresa.Text == "") || (cbbEmpresa.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                foreach (empresas empresa in empresas)
                {
                    if (cbbEmpresa.Text == empresa.codigo)
                    {
                        descricao = empresa.razaosocial.ToUpper();
                        break;
                    }
                }
            }

            lblEmpresa.Text = descricao;
        }

        private void cbbFato_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            Clear(false, false, false, true, false, false);
            if ((cbbFato.Text == "") || (cbbFato.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                string objeto = "";
                foreach (fatos fato in fatos)
                {
                    if (fato.descricao == cbbFato.Text)
                    {
                        objeto = fato.objeto;
                        descricao = fato.descricao;
                        break;
                    }
                }

                if (capitulos.Count() > 0)
                {
                    capitulos.Clear();
                }

                error = dadosBase.GetCapitulos(connString, objeto, ref capitulos);
                if (error.retorno == Error.tipoRetorno.sucesso)
                {
                    foreach (capitulos capitulo in capitulos)
                    {
                        cbbCapitulo.Items.Add(capitulo.descricao);
                    }
                }
                else
                {
                    if (error.codigo != "")
                    {
                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                    }
                    else
                    {
                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                    }
                }
            }

            lblFato.Text = descricao;
        }

        private void cbbCapitulo_SelectedValueChanged(object sender, EventArgs e)
        {
            lblCapitulo.Text = cbbCapitulo.Text;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string emp = "";
                string cap = "";
                foreach (empresas empresa in empresas)
                {
                    if (empresa.codigo == cbbEmpresa.Text)
                    {
                        emp = empresa.empresa;
                        break;
                    }
                }

                foreach (capitulos capitulo in capitulos)
                {
                    if (capitulo.descricao == cbbCapitulo.Text)
                    {
                        cap = capitulo.capitulo;
                        break;
                    }
                }

                if ((emp != "") && (cap != ""))
                {
                    int total = 0;
                    error = dadosBase.GetQuantidadeLancamentos(connString, emp, cap, rdbLancamentos.Checked, ref total);
                    if (error.retorno == Error.tipoRetorno.sucesso)
                    {
                        if (total == 0)
                        {
                            Messages.SendInfo("Não existem registros a serem alterados.", "Sem incidência");
                        }
                        else
                        {
                            lblStatus.Text = "";
                            lblStatus.Text = "\n";
                            lblStatus.Text += $"Iniciando a alteração de {total} itens({DateTime.Now}).";

                            error = dadosBase.UpdateHistorico(connString, emp, cap, txtHistorico.Text, rdbLancamentos.Checked);
                            if (error.retorno == Error.tipoRetorno.sucesso)
                            {
                                lblStatus.Text += "\n\n";
                                lblStatus.Text += $"Terminada a alteração de {total} itens({DateTime.Now}).";
                            }
                            else
                            {
                                if (error.codigo != "")
                                {
                                    Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                                }
                                else
                                {
                                    Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (error.codigo != "")
                        {
                            Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.Detalhes(Cód. {error.GetCodigo()}): {error.GetMensagem()}", "Erro");
                        }
                        else
                        {
                            Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.GetMensagem()}", "Erro");
                        }
                    }
                }
            }
        }
    }
}