using System;
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
        }

        public bool IsValid()
        {
            string caption = "Campo vazio";
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

            } else
            {
                return true;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            //string fileAdress = @"\Scripts\CreateScript.txt";
            string script = "";
            script = "DROP VIEW IF EXISTS contabilizacao.vw_dadosusuarios_empresas; ";
            script += "CREATE OR REPLACE VIEW contabilizacao.vw_dadosusuarios_empresas AS ";
            script += "SELECT ";
            script += " dd.dadousuario AS id, ";
            script += " COALESCE(e.nome, dl.descricao) AS descricao_lancamento_rubrica, ";
            script += " opp.descricao AS abertura, ";
            script += " COALESCE(ops.descricao, 'CONTA FIXA') AS abertura_secundaria, ";
            script += " dd.contadebito, ";
            script += " dd.contacredito, ";
            script += " dd.empresa AS empresa, ";
            script += " o.objeto AS fato, ";
            script += " o.descricao AS descricao_fato, ";
            script += " dc.dicionariocapitulo AS capitulo, ";
            script += " dc.descricao AS descrica_capitulo ";
            script += "FROM        contabilizacao.dadosusuarios AS dd ";
            script += "JOIN        contabilizacao.opcoes AS opp ON dd.opcao = opp.opcao ";
            script += "LEFT JOIN   contabilizacao.opcoes AS ops ON dd.opcaosecundaria = ops.opcao ";
            script += "LEFT JOIN   contabilizacao.lancamentosfatos AS lf ON lf.lancamentofato = dd.lancamentofato ";
            script += "LEFT JOIN   contabilizacao.dicionariolancamentos AS dl ON lf.dicionariolancamento = dl.dicionariolancamento ";
            script += "LEFT JOIN   contabilizacao.contabilizacaorubricas AS cr ON dd.contabilizacaorubrica = cr.contabilizacaorubrica ";
            script += "LEFT JOIN   persona.eventos AS e ON cr.rubrica = e.evento ";
            script += "LEFT JOIN   contabilizacao.dicionariocapitulos AS dc ON CASE WHEN dd.contabilizacaorubrica IS NOT NULL THEN cr.dicionariocapitulo = dc.dicionariocapitulo ELSE dl.dicionariocapitulo = dc.dicionariocapitulo END ";
            script += "LEFT JOIN contabilizacao.objetodicionariocapitulos AS odc ON odc.dicionariocapitulo = dc.dicionariocapitulo ";
            script += "LEFT JOIN   contabilizacao.objetos AS o ON o.objeto = odc.objeto; ";

            script += "DROP VIEW IF EXISTS contabilizacao.vw_objetoscapitulos_descricao; ";
            script += "CREATE OR REPLACE VIEW contabilizacao.vw_objetoscapitulos_descricao AS ";
            script += "SELECT ";
            script += " o.objeto AS fato, ";
            script += " dc.dicionariocapitulo AS capitulo, ";
            script += " dc.descricao AS descricao ";
            script += "FROM        contabilizacao.objetos AS o ";
            script += "JOIN        contabilizacao.objetodicionariocapitulos AS odc ON o.objeto = odc.objeto ";
            script += "JOIN contabilizacao.dicionariocapitulos AS dc ON odc.dicionariocapitulo = dc.dicionariocapitulo ";
            script += "ORDER BY    o.descricao, dc.descricao; ";

            script += "DROP VIEW IF EXISTS contabilizacao.vw_lancamentosfatos_capitulo_empresa; ";
            script += "CREATE OR REPLACE VIEW contabilizacao.vw_lancamentosfatos_capitulo_empresa AS ";
            script += "SELECT ";
            script += " lf.lancamentofato, ";
            script += " dl.dicionariocapitulo AS capitulo, ";
            script += " f.empresa ";
            script += "FROM    contabilizacao.lancamentosfatos lf ";
            script += "JOIN contabilizacao.fatos f ON lf.fato = f.fato ";
            script += "JOIN contabilizacao.dicionariolancamentos dl ON lf.dicionariolancamento = dl.dicionariolancamento; ";

            script += "DROP VIEW IF EXISTS contabilizacao.vw_fatos_origem; ";
            script += "CREATE OR REPLACE VIEW contabilizacao.vw_fatos_origem AS ";
            script += "SELECT ";
            script += " DISTINCT(o.descricao) AS descricao, ";
            script += " CASE WHEN df.financas THEN TRUE ELSE FALSE END AS financas, ";
            script += " CASE WHEN df.persona THEN TRUE ELSE FALSE END AS persona, ";
            script += " CASE WHEN(df.scritta OR df.estoque OR df.servicos) THEN TRUE ELSE FALSE END AS scritta ";
            script += "FROM    contabilizacao.objetos o ";
            script += "JOIN contabilizacao.objetodicionariocapitulos odc ON o.objeto = odc.objeto ";
            script += "JOIN contabilizacao.dicionariocapitulos dc ON odc.dicionariocapitulo = dc.dicionariocapitulo ";
            script += "JOIN contabilizacao.dicionariofatos df ON dc.dicionariofato = df.dicionariofato ";
            script += "ORDER BY o.descricao; ";

            script += "DROP VIEW IF EXISTS contabilizacao.vw_capitulos_tags; ";
            script += "CREATE OR REPLACE VIEW contabilizacao.vw_capitulos_tags AS ";
            script += "SELECT ";
            script += " dc.descricao AS descricao, ";
            script += " '<#' || ct.tag || '>' AS tag ";
            script += "FROM contabilizacao.dicionariocapitulos dc ";
            script += "JOIN contabilizacao.capitulostags ct ON dc.dicionariocapitulo = ct.capitulo ";
            script += "GROUP BY dc.descricao, ct.tag ";
            script += "ORDER BY dc.descricao, ct.tag; ";

            if (IsValid())
            {
                Error error = new Error();

                string connString = string.Format(
                    "Server={0};Port={1};User Id={2};Password={3};Database={4}",
                    txtHost.Text, txtPort.Text, txtUser.Text, txtPass.Text, txtDatabase.Text
                );

                pgbCreate.Increment(25);

                /*if (File.Exists(fileAdress))
                {*/
                    Cursor.Current = Cursors.WaitCursor;

                    pgbCreate.Increment(50);

                    //script = File.ReadAllText(fileAdress);
                    script = script.Replace("\r", " ");
                    script = script.Replace("\n", " ");
                    script = script.Replace("\t", " ");

                    pgbCreate.Increment(75);

                    error = Utils.Environment.ChangeEnviroment(connString, script);

                    Cursor.Current = Cursors.Default;

                    if (error.retorno == Error.tipoRetorno.sucesso)
                    {
                        pgbCreate.Increment(100);
                        pgbCreate.Visible = false;

                        frmMenuPrincipal frm = new frmMenuPrincipal(connString);
                        this.Hide();
                        frm.Show();
                    } else
                    {
                        pgbCreate.Increment(0);
                        pgbCreate.Visible = false;
                    }
                //}
            }
        }
    }
}
