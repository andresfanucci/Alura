Episodio ep1 = new("Introdução ao C#", 30, 5);
ep1.AdicionarConvidados(new List<string> { "Alice", "Bob" });
Episodio ep2 = new("Avançando com C#", 45, 3);
ep2.AdicionarConvidados(new List<string> { "Charlie", "Diana" });
Podcast podcast = new("Aprendendo C#", "João Silva");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();