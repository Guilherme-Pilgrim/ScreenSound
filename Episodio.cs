class Episodio
{
    public Podcast Nome { get; }
    public Podcast Host { get; }
    public string Ordem { get; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string Descricao { get; set; }
    public List<string> Convidados = new ();
    public Episodio(Podcast nome, Podcast host, string ordem)
    {
        Nome = nome;
        Host = host;
        Ordem = ordem;
    }
    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}