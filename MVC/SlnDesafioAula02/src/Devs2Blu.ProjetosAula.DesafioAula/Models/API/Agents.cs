using System.Reflection.Metadata.Ecma335;

namespace Devs2Blu.ProjetosAula.DesafioAula.Models.API
{
    public class Agents
    {
        public int Status { get; set; }
        public List<Agent> Data { get; set; }
    }

    public class Agent
    {
        public string Uuid { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string DisplayIcon { get; set; }
        public string FullPortrait { get; set; }
        public string Background { get; set; }

    }
}
