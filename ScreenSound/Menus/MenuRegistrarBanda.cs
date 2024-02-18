using ScreenSound.Modelos;


namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda :Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registro de bandas");
            Console.Write("Digite o nome da banda que você deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine($"\nERRO!\nO nome {nomeDaBanda} já está no nosso sistema.");
            }
            else
            {
                Banda banda = new(nomeDaBanda);
                bandasRegistradas.Add(nomeDaBanda, banda);
                Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
