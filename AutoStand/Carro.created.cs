﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStand
{
    public partial class Carro
    {
        public Carro(string numeroChassis, string marca, string modelo, string combustivel)
        {
            NumeroChassis = numeroChassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
        }
        public Carro()
        {

        }
    }
 
}
