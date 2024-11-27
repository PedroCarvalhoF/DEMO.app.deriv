namespace DEMO.app.deriv.services.Tokens
{
    public static class Tokens
    {
        public static DefinicoesToken GetTokenLeitura()
             => DefinicoesToken.Leitura("Demo_temp_token", "***********g6kX", Ambito.Read, "Nunca");
    }

    public class DefinicoesToken
    {
        public string Nome { get; private set; }
        public string Token { get; private set; }
        public Ambito Ambito { get; private set; }
        public string UtimaAtualizacao { get; private set; }
        DefinicoesToken(string nome, string token, Ambito ambito, string utimaAtualizacao)
        {
            Nome = nome;
            Token = token;
            Ambito = ambito;
            UtimaAtualizacao = utimaAtualizacao;
        }

        public static DefinicoesToken Leitura(string nome, string token, Ambito ambito, string utimaAtualizacao)
            => new DefinicoesToken(nome, token, ambito, utimaAtualizacao);
    }
    public enum Ambito
    {
        Admin, Read, Trade
    }
}
