﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStand
{
    public partial class Servico
    {
        public Servico(string dataEntrada, string dataSaida, string tipo)
        {
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Tipo = tipo;
        }
    }
}
