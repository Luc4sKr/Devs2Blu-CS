namespace ConsumoApi.Models
{
    public class Episodes
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultsEpisodes> results { get; set; }
    }

    public class ResultsEpisodes
    {
        public int id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public string created { get; set; }
    }
}
