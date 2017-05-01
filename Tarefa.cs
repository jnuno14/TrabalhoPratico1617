using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Tarefa : Utilizador, ITarefa
    {
        Utilizador uti;
        string tare;

        public Utilizador Uti
        {
            get { return uti; }
            set { uti = value; }
        }

        public string Tare
        {
            get { return tare; }
            set { tare = value; }
        }
    }
}
