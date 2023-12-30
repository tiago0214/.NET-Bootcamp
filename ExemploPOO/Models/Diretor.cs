using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {// se eu selar a minha classe Professor, eu não posso herdar dela. "sealed", posso fazer isso no método também
        public Diretor(string nome) : base(nome)//se eu retirar o :base (nome), hora que eu for instanciar o meu programa, não da erro, porém ele não sabe oque fazer com o parametro
        { }
        //não posso tentar fazer o override em cima do Aprensentar(); porque eu selei ele na minha classe professor. ou seja, eu não precisa selar somente na minha classe mais alta, eu posso selar em uma das classes filhar, e com isso eu impeço de tudo o que for herdar dela. não posso sobrescrever

    }
}