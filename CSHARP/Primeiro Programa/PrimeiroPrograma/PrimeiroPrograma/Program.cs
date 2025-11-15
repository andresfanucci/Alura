//Screen Sound

string mensagemBoasVindas = "Seja bem-vindo ao Screen Sound !";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 10, 9 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine
        (@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"
        );
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibit a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            ExibirMediaDaBanda();
            break;

        case -1:
            Console.WriteLine($"Tchau Tchau :)");
            break;

        default:
            Console.WriteLine($"Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"- {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalição de Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que você deseja dar para a banda {nomeBanda}? ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} foi registrada com sucesso para a banda {nomeBanda}!");
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada no registro.");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int qtdCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}
void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média de Bandas");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        if (notasDaBanda.Count > 0)
        {
            double media = notasDaBanda.Average();
            Console.WriteLine($"\nA média da banda {nomeBanda} é {media:F2}!");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} ainda não possui avaliações.");
        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada no registro.");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();