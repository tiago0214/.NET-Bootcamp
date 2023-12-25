using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class TesteExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada." + ex.Message);
            }

        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma nova exceção");
        }
    }
}
//se ligar na importancia disso aqui
//quando eu executo o meu código, ele vai de cima para baixo e, reparar que no método 4, eu pedi para jogar uma exceção.
//Quando ele da uma exceção, ele tenta ver de baixo para cima, se alguem esta cuidando dela. ele volta todos os métodos para trás. então, se eu tiver tratando ela, por mais que seja lá em cima, ele vai usar aquele tratamento. O tratamento do meu bloco catch.

//reparar uma coisa, eu peço para jogar uma nova exceção, throw new excepetion. então se eu fizer a tratativa dessa exceção, ele vai jogar o nome do erro, como sendo aquele que eu coloquei , quando eu defini o throw new excepetion.