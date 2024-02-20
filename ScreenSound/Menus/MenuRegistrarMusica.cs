using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarMusica:Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registrar Música:");
            Console.WriteLine("Digite o nome da banda:");
            string nomeDaBanda = Console.ReadLine()!;
            if(bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Digite o nome do álbum:");
                string nomeDoAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                if(banda.albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = banda.albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.WriteLine("Agora digite o nome da música que você deseja registrar:");
                    string nomeDaMusica = Console.ReadLine()!;
                    Console.WriteLine("Digite o tempo em minutos dessa música:");
                    int duracao = int.Parse(Console.ReadLine()!);
                    Musica musica = new(nomeDaMusica,banda, duracao);
                    album.AdicionarMusicas(musica);
                    Console.WriteLine($"A música {nomeDaMusica} foi registrada com sucesso no álbum {nomeDoAlbum}!");
                }
                else
                {
                    Console.WriteLine($"O album  {nomeDoAlbum} não está registrado na banda {nomeDaBanda}.");
                }
            }
            else
            {
                Console.WriteLine($"A banda {nomeDaBanda} não está em nossos registros.");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
