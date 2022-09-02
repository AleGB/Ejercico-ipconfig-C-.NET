using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Comandos
{
    public class Comandos
    {
        private string _Nombre; //Nombre del comando
        private string _args;   //Argumento(s) del comando

        public Comandos()
        {
            _Nombre = "";
            _args = "";
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Args { get => _args; set => _args = value; }

    }
}
