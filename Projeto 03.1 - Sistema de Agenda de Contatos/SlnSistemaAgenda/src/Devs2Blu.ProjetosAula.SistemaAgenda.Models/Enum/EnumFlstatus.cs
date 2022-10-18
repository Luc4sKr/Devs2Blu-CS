using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum
{
    public enum EnumFlstatus
    {
        [Description("Inativo")]
        I = 1,
        [Description("Ativo")]
        A = 2,
        [Description("Concluído")]
        C = 3,
        [Description("Remarcado")]
        R = 4
    }
}
