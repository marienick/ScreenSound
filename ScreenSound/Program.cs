using ScreenSound.Modelos;
using ScreenSound.Menus;


Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
Dictionary <int,Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3,new MenuExibirTodasAsBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());
void ExibirBoasVindas()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine("\nBem vindos ao Screen Sound!\n");
}

void ExibirMenu()
{
    ExibirBoasVindas();
    Console.WriteLine("\nMENU:\nDigite 1 para registrar banda:");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda:");
    Console.WriteLine("Digite 3 para mostrar todas as bandas: ");
    Console.WriteLine("Digite 4 para avaliar uma banda:");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda:");
    Console.WriteLine("Digite -1 para sair: ");
    Console.Write("Digite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhida];
        menuASerExibido.Executar(bandasRegistradas);
        if(opcaoEscolhida > 0)
        {
            ExibirMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção selecionada inválida!");
    }
}


ExibirMenu();


