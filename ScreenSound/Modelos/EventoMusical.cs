
namespace ScreenSound.Modelos
{
    internal class EventoMusical
    {
        public string Nome {  get; set; }
        public DateTime Data {  get; set; }
        public List<Artista> artistasDoEvento = new List<Artista>();

        public EventoMusical(string nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }
        public void AdicionarArtistasAoEvento(Artista artista)
        {
            artistasDoEvento.Add(artista);
        }
    }
}
