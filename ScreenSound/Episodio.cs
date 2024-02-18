

namespace ScreenSound
{
    class Episodio
    {
        public string Nome { get; }
        public int Duracao { get; }
        public string Transcricao { get; }
        public string Descricao { get; }

        public Episodio(string nome, int duracao, string transcricao, string descricao)
        {
            Nome = nome;
            Duracao = duracao;
            Transcricao = transcricao;
            Descricao = descricao;
        }
    }
}
