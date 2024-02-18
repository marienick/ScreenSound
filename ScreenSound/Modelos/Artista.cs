

namespace ScreenSound.Modelos
{
    internal class Artista
    {
        public string Nome {  get; }
        public string Biografia { get; set; }
        List <Album> listaDeAlbuns { get; set; }
        public Artista(string nome, string biografia)
        {
            Nome = nome;
            Biografia = biografia;
        }
        public void AdicionarAlbumDaPlaylist(Album album)
        {
            listaDeAlbuns.Add(album);
        }
        public void RemoverrAlbumDaPlaylist(Album album)
        {
            listaDeAlbuns.Remove(album);
        }
    }
}
