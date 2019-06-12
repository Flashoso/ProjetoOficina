using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStand
{
    public partial class CarroAluguer
    {
        public CarroAluguer(string numeroChassis, string marca, string modelo, string combustivel, string estado, string matricula) : base(numeroChassis, marca, modelo, combustivel)
        {
            Estado = estado;
            Matricula = matricula;
        }
        public override string ToString()
        {
            return Matricula;
        }
    }
}
