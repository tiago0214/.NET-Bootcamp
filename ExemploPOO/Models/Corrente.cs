using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
            //se na classe conta, o atributo SALDO, fosse definido como privated, eu não poderia acessar ele aqui. mesmo alterando com o metodo.
        }
    }
}