internal class Curso
{
    private List<Disciplina> disciplinas = new List<Disciplina>();
    private List<Aluno> alunos = new List<Aluno>();
    private List<Professor> professores = new List<Professor>();
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int CargaHoraria { get; set; }

    public Curso(string nome, string descricao, int cargaHoraria)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
    }

    public void AdicionarDisciplina(Disciplina disciplina)
    {
        disciplinas.Add(disciplina);
    }

    public void MatricularAluno(Aluno aluno)
    {
        alunos.Add(aluno);
    }

    public void DesignarProfessor(Professor professor)
    {
        professores.Add(professor);
    }
}