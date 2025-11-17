internal class ReprodutorMusical
{
    public ReprodutorMusical(Musica musica)
    {
        Musica = musica;
    }

    public Musica Musica { get; }

    public void Tocar()
    {
        Console.WriteLine($"Tocando a música: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }

    public void Pausar()
    {
        Console.WriteLine($"Música pausada: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }

    public void Parar()
    {
        Console.WriteLine($"Música parada: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }

    public void Avancar()
    {
        Console.WriteLine($"Avançando na música: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }

    public void Retroceder()
    {
        Console.WriteLine($"Retrocedendo na música: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }

    public void AjustarVolume(int nivel)
    {
        Console.WriteLine($"Ajustando volume para {nivel} na música: {Musica.Nome} - Artista: {Musica.Artista.Nome}");
    }
}