using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirDetalhesAlbum: Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Exibir músicas do álbum:");
            Console.WriteLine("Digite o nome da banda que você deseja exibir os detalhes:");
            string nomeDaBanda = Console.ReadLine()!;
            if(bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Agora digite o nome do album que você deseja exibir os detalhes:");
                string nomeDoAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                if(banda.albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = banda.albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.WriteLine($"\nNome do álbum: {nomeDaBanda}\nMédia de notas: {album.Media}");
                }
                else
                {
                    Console.WriteLine($"\nInfelizmente o álbum {nomeDaBanda} não existe nos na discografia da banda {nomeDaBanda}:");
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
