namespace ConsumoApi.Models
{
    public class Characters
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultsCharacter> results { get; set; }
    }

    public class ResultsCharacter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
    }
}
