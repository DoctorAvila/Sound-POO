using System;

public class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int Duracao => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusica()
    {
        Console.WriteLine($"Lista de músicas: ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} ");

        }
    }



}