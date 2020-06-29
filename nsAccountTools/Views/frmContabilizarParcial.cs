using nsAccountTools.DAO;
using nsAccountTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsAccountTools.Views
{
    public partial class frmContabilizarParcial : Form
    {
        private enum Action {contabilizar, reverter};
        private Action tipoAcao;
        string connString = "";

        //Utils
        Error error = new Error();
        DadosBase dadosBase = new DadosBase();
        //Tipos de calculos
        Dictionary<string, string> calculos = new Dictionary<string, string>();
        //Listas de grupos empresarias, empresas e estabelecimentos
        List<gruposEmpresariais> gruposEmpresariais = new List<gruposEmpresariais>();
        List<empresas> empresas = new List<empresas>();
        List<estabelecimentos> estabelecimentos = new List<estabelecimentos>();

        public frmContabilizarParcial(string _connString, string _action = "contabilizar")
        {
            InitializeComponent();
            connString = _connString;
            if (_action == "contabilizar")
            {
                tipoAcao = Action.contabilizar;
            } else
            {
                tipoAcao = Action.reverter;
            }
        }

        private void PreencheCalculos()
        {
            calculos.Add("fo", "Simples");
            calculos.Add("fe", "Férias");
            calculos.Add("13", "13º Salário");
            calculos.Add("pplr", "Diretores");
            calculos.Add("ad", "Adiantamentos");
            calculos.Add("ad13", "Adiamento de 13º Salário");
            calculos.Add("re", "Rescisão");
            calculos.Add("sin", "Sindical");
            calculos.Add("foc", "Corretiva");
            calculos.Add("13c", "Complemento de 13º Salário");
            calculos.Add("cfe", "Complemento de Férias");
            calculos.Add("adfunc", "Adiantamento");
            calculos.Add("fofunc", "Funcionários");
            calculos.Add("focontind", "Contribuinte Inidividual");
            calculos.Add("focontindaut", "Contribuinte Individual Autônomo");
            calculos.Add("focontinddir", "Contrinuinte Individual Diretor");
            calculos.Add("focontindcop", "Contribuinte Individual Cooperado");
            calculos.Add("foestag", "Estagiário");
        }

        private void Clear(bool _grupo = true, bool _empresa = true, bool _estabelecimento = true, bool _tipo = true)
        {
            if (_grupo)
            {
                cbbGrupo.Items.Clear();
                cbbGrupo.Text = "<SELECIONE>";
                lblGrupo.Text = "<SELECIONE>";
                cbbGrupo.Items.Add("<SELECIONE>");
            }

            if (_empresa)
            {
                cbbEmpresa.Items.Clear();
                cbbEmpresa.Text = "<SELECIONE>";
                lblEmpresa.Text = "<SELECIONE>";
                cbbEmpresa.Items.Add("<SELECIONE>");
            }

            if (_estabelecimento)
            {
                cbbEstabelecimento.Items.Clear();
                cbbEstabelecimento.Text = "<SELECIONE>";
                lblEstabelecimento.Text = "<SELECIONE>";
                cbbEstabelecimento.Items.Add("<SELECIONE>");
            }

            if (_tipo)
            {
                cbbTipo.Text = "<SELECIONE>";
                lblTipo.Text = "<SELECIONE>";
            }

            dtpDataInicio.Value = DateTime.Today;
            dtpDataInicio.Value = DateTime.Today;
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
                Messages.SendWarning("Selecione uma emrpesa válida antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((cbbEstabelecimento.Text == "") || (cbbEstabelecimento.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione um estabelecimento válido antes de prosseguir.", campoInvalido);
                return false;
            }

            if ((cbbTipo.Text == "") || (cbbTipo.Text == "<SELECIONE>"))
            {
                Messages.SendWarning("Selecione um tipo válido antes de prosseguir.", campoInvalido);
                return false;
            }

            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmContabilizarParcial_Shown(object sender, EventArgs e)
        {
            if (tipoAcao == Action.contabilizar)
            {
                Text = "Contabilização Parcial";
            } else
            {
                Text = "Reversão Parcial";
            }

            Clear();
            PreencheCalculos();
            foreach (string descricao in calculos.Values)
            {
                cbbTipo.Items.Add(descricao);
            }

            error = dadosBase.GetGruposEmpresariais(connString, ref gruposEmpresariais);
            if (error.retorno == Error.tipoRetorno.sucesso)
            {
                foreach (gruposEmpresariais grupo in gruposEmpresariais)
                {
                    cbbGrupo.Items.Add(grupo.codigo);
                }
            } else
            {
                if (error.codigo != "")
                {
                    Messages.SendError($"Ocorreu um erro acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                } else
                {
                    Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                }
            }
        }

        private void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            lblTipo.Text = cbbTipo.Text.ToUpper();
        }

        private void cbbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = "";
            Clear(false);
            if ((cbbGrupo.Text == "") || (cbbGrupo.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                string grupoEmpresarial = "";
                foreach (gruposEmpresariais grupo in gruposEmpresariais)
                {
                    if (grupo.codigo == cbbGrupo.Text)
                    {
                        descricao = grupo.descricao;
                        grupoEmpresarial = grupo.grupoEmpresarial;
                        break;
                    }
                }

                if (empresas.Count() > 0)
                {
                    empresas.Clear();
                }

                error = dadosBase.GetEmpresas(connString, grupoEmpresarial, ref empresas);
                if (error.retorno == Error.tipoRetorno.sucesso)
                {
                    foreach (empresas empresa in empresas)
                    {
                        cbbEmpresa.Items.Add(empresa.codigo);
                    }
                } else
                {
                    if (error.codigo != "")
                    {
                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                    } else
                    {
                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                    }
                }
            }

            lblGrupo.Text = descricao;
        }

        private void cbbEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            Clear(false, false);
            if ((cbbEmpresa.Text == "") || (cbbEmpresa.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                string emp = "";
                foreach (empresas empresa in empresas)
                {
                    if (empresa.codigo == cbbEmpresa.Text)
                    {
                        emp = empresa.empresa;
                        descricao = empresa.razaosocial;
                        break;
                    }
                }

                if (estabelecimentos.Count() > 0)
                {
                    estabelecimentos.Clear();
                }

                error = dadosBase.GetEstabelecimentos(connString, emp, ref estabelecimentos);
                if (error.retorno == Error.tipoRetorno.sucesso)
                {
                    foreach (estabelecimentos estabelecimento in estabelecimentos)
                    {
                        cbbEstabelecimento.Items.Add(estabelecimento.codigo);
                    }
                } else
                {
                    if (error.codigo != "")
                    {
                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                    }
                    else
                    {
                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                    }
                }
            }

            lblEmpresa.Text = descricao;
        }

        private void cbbEstabelecimento_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            if ((cbbEstabelecimento.Text == "") || (cbbEstabelecimento.Text == "<SELECIONE>"))
            {
                lblEstabelecimento.Text = "<SELECIONE>";
            } else
            {
                foreach (estabelecimentos estabelecimento in estabelecimentos)
                {
                    if (estabelecimento.codigo == cbbEstabelecimento.Text)
                    {
                        descricao = estabelecimento.descricao;
                        break;
                    }
                }
            }

            lblEstabelecimento.Text = descricao;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string est = "";
                string tipo = "";

                foreach (estabelecimentos estabelecimento in estabelecimentos)
                {
                    if (estabelecimento.codigo == cbbEstabelecimento.Text)
                    {
                        est = estabelecimento.estabelecimento;
                        break;
                    }
                }

                string desc = "";
                foreach (string chave in calculos.Keys)
                {
                    calculos.TryGetValue(chave, out desc);
                    if (desc == cbbTipo.Text)
                    {
                        tipo = chave;
                        break;
                    }
                }

                lblStatus.Text = "";

                if (tipoAcao == Action.contabilizar)
                {
                    bool contabilizado = false;
                    string processamentoFato = "";
                    List<string> contabilizacoes = new List<string>();

                    error = dadosBase.GetContabilizacoes(connString, tipo, est, dtpDataInicio.Value.ToString(), dtpDataTermino.Value.ToString(), ref processamentoFato, ref contabilizacoes);
                    if (error.retorno != Error.tipoRetorno.sucesso)
                    {
                        if (error.codigo != "")
                        {
                            Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                        }
                        else
                        {
                            Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                        }
                    }
                    else
                    {
                        if (contabilizacoes.Count() <= 0)
                        {
                            Messages.SendInfo("Não há itens a contabilizar com esses parâmetros", "Sem Incidência");
                        }
                        else
                        {
                            lblStatus.Text = $"\nIniciando a contabilização de {contabilizacoes.Count()} iten(s).";
                            Cursor.Current = Cursors.WaitCursor;

                            int i = 1;
                            string processamentoFatoTemporario = "";
                            foreach (string id in contabilizacoes)
                            {
                                error = dadosBase.Contabilizar(connString, id, ref contabilizado, ref processamentoFatoTemporario);
                                if (error.retorno != Error.tipoRetorno.sucesso)
                                {
                                    if (error.codigo != "")
                                    {
                                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                                    }
                                    else
                                    {
                                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                                    }
                                }
                                else
                                {
                                    if (contabilizado)
                                    {
                                        lblStatus.Text += $"\n\nItem {i} contabilizado com sucesso.";
                                        error = dadosBase.FinalizarContabilizar(connString, processamentoFato, processamentoFatoTemporario);
                                        if (error.retorno != Error.tipoRetorno.sucesso)
                                        {
                                            if (error.codigo != "")
                                            {
                                                Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                                            }
                                            else
                                            {
                                                Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        lblStatus.Text += $"\n\nO item {i} não foi contabilizado.";
                                    }
                                }

                                i += 1;
                            }
                        }
                    }
                } else
                {
                    bool revertido = false;
                    List<string> processamentoFatos = new List<string>();

                    error = dadosBase.GetProcessamentoFatos(connString, est, tipo, dtpDataInicio.Value.ToString(), dtpDataTermino.Value.ToString(), ref processamentoFatos);
                    if (error.retorno != Error.tipoRetorno.sucesso)
                    {
                        if (error.codigo != "")
                        {
                            Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                        }
                        else
                        {
                            Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                        }
                    } else
                    {
                        if (processamentoFatos.Count() <= 0)
                        {
                            Messages.SendInfo("Não existem itens a serem revertidos com esses parâmetros.", "Sem incidência");
                        } else
                        {
                            lblStatus.Text += $"\nIniciando a reversão de {processamentoFatos.Count()} itens.";
                            int i = 1;
                            foreach (string processamentoFato in processamentoFatos)
                            {
                                lblStatus.Text += $"\n\nIniciando a reversão do item {i}";

                                error = dadosBase.ReverteContabilizacao(connString, est, processamentoFato, ref revertido);
                                if (error.retorno != Error.tipoRetorno.sucesso)
                                {
                                    if (error.codigo != "")
                                    {
                                        Messages.SendError($"Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. {error.codigo}): {error.mensagem}", "Erro");
                                    }
                                    else
                                    {
                                        Messages.SendError($"Ocorreu um erro.\nDetalhes: {error.mensagem}", "Erro");
                                    }
                                } else
                                {
                                    if (revertido) { lblStatus.Text += $"\nItem {i} revertido com sucesso."; }
                                    else { lblStatus.Text += $"\nItem {i} não foi revertido."; }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
