namespace Desafios;

internal class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public List<Filme> Filmes { get; set; }
    public int QtdFilmes => Filmes.Count;

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);
        if (!filme.Elenco.Contains(this)) filme.AdicionaElenco(this);
    }

    public void MostrarFilmesAtuados()
    {
        if (this.Filmes.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {Nome}");
            return;
        }
        Console.WriteLine($"Filmes de {Nome}");
        foreach (var filme in Filmes)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}