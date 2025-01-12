Banda projetoSola = new Banda("Projeto Sola");

Album albumProjetoSola = new Album("Descanso & Celebração");

Genero generoGospel = new Genero("Gospel");

Musica musica1 = new Musica(projetoSola, "Efésios 1")
{
    Duracao = 325,
    Genero = generoGospel,
    Disponivel = false
};

Musica musica2 = new Musica(projetoSola, "Glória e Honra")
{
    Duracao = 297,
    Genero = generoGospel,
    Disponivel = true
};

albumProjetoSola.adicionarMusica(musica1);
albumProjetoSola.adicionarMusica(musica2);
projetoSola.AdicionarAlbum(albumProjetoSola);
projetoSola.ExibirDiscografia(); 
albumProjetoSola.ExibirMusicasDoAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Podcast podcast = new Podcast("SolaMento", "Guilherme Bezerra");

Episodio episodio1 = new Episodio(podcast, podcast, "#1")
{
    Duracao = 30,
    Descricao = "Neste episódio, Guilherme Bezerra e Lucas Montalvão conversam sobre a Reforma Protestante",
    Titulo = "Reforma Protestante"
};
episodio1.AdicionarConvidado("Lucas Montalvão");

Episodio episodio2 = new Episodio(podcast, podcast, "#2")
{
    Duracao = 45,
    Descricao = "Neste episódio, Guilherme Bezerra e Lucas Montalvão conversam sobre a Justificação pela Fé",
    Titulo = "Justificação pela Fé"
};
episodio2.AdicionarConvidado("Lucas Montalvão");


podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();