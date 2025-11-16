internal class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }

    public Aluno(string nome, int idade, string curso)
    {
        Nome = nome;
        Idade = idade;
        Curso = curso;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Curso: {Curso}");
    }
}