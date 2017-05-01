using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Projeto : Tarefa, IProjeto
    {
        string nomeProjeto, dataInicio, bug;
        Tarefa taref;
        Utilizador leader;

        public string NomeProjeto
        {
            get { return nomeProjeto; }
            set { nomeProjeto = value; }
        }

        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public Tarefa Taref
        {
            get { return taref; }
            set { taref = value; }
        }

        public string Bug
        {
            get { return bug; }
            set { bug = value; }
        }

        public Utilizador Leader
        {
            get { return leader; }
            set { leader = value; }
        }
    }
}
