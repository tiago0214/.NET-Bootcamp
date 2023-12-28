using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numero, decimal saldoInicial)
        {
            NumeroConta = numero;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor insuficiente");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("O valor do seu saldo é: " + saldo);
        }

    }
}