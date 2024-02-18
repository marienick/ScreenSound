
namespace ScreenSound.Modelos
{
    internal class Musica
    {
        public string Nome {  get;  }
        public Banda Artista {  get; set; }
        public int Duracao { get; set; }
        private bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public LetraMusica Letra { get; }
        public Musica(string nome, Banda artista, int duracao, bool disponivel, Genero genero)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
            Disponivel = disponivel;
            Genero = genero;
        }
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"´Nome: {Nome}\nArtista: {Artista}\nDuração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }
        public override string ToString()
        {
            return $"´Nome: {Nome}\nArtista: {Artista}";
        }

    }
}
