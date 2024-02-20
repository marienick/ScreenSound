using ScreenSound.Modelos;


namespace ScreenSound.Menus
{
    internal class MenuAvaliarMusica:Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Avaliar música:");
            Console.WriteLine("Digite o nome da banda:");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Digite o nome do album:");
                string nomeDoAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                if (banda.albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = banda.albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.WriteLine("Agora digite o nome da música:");
                    string nomeDaMusica = Console.ReadLine()!;
                    if (album.AlbumDeMusicas.Any(m => m.Nome.Equals(nomeDaMusica)))
                    {
                        Musica musica = album.AlbumDeMusicas.First(m => m.Nome.Equals(nomeDaMusica));
                        Console.WriteLine("Qual nota a música {nomeDaMusica} merece?");
                        AvaliacaoMusica nota = AvaliacaoMusica.Parse(Console.ReadLine()!);
                        musica.AdicionarNota(nota);
                    }
                    else
                    {
                        Console.WriteLine($"Infelizmente a música {nomeDaMusica} não existe no álbum {nomeDoAlbum}:");
                    }
                }
                else
                {
                    Console.WriteLine($"Infelizmente o álbum {nomeDaBanda} não existe nos na discografia da banda {nomeDaBanda}:");
                }
                
            }
            else
            {
                Console.WriteLine($"Infelizmente a banda {nomeDaBanda} não existe nos nossos registros:");
            }
            Console.WriteLine("Digite um tecla para voltar  para o menu principal:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
