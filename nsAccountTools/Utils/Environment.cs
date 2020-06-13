using System;
using System.Windows.Forms;
using Npgsql;

namespace nsAccountTools.Utils
{
    class Environment
    {
        public static void ChangeEnviroment(string _connString, string _script)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            NpgsqlCommand command = new NpgsqlCommand();

            connection.ConnectionString = _connString;
            command.CommandText = _script;
            command.Connection = connection;

            try
            {
                connection.Open();

                command.ExecuteNonQueryAsync();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao executar os scripts necessários. Detalhes: " + e.Message.ToString(),
                    "Erro ao alterar o banco",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                connection.Close();
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Ocorreu um erro. Detalhes: " + e.Message.ToString(),
                    "Erro ao alterar o banco",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                connection.Close();
                return;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
