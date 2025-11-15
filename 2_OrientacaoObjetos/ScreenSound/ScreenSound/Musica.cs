internal class Musica
{
    //Atributos
    public string nome;

    public string artista;
    public int duracao;
    public bool disponivel;

    //Métodos
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração(segundos): {duracao}");
        Console.WriteLine($"Disponível: {(disponivel ? "Disponível no Plano" : "Adquira o plano Plus+")}");
    }
}