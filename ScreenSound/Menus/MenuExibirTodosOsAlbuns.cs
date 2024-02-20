using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirTodosOsAlbuns: Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Lista de Albuns Registrados:");
            Console.WriteLine("Digite a banda  que você deseja visualizar os álbuns:");
            string nomeDaBanda = Console.ReadLine()!;
            if(bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                foreach(Album nomeDoAlbum in banda.albuns)
                {
                    Console.WriteLine(nomeDoAlbum.Nome); 
                }

            }
            else
            {
                Console.WriteLine("ERRO!!\nEssa banda não está registrada.");
            }
            Console.WriteLine($"\nDigite qualuqer tecla para voltar ao menu principal:");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
