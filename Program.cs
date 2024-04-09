using Sound;

Episodio ep1 = new Episodio(1, "Episodio 1", 10);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Eduardo");
ep1.AdicionarConvidados("Caio");

Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, "Episodio 2", 30);
ep2.AdicionarConvidados("Flavia");
ep2.AdicionarConvidados("Daniel");

Podcast podcast1 = new Podcast("Flow espacial", "Igor 3K");
podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);

podcast1.ExibirDetalhes();
