namespace ScreenSound.Modelos
{
    class Podcast
    {
        public string Nome { get; }
        public string Host {  get; }
        private List<Episodio> episodiosPodcast = new List<Episodio>();
        public int TotalEpisodios => episodiosPodcast.Count;

        public Podcast(string host, string nome, int totalEpisodios)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodiosPodcast.Add(episodio);
        }
        public void RemoverEpisodio(Episodio episodio)
        {
            episodiosPodcast.Remove(episodio);
        }
        public void ExibbirFichaTecnica()
        {
            Console.WriteLine($"Podcast: {Nome} apresentado por {Host}\nLista de episódios:");
            foreach (Episodio episodios in episodiosPodcast.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"{episodios.Ordem}- {episodios.Resumo}");
            }
            Console.WriteLine($"Esse podcast possui {TotalEpisodios} eposódios");
        }
    }
}
