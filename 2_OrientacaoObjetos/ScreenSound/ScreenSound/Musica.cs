internal class Musica
{
    //Construtor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    //Propriedades

    public string Nome { get; }
    public Banda Artista { get; private set; }
    public Genero Genero { get; set; } = new Genero();
    public int Duracao { get; set; } = 0;
    public bool Disponivel { get; set; } = false;

    public string DescricaoResumida => $"{Nome} - {Artista}";

    //Métodos

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        Console.WriteLine($"Duração(segundos): {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Música: {Nome} - Artista: {Artista}");
    }
}