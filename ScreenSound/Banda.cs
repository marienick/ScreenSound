

namespace ScreenSound
{
    class Banda
    {
        private List<Album> albuns = new List<Album>();
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
