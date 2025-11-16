internal class Disciplina
{
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }

    public Disciplina(string nome, int cargaHoraria)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
    }
}