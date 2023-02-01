using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Web.Models.DTO
{
    public class ImageFieldNews
    {
        public int idNews { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName]
        public string? imageNews { get; set; }
    }
}
