using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sound
{
     class Podcast
    {
        private List<Episodio> episodios = new List<Episodio>();

        public Podcast(string nome, string host) 
        {
            this.Nome = nome;
            this.Host = host;
        }
        public string Host {  get; }

        public string Nome { get; set; }

        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
           episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcat{Nome}, apresentado por {Host} \n");

            foreach (Episodio episodio in episodios)
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\n\n Este podcast possui {TotalEpisodios} episódios. ");
        }

    }
}
