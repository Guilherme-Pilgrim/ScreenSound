class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public int TotalEpisodios => episodios.Count;
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        Console.WriteLine("Episódios:");
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Ordem} - {episodio.Titulo}");
            Console.WriteLine($"Duração: {episodio.Duracao} minutos");
            Console.WriteLine($"Descrição: {episodio.Descricao}");
            Console.WriteLine($"Convidados: {string.Join(", ", episodio.Convidados)}");
            Console.WriteLine($"Episódio disponível em: {episodio.Nome.Nome}");
            Console.WriteLine($"Apresentado por: {episodio.Host.Host}");
            Console.WriteLine();
        }
    }
}