using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador
    {
        public override string ToString()
        {
            return "O valor do método foi sobrescrito";
        }
        //eu consigo sobrescrever o meu método ToString padrão. Porque ele é uma herança da classe Object. que é o pai de todas as classes.
        //todas as classes herdam da classe Object, de maneira implicita, eu nem preciso especificar isso com o : Object
    }
}