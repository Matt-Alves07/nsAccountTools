using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public bool financas = false;
        public bool persona = false;
        public bool scritta = false;
    }

    class capitulos
    {
        public string capitulo = "";
        public string descricao = "";
    }

    class capitulosTags
    {
        public string descricao = "";
        public string tag = "";
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
                        gruposEmpresariais.descricao = reader["descricao"].ToString().ToUpper();

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
                        empresa.razaosocial = reader["razaosocial"].ToString().ToUpper();

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

        public Error GetEstabelecimentos(string _connString, string _empresa, ref List<estabelecimentos> _estabelecimentos)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_estabelecimentos == null)
            {
                _estabelecimentos = new List<estabelecimentos>();
            }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT estabelecimento, codigo, COALESCE(descricao, nomefantasia) AS descricao FROM ns.estabelecimentos ";
                command.CommandText += $"WHERE empresa = {_empresa} ORDER BY codigo;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["estabelecimento"].ToString() != "")
                    {
                        estabelecimentos estabelecimento = new estabelecimentos();
                        estabelecimento.estabelecimento = "'" + reader["estabelecimento"].ToString() + "'";
                        estabelecimento.codigo = reader["codigo"].ToString();
                        estabelecimento.descricao = reader["descricao"].ToString().ToUpper();

                        _estabelecimentos.Add(estabelecimento);
                    }
                }
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

        public Error GetContabilizacoes(
            string _connString,
            string _tipo,
            string _estabelecimento,
            string _dataInicio,
            string _dataFinal,
            ref string _processamentoFato,
            ref List<string> _contabilizacoes
        ) {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_contabilizacoes == null)
            {
                _contabilizacoes = new List<string>();
            }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT c.contabilizacao FROM contabilizacao.contabilizacoes c ";
                command.CommandText += "JOIN contabilizacao.sumario_contabilizacoes sc ON c.contabilizacao = sc.contabilizacao ";
                command.CommandText += $"WHERE c.estabelecimento = {_estabelecimento} AND c.chavepersona ILIKE '{_tipo}%' ";
                command.CommandText += $"AND sc.data BETWEEN '{_dataInicio}'::DATE AND '{_dataFinal}'::DATE ";
                command.CommandText += "AND NOT(c.processado) AND c.persona;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["contabilizacao"].ToString() != "")
                    {
                        string contabilizacao = "'" + reader["contabilizacao"].ToString() + "'";

                        _contabilizacoes.Add(contabilizacao);
                    }
                }

                if (_contabilizacoes.Count > 0)
                {
                    connection.CloseAsync();

                    connection.OpenAsync();

                    command.CommandText = "";
                    command.CommandText += "INSERT INTO contabilizacao.processamentosfatos(total, status, processamento, data_inicial, data_final) ";
                    command.CommandText += $"VALUES({_contabilizacoes.Count()}, 1, (SELECT CLOCK_TIMESTAMP()), '{_dataInicio}'::DATE, '{_dataFinal}'::DATE) ";
                    command.CommandText += "RETURNING processamentofato;";

                    _processamentoFato = "'" + command.ExecuteScalar().ToString() + "'";
                }
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

        public Error Contabilizar(string _connString, string _contabilizacao, ref bool _contabilizado, ref string _processamentoFato)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = $"SELECT contabilizacao.contabilizar({_contabilizacao}) AS done;";

                connection.OpenAsync();

                _contabilizado = Convert.ToBoolean(command.ExecuteScalar().ToString());

                if (_contabilizado)
                {
                    connection.CloseAsync();

                    connection.OpenAsync();

                    command.CommandText = "";
                    command.CommandText = $"SELECT processamentofato FROM contabilizacao.contabilizacoes WHERE contabilizacao = {_contabilizacao};";

                    _processamentoFato = "'" + command.ExecuteScalar().ToString() + "'";
                }
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

        public Error FinalizarContabilizar(string _connString, string _processamentoFato, string _itens)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = $"UPDATE contabilizacao.lancamentoscontabeis SET processamentofato = {_processamentoFato} WHERE processamentofato IN ({_itens}); ";
                command.CommandText += $"UPDATE contabilizacao.lancamentoscontabilizacao SET processamentofato = {_processamentoFato} WHERE processamentofato IN ({_itens}); ";
                command.CommandText += $"UPDATE contabilizacao.contabilizacoes SET processamentofato = {_processamentoFato} WHERE processamentofato IN ({_itens});";

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

        public Error GetProcessamentoFatos(string _connString, string _estabelecimento, string _tipo, string _dataInicial, string _dataFinal, ref List<string> _processamentoFatos)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_processamentoFatos == null) { _processamentoFatos = new List<string>(); }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT DISTINCT(c.processamentofato) AS processamentofato FROM contabilizacao.contabilizacoes c ";
                command.CommandText += "JOIN contabilizacao.sumario_contabilizacoes sc ON c.contabilizacao = sc.contabilizacao ";
                command.CommandText += $"WHERE c.estabelecimento = {_estabelecimento} AND c.chavepersona ILIKE '{_tipo}%' ";
                command.CommandText += $"AND sc.data BETWEEN '{_dataInicial}'::DATE AND '{_dataFinal}'::DATE ";
                command.CommandText += $"AND c.processado AND c.lote IS NULL AND c.persona AND processamentofato IS NOT NULL;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["processamentofato"].ToString() != "")
                    {
                        string processamentoFato = "'" + reader["processamentofato"].ToString() + "'";

                        _processamentoFatos.Add(processamentoFato);
                    }
                }
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

        public Error ReverteContabilizacao(string _connString, string _estabelecimento, string _processamentoFato, ref bool _revertido)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            try
            {
                connection.ConnectionString = _connString;

                connection.OpenAsync();

                command.Connection = connection;
                command.CommandText = $"SELECT contabilizacao.revertercontabilizacao_diaria({_processamentoFato}, {_estabelecimento}) AS done;";

                _revertido = Convert.ToBoolean(command.ExecuteScalar().ToString());
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

        public Error GetFatosOrigem(string _connString, ref List<fatos> _fatos)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_fatos == null) { _fatos = new List<fatos>(); }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT descricao, financas, persona, scritta FROM contabilizacao.vw_fatos_origem ORDER BY descricao;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["descricao"].ToString() != "")
                    {
                        fatos fato = new fatos();
                        fato.descricao = reader["descricao"].ToString().ToUpper();
                        fato.financas = Convert.ToBoolean(reader["financas"].ToString());
                        fato.persona = Convert.ToBoolean(reader["persona"].ToString());
                        fato.scritta = Convert.ToBoolean(reader["scritta"].ToString());

                        _fatos.Add(fato);
                    }
                }
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

        public Error GetCapitulosTags(string _connString, string _capitulo, ref List<capitulosTags> _capitulosTags)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_capitulosTags == null) { _capitulosTags = new List<capitulosTags>(); }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = $"SELECT descricao, tag FROM contabilizacao.vw_capitulos_tags WHERE descricao = {_capitulo} ORDER BY descricao, tag;";

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["descricao"].ToString() != "")
                    {
                        capitulosTags capitulotag = new capitulosTags();
                        capitulotag.descricao = reader["descricao"].ToString();
                        capitulotag.tag = reader["tag"].ToString();

                        _capitulosTags.Add(capitulotag);
                    }
                }
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
    }
}
