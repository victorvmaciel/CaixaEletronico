﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
     class ContaCorrente :Conta

       
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor * 0.02;
        }
        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public override void Transfere(Conta destino, double valor)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
