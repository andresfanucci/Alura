internal class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Curso Curso { get; set; }

    public Aluno(string nome, int idade, Curso curso)
    {
        Nome = nome;
        Idade = idade;
        Curso = curso;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Curso: {Curso.Nome}");
    }
}