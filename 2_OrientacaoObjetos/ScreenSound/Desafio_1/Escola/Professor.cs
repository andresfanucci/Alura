internal class Professor
{
    private List<Disciplina> disciplinas = new List<Disciplina>();
    private List<Curso> cursos = new List<Curso>();
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Especialidade { get; set; }

    public Professor(string nome, int idade, string especialidade)
    {
        Nome = nome;
        Idade = idade;
        Especialidade = especialidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Especialidade: {Especialidade}");
    }
}