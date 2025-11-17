internal class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public string Titulo { get; }
    public int Duracao { get; }

    public string Resumo
    {
        get
        {
            return $"{Ordem} - {Titulo} - Duração: {Duracao} minutos - Convidados: {string.Join(", ", convidados)}";
        }
    }

    public int Ordem { get; }

    public void AdicionarConvidados(List<string> novosConvidados)
    {
        foreach (string novoConvidado in novosConvidados)
        {
            convidados.Add(novoConvidado);
        }
    }
}