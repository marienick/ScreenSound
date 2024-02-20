using ScreenSound.Modelos;
using ScreenSound.Menus;
//ctrl + alt + l: Abrir gerenciador de soluções.

Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
Dictionary <int,Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuRegistrarMusica());
opcoes.Add(4, new MenuExibirTodasAsBandas());
opcoes.Add(5, new MenuExibirTodosOsAlbuns());
opcoes.Add(6, new MenuExibirTodasAsMusicas());
opcoes.Add(7, new MenuAvaliarBanda());
opcoes.Add(8, new MenuAvaliarAlbum());
opcoes.Add(9, new MenuAvaliarMusica());
opcoes.Add(10, new MenuExibirDetalhes());
opcoes.Add(11, new MenuExibirDetalhesAlbum());
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
    Console.WriteLine("Digite 3 para exibir todas as bandas: ");
    Console.WriteLine("Digite 4 para exibir todos os álbuns de uma banda:");
    Console.WriteLine("Digite 5 para exibir todo as as músicas de um álbum:");
    Console.WriteLine("Digite 6 para avaliar uma banda:");
    Console.WriteLine("Digite 7 para avaliar álbum:");
    Console.WriteLine("Digite 8 para avaliar música:");
    Console.WriteLine("Digite 8 para exibir os detalhes de uma banda:");
    Console.WriteLine("Digite 9 para exibir os detalhes de um álbum:");
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


