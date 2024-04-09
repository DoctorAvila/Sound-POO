public class Banda
{
    private List<Album> album = new List<Album>();


    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionaAlbum(Album album)
    {
        this.album.Add(album);
    }

    public void ExbirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach(Album album in this.album)
        {
            Console.WriteLine($"Album: {album.Nome} de {album.Duracao}");
        }
    }
}