internal class Musica
{
    //Propriedades

    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"{Nome} - {Artista}";

    //Métodos

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração(segundos): {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Música: {Nome} - Artista: {Artista}");
    }
}