using System;
using System.Collections.Generic;
using System.Linq;
using nsAccountTools.Utils;
using nsAccountTools.DAO;
using System.Windows.Forms;

namespace nsAccountTools.Views
{
    public partial class frmLIstas : Form
    {
        string connString = "";
        Error error = new Error();
        DadosBase dadosBase = new DadosBase();

        //Lista de fatos, capítulos e capítulos/tags
        List<fatos> fatos = new List<fatos>();
        List<capitulos> capitulos = new List<capitulos>();
        List<capitulosTags> capitulosTags = new List<capitulosTags>();
        public frmLIstas(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void Clear(bool _fato = true, bool _capitulo = true, bool _listaFatosOrigem = true, bool _listaCapitulosTags = true)
        {
            if (_fato)
            {
                cbbFatos.Items.Clear();
                cbbFatos.Text = "<SELECIONE>";
                lblFatos.Text = "<SELECIONE>";
                cbbFatos.Items.Add("<SELECIONE>");
            }

            if (_capitulo)
            {
                cbbCapitulo.Items.Clear();
                cbbCapitulo.Text = "<SELECIONE>";
                lblCapitulos.Text = "<SELECIONE>";
                cbbCapitulo.Items.Add("<SELECIONE>");
            }

            if (_listaFatosOrigem)
            {
                dgvFatosOrigem.Rows.Clear();
            }

            if (_listaCapitulosTags)
            {
                dgvCapitulosTags.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLIstas_Shown(object sender, EventArgs e)
        {
            Clear();
            
            error = dadosBase.GetFatosOrigem(connString, ref fatos);
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
                foreach (fatos fato in fatos)
                {
                    dgvFatosOrigem.Rows.Add(fato.descricao, fato.financas, fato.persona, fato.scritta);
                }
            }

            if (fatos.Count() > 0)
            {
                fatos.Clear();
            }

            error = dadosBase.GetFatos(connString, ref fatos);
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
                foreach (fatos fato in fatos)
                {
                    cbbFatos.Items.Add(fato.descricao);
                }
            }
        }

        private void cbbFatos_SelectedValueChanged(object sender, EventArgs e)
        {
            Clear(false, true, false);
            string descricao = "";
            if ((cbbFatos.Text == "") || (cbbFatos.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                string objeto = "";
                foreach (fatos fato in fatos)
                {
                    if (fato.descricao == cbbFatos.Text)
                    {
                        objeto = fato.objeto;
                        descricao = fato.descricao;
                        break;
                    }
                }

                if (capitulos.Count > 0) { capitulos.Clear(); }

                error = dadosBase.GetCapitulos(connString, objeto, ref capitulos);
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
                    foreach (capitulos capitulo in capitulos)
                    {
                        cbbCapitulo.Items.Add(capitulo.descricao);
                    }
                }
            }

            lblFatos.Text = descricao;
        }

        private void cbbCapitulo_SelectedValueChanged(object sender, EventArgs e)
        {
            Clear(false, false, false);
            string descricao = "";
            if ((cbbCapitulo.Text == "") || (cbbCapitulo.Text == "<SELECIONE>"))
            {
                descricao = "<SELECIONE>";
            } else
            {
                descricao = cbbCapitulo.Text;
                if (capitulosTags.Count > 0) { capitulosTags.Clear(); }

                error = dadosBase.GetCapitulosTags(connString, "'" + descricao + "'", ref capitulosTags);
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
                    foreach (capitulosTags capituloTag in capitulosTags)
                    {
                        dgvCapitulosTags.Rows.Add(capituloTag.descricao, capituloTag.tag);
                    }
                }
            }

            lblCapitulos.Text = descricao;
        }
    }
}
