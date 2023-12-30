using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{   //essa classe abstrata, só serve para ser herdada.
    public abstract class Conta
    {
        //se eu tivesse colocado ele como privado, eu não teria como alterar nas minhas classes filhas.
        protected decimal saldo;
        //protected: Meu atributo/propriedade(campo) pode ser alterado pelas classes filhas. Porém não pode ser alterado de forma externa, igual ao privated.

        public abstract void Creditar(decimal valor);
        //metodo abstract, ele só é definido(não é implementado), eu obrigo as minhas classes filhas a implementa-lo.

        public void ExibirSaldo()
        {
            Console.WriteLine(saldo);
        }

    }
}