namespace ConsumoApi.Models
{
    public class Locations
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultLocation> results { get; set; }
    }

    public class ResultLocation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
    }
}
