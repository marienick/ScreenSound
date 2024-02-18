

namespace ScreenSound.Modelos
{
    internal class Playlist
    {
        public string OrdemOuTema {  get; set; }
        public List<Musica> playlistDeMusicas = new List<Musica>();

        public Playlist(string ordemOuTema)
        {
            OrdemOuTema = ordemOuTema;
        }
        public void AdicionarMusicaDaPlaylist(Musica musica)
        {
            playlistDeMusicas.Add(musica);
        }
        public void RemoverMusicaDaPlaylist(Musica musica)
        {
            playlistDeMusicas.Remove(musica);
        }
    }
}
