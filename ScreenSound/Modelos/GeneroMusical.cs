

namespace ScreenSound.Modelos
{
    internal class GeneroMusical
    {

        public string Nome { get;}
        public string Descricao { get; set; }
        public List<Musica> musicasAssociadas = new List<Musica>();
        public List<Artista> artistasAssociadas = new List<Artista>();


        public GeneroMusical(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public void AdicionarMusicaAssociadas(Musica musica)
        {
            musicasAssociadas.Add(musica);
        }
        public void RemoverrMusicaAssociadas(Musica musica)
        {
            musicasAssociadas.Remove(musica);
        }
        public void AdicionarArtistaAssociados(Artista artista)
        {
            artistasAssociadas.Add(artista);
        }
        public void RemoverrArtistaAssociados(Artista artista)
        {
            artistasAssociadas.Remove(artista);
        }

    }
}
