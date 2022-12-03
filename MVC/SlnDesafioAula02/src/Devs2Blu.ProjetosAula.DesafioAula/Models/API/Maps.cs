using System.Security.Principal;

namespace Devs2Blu.ProjetosAula.DesafioAula.Models.API
{
    public class Maps
    {
        public int Status { get; set; }
        public List<Map> Data { get; set; }
    }

    public class Map
    {
        public string Uuid { get; set; }
        public string DisplayName { get; set; }
        public string Coordinates { get; set; }
        public string DisplayIcon { get; set; }
        public string ListViewIcon { get; set; }
        public string Splash { get; set; }
    }
}
