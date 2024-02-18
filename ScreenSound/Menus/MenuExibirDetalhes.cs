using ScreenSound.Modelos;


namespace ScreenSound.Menus
{
    internal class MenuExibirDetalhes : Menu
    {

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Exibir detalhes da banda:");
            Console.WriteLine("Digite o nome da banda que você deseja ver os detalhes:");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"Nome da banda: {nomeDaBanda}\nMédia de notas: {banda.Media}");
                
            }
            else
            {
                Console.WriteLine($"Infelizmente a banda {nomeDaBanda} não existe nos nossos registros:");
            }
            Thread.Sleep(1000);
            Console.WriteLine("Aperte qualquer tela para sair.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
