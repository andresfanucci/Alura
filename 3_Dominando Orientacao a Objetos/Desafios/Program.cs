using Desafios;

Filme lotr = new("Senhor dos Anéis", 200, null);
Artista frodo = new("Frodo Bolseiro", 50);
lotr.AdicionaElenco(frodo);
Artista aragorn = new("Aragorn", 87);
lotr.AdicionaElenco(aragorn);
lotr.ListaElenco();
frodo.MostrarFilmesAtuados();
aragorn.MostrarFilmesAtuados();