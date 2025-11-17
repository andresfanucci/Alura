Titular titular = new Titular("Ana Silva", "123.456.789-00", "");
Conta conta = new Conta(titular);
Console.WriteLine(conta.Informacoes);

Console.WriteLine("=======================================================");

Produto produto1 = new Produto();
produto1.AdicionarNovo("Notebook", 3500.00, 10);
Produto produto2 = new Produto();
produto2.AdicionarNovo("Smartphone", 1500.00, 20);
Estoque estoque = new Estoque();
estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
foreach (var produto in estoque.ListarProdutos())
{
    Console.WriteLine(produto.Informacoes);
    Console.WriteLine("-------------------------------------------------------");
}
Console.WriteLine("=======================================================");
Curso curso = new Curso("Engenharia de Produção", "Curso focado em processos produtivos", 2400);
Disciplina disciplina = new Disciplina("Cálculo I");
Disciplina disciplina1 = new Disciplina("Física I");
curso.AdicionarDisciplina(disciplina);
curso.AdicionarDisciplina(disciplina1);
Professor professor = new Professor("Mariana Souza", 35, "Matemática");
curso.DesignarProfessor(professor);
Aluno aluno = new Aluno("Carlos Pereira", 20, curso);
curso.MatricularAluno(aluno);
disciplina.RegistrarNota(aluno, 9.5);
disciplina1.RegistrarNota(aluno, 8.0);
aluno.ExibirInformacoes();
professor.ExibirInformacoes();
disciplina.ExibirInformacoes();
disciplina1.ExibirInformacoes();