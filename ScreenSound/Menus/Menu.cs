

using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    class Menu
    {
        public void ExibirTitulo(string titulo)
        {
            string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
        }
    }
}
