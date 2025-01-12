class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => 
        $"{Nome} - {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(DescricaoResumida);
        Console.WriteLine($" Música: {Nome}");
        Console.WriteLine($" Artista: {Artista.Nome}");
        Console.WriteLine($" Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível para reprodução");
        }
        else
        {
            Console.WriteLine("Adquira o plano premium para ouvir essa música");
        }
        Console.WriteLine();
    }
}