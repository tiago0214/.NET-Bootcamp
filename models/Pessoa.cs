using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//o namespace é o caminho lógico para chegar nessa classe. Isso não se confunde com o caminho fisico.
//posso mudar para o nome que eu quiser.
namespace C_.models
{
    public class Pessoa
    {   
        // Minhas propriedades/atributos
        public string Nome { get; set;}
        public int Idade { get; set;}

        //meu metodo/função : realiza uma ação
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos.");
            //ter em mente, que o console(é uma classe), e o WriteLine é um (metodo/função).
            //isso que eu fiz ai em cima. Seria a mesma coisa que eu chamar Pessoa.Apresentar()
            //passagem de valor para um metodo. é chamado de Parametro/Argumento.
        }
    }
}
//posso inverter a ordem. primeiro as ações e depois as propriedades.

//quando eu crio o molde(class). eu não atribuo valores a esse molde.
//so atribuo valores, quando eu instancio.


//quando eu instancio a class: eu transformo ela em um objeto.