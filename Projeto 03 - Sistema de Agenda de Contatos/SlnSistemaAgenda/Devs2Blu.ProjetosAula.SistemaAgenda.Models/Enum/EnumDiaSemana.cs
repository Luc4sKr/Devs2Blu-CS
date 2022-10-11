using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum
{
    public enum EnumDiaSemana
    {
        [Description("Domingo")]
        DOM = 1,
        [Description("Segunda")]
        SEG = 2,
        [Description("Terça")]
        TER = 3,
        [Description("Quarta")]
        QUA = 4,
        [Description("Quinta")]
        QUI = 5,
        [Description("Sexta")]
        SEX = 6,
        [Description("Sábado")]
        SAB = 7

    }
}
