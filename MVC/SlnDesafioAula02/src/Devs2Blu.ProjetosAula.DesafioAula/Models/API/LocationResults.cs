namespace Devs2Blu.ProjetosAula.DesafioAula.Models.API
{
    public class LocationResults
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public String Next { get; set; }
        public String Prev { get; set; }
        public List<Location> Results { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimension { get; set; }
    }
}
