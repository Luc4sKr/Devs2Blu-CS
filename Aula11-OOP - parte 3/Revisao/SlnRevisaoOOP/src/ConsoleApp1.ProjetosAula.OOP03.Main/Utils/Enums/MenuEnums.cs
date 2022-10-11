using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProjetosAula.OOP03.Main.Utils.Enums
{
    public enum MenuEnums
    {
        // Opções gerais
        SAIR       = 0,     // Como padrão para sair de qualquer menu, o número '0' é utilizado.
        LISTAR     = 1,
        CADASTRAR  = 2,
        ALTERAR    = 3,
        EXCLUIR    = 4,
        
        // Menu principal
        CAD_PACIENTE = 10,
        CAD_MEDICO = 20,
        CAD_RECEPCIONISTA = 30,
        CAD_FORNECEDOR = 40,
        AGENDA = 50,
        PRONTUARIO = 60,
        FINANCEIRO = 70,

        // Menu de alterar pacientes
        NOME_PACIENTE = 1,
        CPF_PACIENTE = 2,
        CONVENIO_PACIENTE = 3

    }
}
