

namespace ScreenSound.Modelos
{
    internal class Banda
    {
        private List<Album> albuns = new List<Album>();
        private List<AvaliacaoMusica> notas = new List<AvaliacaoMusica>();
        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return  notas.Average(a => a.Nota);
            }
        }

        public string Nome { get; }

        public Banda(string nome)
        {
            Nome = nome;
        }
        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }
        public void RemoverAlbum(Album album)
        {
            albuns.Remove(album);
        }
        public void AdicionarNota(AvaliacaoMusica avaliacaoMusica)
        {
            notas.Add(avaliacaoMusica);
        }
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in albuns)
            {
                Console.WriteLine($"{album.Nome}");
            }
        }
    }
}
