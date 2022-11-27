using System.Reflection.Metadata.Ecma335;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models
{
    public class Pokemons
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public ResultsPokemonss results { get; set; }
    }

    public class ResultsPokemonss
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
