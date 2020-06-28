using System;
using System.Collections.Generic;
using nsAccountTools.Utils;
using Npgsql;

namespace nsAccountTools.DAO
{
    class DadoUsuario
    {
        public string dadoUsuario = "";
        public string descricao = "";
        public string abertura = "";
        public string aberturaSecundaria = "";
        public string contaDebito = "";
        public string contaCredito = "";
    }
    class DadosUsuarios
    {
        NpgsqlDataReader reader;
        NpgsqlCommand command = new NpgsqlCommand();
        NpgsqlConnection connection = new NpgsqlConnection();

        public Error GetDadosUsuarios(string _connString, string _whereClause, ref List<DadoUsuario> _dadoUsuarios)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            if (_dadoUsuarios == null)
            {
                _dadoUsuarios = new List<DadoUsuario>();
            }

            try
            {
                connection.ConnectionString = _connString;

                command.Connection = connection;
                command.CommandText = "SELECT id, descricao_lancamento_rubrica AS descricao, abertura, abertura_secundaria, contadebito, contacredito ";
                command.CommandText += "FROM contabilizacao.vw_dadosusuarios_empresas WHERE " + _whereClause;

                connection.OpenAsync();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString() != "")
                    {
                        DadoUsuario dado = new DadoUsuario();
                        dado.dadoUsuario = "'" + reader["id"].ToString() + "'";
                        dado.descricao = reader["descricao"].ToString();
                        dado.abertura = reader["abertura"].ToString();
                        dado.aberturaSecundaria = reader["abertura_secundaria"].ToString();
                        dado.contaDebito = reader["contadebito"].ToString();
                        dado.contaCredito = reader["contacredito"].ToString();

                        _dadoUsuarios.Add(dado);
                    }
                }
            } catch (NpgsqlException ex)
            {
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.CloseAsync();
                }

                return error;
            } catch (Exception ex)
            {
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.CloseAsync();
                }

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