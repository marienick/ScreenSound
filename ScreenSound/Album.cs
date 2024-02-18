

namespace ScreenSound
{
    class Album
    {
        List<Musica> AlbumDeMusicas = new List<Musica>();
        public string Nome { get; }
        public string Artista { get; set; }
        public int DuracaoTotal => AlbumDeMusicas.Sum(m => m.Duracao);
    
        public Album(string nome, string artista)
        {
            Nome = nome;
            Artista = artista;
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
        
    }
}
