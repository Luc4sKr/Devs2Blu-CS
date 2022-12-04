namespace Devs2Blu.ProjetosAula.DesafioAula.Models.API
{
    public class CharacterResults
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public String Next { get; set; }
        public String Prev { get; set; }
        public List<Character> Results { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
    }
}
