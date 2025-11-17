internal class Playlist
{
    public Playlist(List<Musica> musicas)
    {
        Musicas = musicas;
    }

    private List<Musica> Musicas { get; }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void RemoverMusica(Musica musica)
    {
        if (Musicas.Contains(musica))
        {
            Musicas.Remove(musica);
        }
        else
        {
            throw new Exception("Música não existente na Playlist");
        }
    }
}