using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {                               //esse base aqui. é como se eu estivesse chamando o constutor da minha classe pessoa.PORQUE é obrigatoria, porque eu defini na minha classe pessoa, um construtor.
        public Aluno(string asdd) : base(asdd)
        {
            //esses : base(nome). Eu estou recebendo um parametro, e estou passando para a classe pai, o parametro que eu recebi.
            //porque na minha classe pai, eu defini a obrigatoriedade de definição do nome(parametro)
            //eu poderia colocar qualquer outro nome para o parametro.(só não posso mudar o tipo dele)
            //é como se eu tivesse usando o contrutor da minha classe pessoa.
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade}, sou aluno nota {Nota}");
        }
    }
}