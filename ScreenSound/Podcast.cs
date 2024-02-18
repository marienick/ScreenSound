
namespace ScreenSound
{
    class Podcast
    {
        public List<Episodio> episodiosPodcast = new List<Episodio>();
        public void AdicionarEpisodio(Episodio episodio)
        {
            episodiosPodcast.Add(episodio);
        }
        public void RemoverEpisodio(Episodio episodio)
        {
            episodiosPodcast.Remove(episodio);
        }
    }
}
