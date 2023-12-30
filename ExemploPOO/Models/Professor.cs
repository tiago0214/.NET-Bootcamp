using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        //aqui, eu posso escolher se eu coloco o construtor vazio ou não, porque na minha classe pai, eu coloquei. Só que se eu não colocar o construtor vazio, ele vai ser obrigatorio a definição do nome na instanciação da minha classe professor e aluno. 

        public Professor() { }


        //esse base aqui. é como se eu estivesse chamando o constutor da minha classe pessoa.PORQUE é obrigatoria, porque eu defini na minha classe pessoa, um construtor.
        public Professor(string nome) : base(nome)
        {
            //esses : base(nome). Eu estou recebendo um parametro, e estou passando para a classe pai, o parametro que eu recebi.
            //porque na minha classe pai, eu defini a obrigatoriedade de definição do nome(parametro)
            //eu poderia colocar qualquer outro nome para o parametro.(só não posso mudar o tipo dele)
            //é como se eu tivesse usando o contrutor da minha classe pessoa.
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}, sou professor e ganho {Salario}");
        }
    }
}