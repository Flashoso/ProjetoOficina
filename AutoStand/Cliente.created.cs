using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStand
{
    public partial class Cliente
    {
        public Cliente(string nome, string nif, string morada, string contacto)
        {
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Contacto = contacto;
        }
        public override string ToString()
        {
            return Nome + " (" + Contacto + ")";
        }
    }
}
