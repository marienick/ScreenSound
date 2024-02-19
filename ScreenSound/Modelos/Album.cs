

namespace ScreenSound.Modelos
{
    // Aperta ctrl + . para implementar a interface e depois corrige os erros
    internal class Album : IAvaliavel
    {
        private List<Musica> AlbumDeMusicas = new();
        private List<AvaliacaoMusica> notas = new();
        public string Nome { get; }
        public string Artista { get; set; }
        public int DuracaoTotal => AlbumDeMusicas.Sum(m => m.Duracao);

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }

        public static int ContadorDeObjetos = 0;

        public Album(string nome, string artista)
        {
            Nome = nome;
            Artista = artista;
            ContadorDeObjetos++;
        }

        public void AdicionarMusicas(Musica musica)
        {
            AlbumDeMusicas.Add(musica);
        }
        public void RemoverMusicas(Musica musica)
        {
            AlbumDeMusicas.Remove(musica);
           
        }
        public void ExibirMusicas()
        {
            int i = 1;
            foreach(var musica in AlbumDeMusicas)
            {
                Console.WriteLine($"Música {i}: {musica.Nome}");
            }
            Console.WriteLine($"\nPara ouvir este álbum inteiro é necessário {DuracaoTotal} minutos.");
        }

        public void AdicionarNota(AvaliacaoMusica nota)
        {
            notas.Add(nota);
        }
    }
}
