using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirTodasAsBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Lista de bandas registradas");
            int i = 1;
            foreach (string nomeBanda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda {i}: {nomeBanda}");
                i++;
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
        }

    }
}
