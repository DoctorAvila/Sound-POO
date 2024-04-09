class Episodio 


{

    private List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get;  }

    public string Titulo { get;  }

    public int Duracao { get;  }

    public string Resumo => $"{Ordem}. {Titulo} com ({Duracao}) minutos de duração) - {string.Join(", ",convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        this.convidados.Add(convidado);
    }

}
