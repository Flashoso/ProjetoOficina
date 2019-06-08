using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStand
{
    public partial class CarroVenda
    {
        public CarroVenda(string extras, string matricula, string numeroChassis, string marca, string modelo, string combustivel) : base(numeroChassis, matricula, marca, modelo, combustivel)
        {
            Extras = extras;
        }

        public CarroVenda()
        {

        }

        public override string ToString()
        {
            return Extras;
        }
    }
}
