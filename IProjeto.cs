using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    interface IProjeto
    {
        string NomeProjeto
        {
            get;
            set;
        }

        string DataInicio
        {
            get;
            set;
        }

        Tarefa Taref
        {
            get;
            set;
        }

        string Bug
        {
            get;
            set;
        }

        Utilizador Leader
        {
            get;
            set;
        }
    }
}
