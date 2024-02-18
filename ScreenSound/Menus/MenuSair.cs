
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Obrigada por usar o Screen Sound :)");
        }

    }
}
