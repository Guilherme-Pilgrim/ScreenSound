class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    
    public void adicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do álbum  {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao} segundos");
            Console.WriteLine($"Gênero: {musica.Genero.Nome}");
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos");
    }
}