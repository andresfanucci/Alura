namespace Desafios;

internal class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }

    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.AdicionarFilme(this);
            }
        }
    }

    public void AdicionaElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.Filmes.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista.Nome} adicionado/a ao elenco.");
    }

    public void ListaElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio");
        }
        else
        {
            Console.WriteLine("Elenco...");
            foreach (var artista in Elenco)
            {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}