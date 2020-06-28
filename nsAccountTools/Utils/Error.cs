namespace nsAccountTools.Utils
{
    class Error
    {
        public enum tipoRetorno
        {
            indefinido,
            sucesso,
            erro
        }

        public tipoRetorno retorno;
        public string codigo = "";
        public string mensagem = "";

        public void SetErro(tipoRetorno _tipoRetorno, string _codigo, string _mensagem)
        {
            retorno = _tipoRetorno;
            codigo = _codigo;
            mensagem = _codigo;
        }

        public string GetCodigo() => codigo;
        public string GetMensagem() => mensagem;
    }
}
