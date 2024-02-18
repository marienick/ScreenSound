using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registro de albuns:");
            Console.Write("Digite a banda cujo o álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Digite o nome do álbum: ");
                string nomeDoAlbum = Console.ReadLine()!;
                Album album = new Album(nomeDoAlbum, nomeDaBanda);
                banda.AdicionarAlbum(album);
                Console.WriteLine($"O álbum {nomeDoAlbum} foi registrado para banda {nomeDaBanda}!");
            }
            else
            {
                Console.WriteLine("Essa banda não está em nossos registros.");
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
