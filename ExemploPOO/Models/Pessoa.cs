using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {//lembrar, que se eu definir um construtor vazio, para não ser obrigatório eu passar o nome. eu preciso fazer o mesmo nas minhas classes filhas.
        public Pessoa() { }



        //e se atentar, que quando eu passar o parametro direto na minha instanciação das minhas classes filhas. ele vai receber nesse construtor aqui.
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {Nome} e tenho :{Idade} anos de idade");
        }
    }
}