
namespace ScreenSound.Modelos
{
    internal class Musica : IAvaliavel
    {
        public string Nome {  get;  }
        public Banda Artista {  get; set; }
        public int Duracao { get; set; }
        private bool Disponivel { get; set; }

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else
                {
                    return notas.Average(n => n.Nota);
                }
            }
        }

        public List<AvaliacaoMusica> notas = new List<AvaliacaoMusica>();
        //public Genero Genero { get; set; }
        //public LetraMusica Letra { get; }
        public Musica(string nome, Banda artista, int duracao)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
            //Disponivel = disponivel;
            //Genero = genero;
            //Letra = letra;  
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
        public void AdicionarNota(AvaliacaoMusica nota)
        {
            notas.Add(nota);
        }

    }
}
