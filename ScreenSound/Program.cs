//Teste 
Dictionary<string, List<int>> Bandas = new Dictionary<string, List<int>>();

void ExibirBoasVindas()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine("\nBem vindos ao Screen Sound!\n");
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
void ExibirTitulo(string titulo)
{
    string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void ExibirMenu()
{
    ExibirBoasVindas();
    Console.WriteLine("\nMENU:\nDigite 1 para registrar banda:");
    Console.WriteLine("Digite 2 para mostrar todas as bandas: ");
    Console.WriteLine("Digite 3 para avaliar uma banda:");
    Console.WriteLine("Digite 4 para exibir a média de notas da banda:");
    Console.WriteLine("Digite 5 para sair: ");
    Console.Write("Digite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaDasBandas();
            break;
        case 5:
            Console.WriteLine("Obrigada por usar o Screen Sound :)");
            break;
        default:
            Console.WriteLine("Opção selecionada inválida!");
            break;
    }
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliando Bandas:");
    Console.WriteLine("Digite o nome da banda que você deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (Bandas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que você deixa para banda {nomeDaBanda}:");
        int nota = int.Parse(Console.ReadLine()!);
        Bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
    }
    else
    {
        Console.WriteLine($"Infelizmente a banda {nomeDaBanda} não existe nos nossos registros:");
    }
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();
}
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Lista de bandas registradas");
    int i = 1;
    foreach (string nomeBanda in Bandas.Keys)
    {
        Console.WriteLine($"Banda {i}: {nomeBanda}");
        i++;
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();
}
void ExibirMediaDasBandas()
{
    Console.Clear();
    ExibirTitulo("Exibir média da banda::");
    Console.WriteLine("Digite o nome da banda que você deseja ver a média:");
    string nomeDaBanda = Console.ReadLine()!;
    if (Bandas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Média de notas da banda {nomeDaBanda} é {Bandas[nomeDaBanda].Average()}");
    }
    else
    {
        Console.WriteLine($"Infelizmente a banda {nomeDaBanda} não existe nos nossos registros:");
    }
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();
}
ExibirMenu();


