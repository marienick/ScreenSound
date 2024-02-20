using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Avaliar álbum:");
            Console.WriteLine("Digite o nome da banda que você deseja avaliar:");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine("Agora digite o nome do álbum:");
                string nomeDoAlbum = Console.ReadLine()!;   
                //Any: Condição se na lista de albums de uma banda existir algum album que tenha o nome igual à nomeDoAlbum
                if(banda.albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    // First: Pegar o primeiro álbum da banda que tem o nome nomeDoAlbum
                    Album album = banda.albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.WriteLine($"Digite a nota que o álbum {nomeDoAlbum} merece:");
                    AvaliacaoMusica nota = AvaliacaoMusica.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada para o álbum {nomeDoAlbum} com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"ERRO!!!\nEssa banda não possui esse álbum {nomeDoAlbum} registrado.");
                    Console.WriteLine("Digite um tecla para voltar  para o menu principal:");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            else
            {
                Console.WriteLine("ERRO!!!\nEssa banda não está nos nossos registros.");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
