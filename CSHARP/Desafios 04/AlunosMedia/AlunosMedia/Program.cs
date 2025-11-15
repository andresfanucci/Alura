Dictionary<string, Dictionary<string, List<double>>> alunos = new Dictionary<string, Dictionary<string, List<double>>>();
List<string> materias = new List<string> { "Portugês", "Matemática", "História", "Geografia", "Ciências" };

void PreencherTituloMenu(string titulo)
{
    int qtdChar = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdChar, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}
void AdicionarNovoAluno()
{
    while (true)
    {
        Console.Clear();
        PreencherTituloMenu("Adicionar novo Aluno");
        Console.Write("\nPara voltar ao menu principal digite 9\n");
        Console.Write("Favor digitar nome do novo Aluno: ");
        string nomeAluno = Console.ReadLine()!;

        if (nomeAluno == "9")
        {
            break;
        }

        if (alunos.ContainsKey(nomeAluno))
        {
            Console.WriteLine($"\nAluno {nomeAluno} já existente. Favor escolher outro nome.");
            Console.ReadKey();
            continue;
        }
        alunos.Add(nomeAluno, new Dictionary<string, List<double>>());
        AdicionarMateriasPadrao(nomeAluno);
        Console.WriteLine($"\nAluno {nomeAluno} adicionado.");
        Thread.Sleep(5000);
        break;
    }
    CarregarMenuPrincipal();
}
void AdicionarMateriasPadrao(string nomeAluno)
{
    if (alunos.ContainsKey(nomeAluno))
    {
        foreach (string materia in materias)
        {
            alunos[nomeAluno].Add(materia, new List<double>());
        }
        Console.WriteLine("Grupo de matérias padrão adicionadas com sucesso.");
    }
    else
    {
        Console.WriteLine($"\nAluno {nomeAluno} não encontrado.");
    }
}
void AdicionarMateriasExtras()
{
    while (true)
    {
        Console.Clear();
        PreencherTituloMenu("Adicionar nova matéria extra");
        Console.Write("\nPara voltar ao menu principal digite 9\n");
        Console.Write("Favor digitar nome da nova matéria extra: ");
        string nomeMateria = Console.ReadLine()!;
        Console.WriteLine("Para qual aluno deseja adicionar a matéria extra?");
        foreach (var aluno in alunos.Keys)
        {
            Console.WriteLine($"- {aluno}");
        }
        Console.Write("\nDigite o nome do aluno: ");
        string nomeAluno = Console.ReadLine()!;
        if (nomeMateria == "9" || nomeAluno == "9")
        {
            break;
        }
        if (!alunos.ContainsKey(nomeAluno))
        {
            Console.WriteLine($"\nAluno {nomeAluno} não encontrado.");
            continue;
        }
        if (alunos[nomeAluno].ContainsKey(nomeMateria))
        {
            Console.WriteLine($"\nMatéria {nomeMateria} já existente para o aluno {nomeAluno}. Favor escolher outro nome.");
            Console.ReadKey();
            continue;
        }
        alunos[nomeAluno].Add(nomeMateria, new List<double>());
        Console.WriteLine($"\nMatéria {nomeMateria} adicionada para o aluno {nomeAluno}.");
        Thread.Sleep(5000);
        break;
    }
    Console.ReadKey();
    CarregarMenuPrincipal();
}
void AdicionarNovaMateriaPadrao()
{
    while (true)
    {
        Console.Clear();
        PreencherTituloMenu("Adicionar nova matéria padrão");
        Console.Write("\nPara voltar ao menu principal digite 9\n");
        Console.Write("Favor digitar nome da nova matéria padrão: ");
        string nomeMateria = Console.ReadLine()!;
        if (nomeMateria == "9")
        {
            break;
        }
        if (materias.Contains(nomeMateria))
        {
            Console.WriteLine($"\nMatéria {nomeMateria} já existente. Favor escolher outro nome.");
            Console.ReadKey();
            continue;
        }
        materias.Add(nomeMateria);
        Console.WriteLine($"\nMatéria {nomeMateria} adicionada.");
        foreach (var aluno in alunos.Keys)
        {
            alunos[aluno].Add(nomeMateria, new List<double>());
            Console.WriteLine($"Matéria {nomeMateria} adicionada para o aluno {aluno}");
        }
        Thread.Sleep(3000);
        break;
    }
    CarregarMenuPrincipal();
}
void AdicionarNovaNotaAluno()
{
    while (true)
    {
        Console.Clear();
        PreencherTituloMenu("Adicionar nova nota para aluno");
        Console.Write("\nPara voltar ao menu principal digite 9\n");
        Console.Write("Favor digitar nome do aluno: ");
        string nomeAluno = Console.ReadLine()!;
        if (nomeAluno == "9")
        {
            break;
        }
        if (!alunos.ContainsKey(nomeAluno))
        {
            Console.WriteLine($"\nAluno {nomeAluno} não encontrado.");
            Console.ReadKey();
            continue;
        }
        Console.WriteLine("\nMatérias disponíveis:");
        foreach (var materia in alunos[nomeAluno].Keys)
        {
            Console.WriteLine($"- {materia}");
        }
        Console.Write("\nDigite o nome da matéria: ");
        string nomeMateria = Console.ReadLine()!;
        if (nomeMateria == "9")
        {
            break;
        }
        if (!alunos[nomeAluno].ContainsKey(nomeMateria))
        {
            Console.WriteLine($"\nMatéria {nomeMateria} não encontrada para o aluno {nomeAluno}.");
            Console.ReadKey();
            continue;
        }
        Console.Write("Digite a nota a ser adicionada: ");
        string notaDigitada = Console.ReadLine()!;
        if (double.TryParse(notaDigitada, out double nota))
        {
            alunos[nomeAluno][nomeMateria].Add(nota);
            Console.WriteLine($"\nNota {nota} adicionada para o aluno {nomeAluno} na matéria {nomeMateria}.");
        }
        else
        {
            Console.WriteLine("\nValor inválido para nota.");
        }
        Thread.Sleep(3000);
        break;
    }
    CarregarMenuPrincipal();
}
void CarregarMenuPrincipal()
{
    Console.Clear();
    PreencherTituloMenu("Menu Principal");
    Console.WriteLine("\nEscolha uma opção abaixo:\n");
    Console.WriteLine("1 - Adicionar novo aluno");
    Console.WriteLine("2 - Adicionar nova materia padrão");
    Console.WriteLine("3 - Adicionar nova materia extra");
    Console.WriteLine("4 - Adicionar nova nota para aluno");
    Console.WriteLine("9 - Sair\n");
    Console.Write("Digite a opção desejada: ");
    string textoDigitado = Console.ReadLine()!;
    int opcaoEscolhida;
    if (string.IsNullOrEmpty(textoDigitado))
    {
        Console.WriteLine("\nFavor escolher uma opção...");
        Console.ReadKey();
        CarregarMenuPrincipal();
    }
    if (!int.TryParse(textoDigitado, out int result))
    {
        Console.WriteLine("\nFavor digitar um valor válido...");
        Console.ReadKey();
        CarregarMenuPrincipal();
    }
    opcaoEscolhida = result;
    switch (opcaoEscolhida)
    {
        case 1:
            AdicionarNovoAluno();
            break;

        case 2:
            AdicionarNovaMateriaPadrao();
            break;

        case 3:
            AdicionarMateriasExtras();
            break;

        case 4:
            AdicionarNovaNotaAluno();
            break;

        case 9:
            break;

        default:
            break;
    }
}

CarregarMenuPrincipal();