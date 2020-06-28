using System;
using System.Windows.Forms;
using Npgsql;

namespace nsAccountTools.Utils
{
    class Environment
    {
        public static Error ChangeEnviroment(string _connString, string _script)
        {
            Error error = new Error();
            error.SetErro(Error.tipoRetorno.indefinido, "", "");

            NpgsqlConnection connection = new NpgsqlConnection();
            NpgsqlCommand command = new NpgsqlCommand();

            connection.ConnectionString = _connString;
            command.CommandText = _script;
            command.Connection = connection;

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                Messages.SendError($"Ocorreu um erro ao executar os scripts necessários.\nDetalhes(Cód. {ex.ErrorCode.ToString()}): {ex.Message}.", "Erro");
                error.SetErro(Error.tipoRetorno.erro, ex.ErrorCode.ToString(), ex.Message.ToString());
                return error;
            }
            catch (Exception ex)
            {
                Messages.SendError($"Ocorreu um erro.\nDetalhes: {ex.Message}", "Erro");
                error.SetErro(Error.tipoRetorno.erro, "", ex.Message.ToString());
                return error;
            }
            finally
            {
                connection.Close();
            }

            error.SetErro(Error.tipoRetorno.sucesso, "", "");
            return error;
        }
    }
}
