

namespace ScreenSound.Modelos
{
    // A classe banda implementa a interface avaliável
    internal class Banda : IAvaliavel
    {
        public List<Album> albuns = new List<Album>();
        //Pra quê que isso serve?
        public IEnumerable<Album> Albuns => albuns;
        private List<AvaliacaoMusica> notas = new List<AvaliacaoMusica>();
        public Banda(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }

        // ctrl + k + c : comenta todo código selecionado.
        // ctrl + k + u : descomenta todo código selecionado.

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
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
