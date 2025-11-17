internal class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Episódios: ({TotalEpisodios})");
        List<Episodio> sortedEpisodios = episodios.OrderBy(e => e.Ordem).ToList();
        foreach (var episodio in sortedEpisodios)
        {
            Console.WriteLine($"- {episodio.Resumo}");
        }
    }
}