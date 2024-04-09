

public class Musica
{


    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;

    }


    public string Nome {  get; }

    public Banda Artista {  get; }

    public int Duracao { get; set; }

    public bool Disponivel { get; set; }

    public string GeneroMusical { get; set; }

    //apenas o get
    public string Resumo => $"A música {Nome} pertence a banda {Artista.Nome}";


    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponivel: {Disponivel}");
        Console.WriteLine($"Genero musical: {GeneroMusical}");
        Console.WriteLine($"Resumo: {Resumo}");
    }

}



