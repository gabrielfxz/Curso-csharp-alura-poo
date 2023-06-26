class Musica
{

    public Musica(Banda artista, string nome, int duracao)
    {
        Artista = artista;
        Nome = nome;
        Duracao = duracao;
    }

    public string Nome { get;}
    public Banda Artista { get;}
    public int Duracao { get; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}