using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        
        public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Avaliando Bandas:");
            Console.WriteLine("Digite o nome da banda que você deseja avaliar:");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                //Aqui não estamos criando uma nova banda, estamos pegando uma banda que foi previamente registada.
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"Qual a nota que você deixa para banda {nomeDaBanda}:");
                AvaliacaoMusica nota = AvaliacaoMusica.Parse(Console.ReadLine()!);
                //AvaliacaoMusica avaliacao = new AvaliacaoMusica(nota);
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
            }
            else
            {
                Console.WriteLine($"Infelizmente a banda {nomeDaBanda} não existe nos nossos registros:");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
