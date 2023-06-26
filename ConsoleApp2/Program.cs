//Banda queen = new Banda("queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life", 213)
//{
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody", 354)
//{
//    Disponivel = false,
//};


//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);

//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirDiscografia();

Episodio episodio1 = new Episodio(300,2,"Como viver uma vida scrang");
episodio1.AdicionarConvidados("bibbobs");
episodio1.AdicionarConvidados("paulo");
Episodio episodio2 = new Episodio(540, 1, "Como viver uma vida tchernous");
episodio2.AdicionarConvidados("krakas");
episodio2.AdicionarConvidados("pinjoin");

Podcast podcast1 = new Podcast("Gabriel","XirinbsCast");

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

podcast1.ExibirDetalhes();