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
using nsAccountTools.DAO;

namespace nsAccountTools.Views
{
    public partial class frmListaDePara : Form
    {
        string connString = "";
        Error error = new Error();
        DadosBase dadosBase = new DadosBase();

        //Instanciação da DAO de dados usuários e lista de dado usuário
        DadosUsuarios DadosUsuarios = new DadosUsuarios();
        List<DadoUsuario> dadoUsuario = new List<DadoUsuario>();

        //Listas de grupos empresariais e empresas
        List<gruposEmpresariais> gruposEmpresariais = new List<gruposEmpresariais>();
        List<empresas> empresas = new List<empresas>();
        //Listas de fatos e capítulos
        List<fatos> fatos = new List<fatos>();
        List<capitulos> capitulos = new List<capitulos>();


        public frmListaDePara(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validar()
        {
            string campoInvalido = "Campo inválido";
            bool valido = false;

            foreach (gruposEmpresariais grupo in gruposEmpresariais)
            {
                if (cbbGrupo.Text == grupo.codigo)
                {
                    valido = true;
                    break;
                }
            }
            if (!(valido))
            {
                Messages.SendWarning("O grupo empresarial selecionado não é válido.\nSelecione um grupo empresarial válido antes de prosseguir.", campoInvalido);
                return false;
            }
            
            valido = false;
            foreach (empresas empresa in empresas)
            {
                if (cbbEmpresa.Text == empresa.codigo)
                {
                    valido = true;
                    break;
                }
            }
            if (!(valido))
            {
                Messages.SendWarning("A empresa selecionada não é válida.\nSelecione uma empresa válida antes de prosseguir.", campoInvalido);
                return false;
            }

            valido = false;
            foreach (fatos fat in fatos)
            {
                if (cbbFato.Text == fat.descricao)
                {
                    valido = true;
                    break;
                }
            }
            if (!(valido))
            {
                if (Messages.SendQuestion("Deseja realmente prosseguir sem selecionar um fato válido?", campoInvalido) == DialogResult.No)
                {
                    Messages.SendWarning("O fato selecionado não é válido.\nSelecione um fato válido antes de prosseguir.", campoInvalido);
                    return false;
                }
            }

            valido = false;
            foreach (capitulos capitulo in capitulos)
            {
                if (cbbCapitulo.Text == capitulo.descricao)
                {
                    valido = true;
                    break;
                }
            }
            if (!(valido))
            {
                if (Messages.SendQuestion("Deseja realmente prosseguir sem selecionar um capítulo válido?", campoInvalido) == DialogResult.No)
                {
                    Messages.SendWarning("O capítulo selecionado não é válido.\nSelecione um capítulo válido antes de prosseguir.", campoInvalido);
                    return false;
                }
            }

            if ((!(rdbAmbas.Checked)) && (!(rdbDebito.Checked)) && (!(rdbCredito.Checked)))
            {
                Messages.SendError("É necessário escolher ao menos uma das opções de natureza antes de prosseguir.", campoInvalido);
                return false;
            }

            if (txtContas.Text == "")
            {
                Messages.SendWarning("Preencha o campo de contas com conta(s) válida(s) antes de prosseguir.", campoInvalido);
            }

            return true;
        }

        private void Clear(bool _grupo = true, bool _empresa = true, bool _fato = true, bool _capitulo = true, bool _contas = true)
        {
            if (_grupo)
            {
                cbbGrupo.Text = "";
                cbbGrupo.Items.Clear();
                cbbGrupo.Items.Add("<SELECIONE>");
                lblGrupo.Text = "<SELECIONE>";
            }
            
            if (_empresa)
            {
                cbbEmpresa.Text = "";
                cbbEmpresa.Items.Clear();
                cbbEmpresa.Items.Add("<SELECTIONE>");
                lblEmpresa.Text = "<SELECIONE>";
            }

            if (_fato)
            {
                cbbFato.Text = "";
                cbbFato.Items.Clear();
                cbbFato.Items.Add("<SELECIONE>");
                lblFato.Text = "<SELECIONE>";
            }

            if (_capitulo)
            {
                cbbCapitulo.Text = "";
                cbbCapitulo.Items.Clear();
                cbbCapitulo.Items.Add("<SELECIONE>");
                lblCapitulo.Text = "<SELECIONE>";
            }

            if (_contas)
            {
                txtContas.Text = "";
            }
        }

        private void frmListaDePara_Shown(object sender, EventArgs e)
        {
            Clear();

            error = dadosBase.GetGruposEmpresariais(connString, ref gruposEmpresariais);
            if (error.retorno != Error.tipoRetorno.sucesso)
            {
                if (error.GetCodigo() == "")
                {
                    Messages.SendError("Ocorreu um erro ao listar os grupos empresariais.\nDetalhes: " + error.GetMensagem(), "Erro");
                } else
                {
                    Messages.SendError("Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. " + error.GetCodigo() + "): " + error.GetMensagem(), "Erro");
                }
            } else
            {
                foreach (gruposEmpresariais grupo in gruposEmpresariais)
                {
                    cbbGrupo.Items.Add(grupo.codigo);
                }
            }

            cbbGrupo.Focus();

            error = dadosBase.GetFatos(connString, ref fatos);
            if (error.retorno != Error.tipoRetorno.sucesso)
            {
                if (error.GetCodigo() == "")
                {
                    Messages.SendError("Ocorreu um erro ao listar os fatos.\nDetalhes: " + error.GetMensagem(), "Erro");
                } else
                {
                    Messages.SendError("Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. " + error.GetCodigo() + "): " + error.GetMensagem(), "Erro");
                }
            } else
            {
                foreach (fatos fato in fatos)
                {
                    cbbFato.Items.Add(fato.descricao);
                }
            }

            rdbAmbas.Checked = true;
        }

        private void cbbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            Clear(false, true, false, false, false);

            string descricao = "";
            string grupoEmpresarial = "";
            if ((cbbGrupo.Text == "<SELECIONE>") || (cbbGrupo.Text == ""))
            {
                descricao = "<SELECIONE>";
            } else
            {
                foreach (gruposEmpresariais grupo in gruposEmpresariais)
                {
                    if (grupo.codigo == cbbGrupo.Text)
                    {
                        descricao = grupo.descricao;
                        grupoEmpresarial = grupo.grupoEmpresarial;
                        break;
                    }
                }

                if (empresas.Count > 0)
                {
                    empresas.Clear();
                }

                error = dadosBase.GetEmpresas(connString, grupoEmpresarial, ref empresas);
                if (error.retorno != Error.tipoRetorno.sucesso)
                {
                    if (error.GetCodigo() == "")
                    {
                        Messages.SendError("Ocorreu um erro ao listar as empresas.\nDetalhes: " + error.GetMensagem(), "Erro");
                    } else
                    {
                        Messages.SendError("Ocorreu um erro ao acessar o banco de dados.\nDetalhes(Cód. " + error.GetCodigo() + "): " + error.GetMensagem(), "Erro");
                    }
                } else
                {
                    foreach (empresas empresa in empresas)
                    {
                        cbbEmpresa.Items.Add(empresa.codigo);
                    }
                }
            }

            lblGrupo.Text = descricao;
        }

        private void cbbEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            if ((cbbEmpresa.Text == "<SELECIONE>") || (cbbEmpresa.Text == ""))
            {
                descricao = "<SELECIONE>";
            } else
            {
                foreach (empresas empresa in empresas)
                {
                    if (empresa.codigo == cbbEmpresa.Text)
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
            Clear(false, false, false, true, false);

            string descricao = "";
            string objeto = "";
            if ((cbbFato.Text == "") || (cbbFato.Text == "<SELECIONE>")){
                descricao = "<SELECIONE>";
            } else
            {
                foreach (fatos fato in fatos)
                {
                    if (fato.descricao == cbbFato.Text)
                    {
                        descricao = fato.descricao.ToUpper();
                        objeto = fato.objeto;
                    }
                }

                if (capitulos.Count > 0)
                {
                    capitulos.Clear();
                }

                error = dadosBase.GetCapitulos(connString, objeto, ref capitulos);
                if (error.retorno != Error.tipoRetorno.sucesso)
                {

                } else
                {
                    foreach (capitulos capitulo in capitulos)
                    {
                        cbbCapitulo.Items.Add(capitulo.descricao);
                    }
                }
            }

            lblFato.Text = descricao;
        }

        private void cbbCapitulo_SelectedValueChanged(object sender, EventArgs e)
        {
            string descricao = "";
            if ((cbbCapitulo.Text == "") || (cbbCapitulo.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                foreach (capitulos capitulo in capitulos)
                {
                    if (capitulo.descricao == cbbCapitulo.Text)
                    {
                        descricao = capitulo.descricao;
                        break;
                    }
                }
            }

            lblCapitulo.Text = descricao;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            List<string> registros = new List<string>();

            foreach (DataGridViewRow row in dgvDadosUsuarios.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    registros.Add(Convert.ToString(row.Cells[0].Value.ToString()));
                }
            }

            if (registros.Count == 0)
            {
                Messages.SendWarning("É necessário selecionar ao menos uma conta para processar.", "Nenhum selecionado");
            } else
            {
                frmScriptGenerator form = new frmScriptGenerator(registros);
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cursor.Current = Cursors.WaitCursor;

                string whereClause = "";
                string contas = txtContas.Text;
                
                contas = contas.Replace("'", "");
                contas = contas.Replace(" ", "");
                contas = contas.Replace(",", "','");

                string emp = "";
                foreach (empresas empresa in empresas)
                {
                    if (cbbEmpresa.Text == empresa.codigo)
                    {
                        emp = empresa.empresa;
                        break;
                    }
                }
                whereClause = $"empresa = {emp} AND ";

                if ((cbbFato.Text != "") && (cbbFato.Text != "<SELECIONE>"))
                {
                    string objeto = "";
                    foreach (fatos fat in fatos)
                    {
                        if (cbbFato.Text == fat.descricao)
                        {
                            objeto = fat.objeto;
                            break;
                        }
                    }

                    if (objeto != "")
                    {
                        whereClause += $"fato = {objeto} AND ";

                        if ((cbbCapitulo.Text != "") && (cbbCapitulo.Text != "<SELECIONE>"))
                        {
                            string cap = "";
                            foreach (capitulos capitulo in capitulos)
                            {
                                if (capitulo.descricao == cbbCapitulo.Text)
                                {
                                    cap = capitulo.capitulo;
                                    break;
                                }
                            }

                            if (cap != "")
                            {
                                whereClause += $"capitulo = {cap} AND ";
                            }
                        }
                    }
                }

                if (rdbDebito.Checked)
                {
                    whereClause += $"contadebito IN ('{contas}');";
                } else if (rdbCredito.Checked)
                {
                    whereClause += $"contacredito IN ('{contas}');";
                } else
                {
                    whereClause += $"(contadebito IN ('{contas}') OR contacredito IN ('{contas}'));";
                }

                dgvDadosUsuarios.Rows.Clear();
                
                if (dadoUsuario.Count > 0)
                {
                    dadoUsuario.Clear();
                }

                error = DadosUsuarios.GetDadosUsuarios(connString, whereClause, ref dadoUsuario);
                foreach (DadoUsuario dadoUsuario in dadoUsuario) {
                    dgvDadosUsuarios.Rows.Add(
                        dadoUsuario.dadoUsuario,
                        false,
                        dadoUsuario.descricao,
                        dadoUsuario.abertura,
                        dadoUsuario.aberturaSecundaria,
                        dadoUsuario.contaDebito,
                        dadoUsuario.contaCredito
                    );
                }

                Cursor.Current = Cursors.Default;
            }
        }
    }
}