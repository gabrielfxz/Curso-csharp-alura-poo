class Podcast
{

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    List<Episodio> episodioList = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodioList.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Host}, Nome: {Nome}\n");
        Console.WriteLine($"lista de episódios:\n");
        foreach (Episodio episodio in episodioList.OrderBy(e => e.Ordem)){
            Console.WriteLine($"{episodio.Resumo}");
        };
        Console.WriteLine($"\nO total de episódios é {episodioList.Count}");
    }
}

