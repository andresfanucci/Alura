internal class Disciplina
{
    private Dictionary<Aluno, double> alunos = new Dictionary<Aluno, double>();
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Disciplina(string nome)
    {
        Nome = nome;
    }

    public void MatricularAluno(Aluno aluno)
    {
        alunos.Add(aluno, new double());
    }

    public void RegistrarNota(Aluno aluno, double nota)
    {
        if (alunos.ContainsKey(aluno))
        {
            alunos[aluno] = nota;
        }
        else
        {
            throw new Exception("Aluno não está matriculado nesta disciplina.");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Disciplina: {Nome}");
        foreach (var entry in alunos)
        {
            Console.WriteLine($"Aluno: {entry.Key.Nome}, Nota: {entry.Value}");
        }
    }
}