using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using nsAccountTools.Utils;

namespace nsAccountTools.DAO
{
    //CLASSE RESPONSÁVEL POR TRAZER AS INFORMAÇÕES DE GRUPOS EMPRESARIAIS,
    //EMPRESAS E ESTABELECIMENTOS, CHAMADA DESSA FORMA POIS SÃO AS INFORMAÇÕES
    //BÁSICAS PARA O FUNCIONAMENTO DE PARTE DO SISTEMA
    class gruposEmpresariais
    {
        public string grupoEmpresarial = "";
        public string codigo = "";
        public string descricao = "";
    }

    class empresas
    {
        public string empresa = "";
        public string codigo = "";
        public string razaosocial = "";
    }

    class estabelecimentos
    {
        public string estabelecimento = "";
        public string codigo = "";
        public string descricao = "";
    }

    class fatos
    {
        public string objeto = "";
        public string descricao = "";
    }

    class capitulos
    {
        public string capitulo = "";
        public string descricao = "";
    }

    class DadosBase
    {
        NpgsqlDataReader reader;
        NpgsqlCommand command = new NpgsqlCommand();
        NpgsqlConnection connection = new NpgsqlConnection();

        public Error GetGruposEmpresariais(string _connstring, ref List<gruposEmpresariais> _gruposempresariais)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_gruposempresariais == null)
            {
                _gruposempresariais = new List<gruposEmpresariais>();
            }

            try
            {
                connection.ConnectionString = _connstring;

                command.Connection = connection;
                command.CommandText = "SELECT grupoempresarial, codigo, descricao FROM ns.gruposempresariais ORDER BY codigo;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["grupoempresarial"].ToString() != "")
                    {
                        gruposEmpresariais gruposEmpresariais = new gruposEmpresariais();
                        gruposEmpresariais.grupoEmpresarial = "'" + reader["grupoempresarial"].ToString() + "'";
                        gruposEmpresariais.codigo = reader["codigo"].ToString();
                        gruposEmpresariais.descricao = reader["descricao"].ToString();

                        _gruposempresariais.Add(gruposEmpresariais);
                    }
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.retorno = Error.tipoRetorno.sucesso;
            return error;
        }

        public Error GetEmpresas(string _connString, string _grupo, ref List<empresas> _empresas)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_empresas == null)
            {
                _empresas = new List<empresas>();
            }
            
            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT empresa, codigo, COALESCE(descricao, razaosocial) AS razaosocial ";
                command.CommandText += "FROM ns.empresas WHERE grupoempresarial = " + _grupo + " ORDER BY codigo;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["empresa"].ToString() != "")
                    {
                        empresas empresa = new empresas();
                        empresa.empresa = "'" + reader["empresa"].ToString() + "'";
                        empresa.codigo = reader["codigo"].ToString();
                        empresa.razaosocial = reader["razaosocial"].ToString();

                        _empresas.Add(empresa);
                    }
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.retorno = Error.tipoRetorno.sucesso;
            return error;
        }

        public Error GetFatos(string _connString, ref List<fatos> _fatos)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_fatos == null)
            {
                _fatos = new List<fatos>();
            }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT objeto, descricao FROM contabilizacao.objetos ORDER BY descricao;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["objeto"].ToString() != "")
                    {
                        fatos fato = new fatos();
                        fato.objeto = "'" + reader["objeto"].ToString() + "'";
                        fato.descricao = reader["descricao"].ToString().ToUpper();

                        _fatos.Add(fato);
                    }
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.SetErro(Error.tipoRetorno.sucesso, "", "");
            return error;
        }

        public Error GetCapitulos(string _connString, string _fato, ref List<capitulos> _capitulos)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_capitulos == null)
            {
                _capitulos = new List<capitulos>();
            }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT capitulo, descricao FROM contabilizacao.vw_objetoscapitulos_descricao ";
                command.CommandText += "WHERE fato = " + _fato + " ORDER BY descricao;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["capitulo"].ToString() != "")
                    {
                        capitulos capitulo = new capitulos();
                        capitulo.capitulo = "'" + reader["capitulo"].ToString() + "'";
                        capitulo.descricao = reader["descricao"].ToString().ToUpper();

                        _capitulos.Add(capitulo);
                    } 
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.SetErro(Error.tipoRetorno.sucesso, "", "");
            return error;
        }

        public Error GetQuantidadeLancamentos(string _connString, string _empresa, string _capitulo, bool _lancamento, ref int _total)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                if (_lancamento)
                {
                    command.CommandText = "SELECT COUNT(*) AS total FROM contabilizacao.vw_lancamentosfatos_capitulo_empresa ";
                    command.CommandText += $"WHERE empresa = {_empresa} AND capitulo = {_capitulo};";
                } else
                {
                    command.CommandText = "SELECT COUNT(*) AS total FROM contabilizacao.contabilizacaorubricas ";
                    command.CommandText += $"WHERE empresa = {_empresa} AND dicionariocapitulo = {_capitulo};";
                }

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["total"].ToString() != "")
                    {
                        _total = Convert.ToInt32(reader["total"].ToString());
                    } else
                    {
                        _total = 0;
                    }
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.SetErro(Error.tipoRetorno.sucesso, "", "");
            return error;
        }

        public Error UpdateHistorico(string _connString, string _empresa, string _capitulo, string _historico, bool _lancamentos = true)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                if (_lancamentos)
                {
                    command.CommandText = "WITH lista_lancamentos AS (SELECT lancamentofato lancamentos FROM contabilizacao.vw_lancamentosfatos_capitulo_empresa ";
                    command.CommandText += $"WHERE empresa ={_empresa} AND capitulo = {_capitulo})";
                    command.CommandText += $"UPDATE contabilizacao.lancamentosfatos SET historico = '{_historico}' WHERE lancamentofato IN (SELECT lancamentos FROM lista_lancamentos);";
                } else
                {
                    command.CommandText = $"UPDATE contabilizacao.contabilizacaorubricas SET historico = '{_historico}' WHERE empresa = {_empresa} AND dicionariocapitulo = {_capitulo};";
                }

                connection.OpenAsync();

                command.ExecuteNonQuery();
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message);
                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message);
                return error;
            } finally
            {
                connection.CloseAsync();
            }

            error.SetErro(Error.tipoRetorno.sucesso, "", "");
            return error;
        }

        //RETORNA A LISTA DE ESTABELECIMENTOS EXISTENTES NA CONEXÃO PREENCHIDA
        //NA TELA INICIAL, A PARTIR DE UM GRUPO E UMA EMPRESA, DENTRO DESSE GRUPO
        public List<string> GetEstabelecimentos(string _connString, string _grupo, string _empresa)
        {
            List<string> codigos = new List<string>();
            codigos.Clear();

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT codigo_estabelecimento FROM contabilizacao.vw_dadosbase WHERE codigo_grupo = '@grupo' AND codigo_empresa = '@empresa' ORDER BY codigo_estabelecimento;";
                command.Parameters.AddWithValue("@grupo", _grupo);
                command.Parameters.AddWithValue("@empresa", _empresa);

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(!(reader.GetString(0).ToString() == ""))
                    {
                        codigos.Add(reader.GetString(0).ToString());
                    }
                }
            } catch (NpgsqlException ex)
            {
                Messages.SendError("Ocorreu um erro ao acessar o banco de dados.\nDetalhes: " + ex.Message.ToString(), "Erro");
            } catch (Exception ex)
            {
                Messages.SendError("Ocorreu um erro. Detalhes: " + ex.Message.ToString(), "Erro");
            } finally
            {
                connection.CloseAsync();
            }

            return codigos;
        }

        //RETORNA O NOME DO ESTABELECIMENTO SELECIONADO NO COMBO
        public string GetNomeEstabelecimento(string _connString, string _grupo, string _empresa, string _codigo)
        {
            string retorno = "";

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT nome_estabelecimento FROM contabilizacao.vw_dadosbase WHERE codigo_grupo = '@grupo' AND codigo_empresa = '@empresa' ";
                command.CommandText = command.CommandText + "AND codigo_estabelecimento = '@codigo';";
                command.Parameters.AddWithValue("@grupo", _grupo);
                command.Parameters.AddWithValue("@empresa", _empresa);
                command.Parameters.AddWithValue("@codigo", _codigo);

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!(reader.GetString(0).ToString() == ""))
                    {
                        retorno = reader.GetString(0).ToString().ToUpper();
                    } else
                    {
                        retorno = "<NÃO ENCONTRADO>";
                    }
                }
            } catch (NpgsqlException ex)
            {
                Messages.SendError("Ocorreu um erro ao acessar o banco de dados.\nDetalhes: " + ex.Message.ToString(), "Erro");
            } catch (Exception ex)
            {
                Messages.SendError("Ocorreu um erro. Detalhes: " + ex.Message.ToString(), "Erro");
            } finally
            {
                connection.CloseAsync();
            }

            return retorno;
        }
    }
}
