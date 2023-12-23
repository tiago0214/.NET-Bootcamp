using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//modificadores de acesso "public/private" 
//public: qualquer um pode acessar aquela propriedade(quando eu fazer a instancia, eu poder usa lá)
//private: mesmo que eu faço a instanciação da minha classe, somente a minha classe pode fazer a modificação nas propriedades que são privadas.
//faço isso, porque eu obrigo a passar pelas propriedades que são públicas.. para depois fazer a modificação na minha propriedade. Sempre lembrar do conceito de recursividade infinita, se eu tentar atribuir um valor para a propria propriedade, porque ela vai ficar se chamando.

//encapsulamento: é não possibilidade de alteração de algo, por fora do meu programa. Preciso passar por validação antes.



//por padrão(Convenção) os construtores ficam logo debaixo da minha classe;
//os construtores sempre tem que ter o mesmo nome da sua classe.
//posso criar os meus construtores sem parametros. Mas se eu colocar parametros para ele , obrigatoriamente, toda vez que instanciar a minha classe eu preciso passar os parametros para a minha instanciação.
//posso ter quantos construtores eu quiser. No exemplo de baixo, eu posso usar qualquer dos construtores para instanciar a minha classe. O primeiro, meio que vai ser o meu padrão.

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        //entender que a modificação do _nome, é só feita pela a minha propria class.
        private string _nome;
        // o _nome, se chama "CAMPO"/Variavel de instancia.
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper(); //poeria usar o body expression no set, porém somente se ele tivesse uma linha com a atribuição de valor.
            set
            {
                // lembrar que vou definir um ArgumentExcpetion. e o meu argumento é o value.
                // ele não vai continuar o meu programa, quando dispara a minha Excpetion.
                if (value == "")
                {
                    throw new ArgumentException("O valor não pode ser vazio");
                }
                _nome = value;
                //entender que a modificação do _nome, é só feita pela a minha propria class.
                //por isso , aqui eu não preciso definir get:set para o _nome, porque a minha classe que esta modificando ele.
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        //essa propriedade ai de cima, so tem GET, ou seja, somente retorna algo, por isso eu usei o body expression.
        //propriedade que somente retorna, eu somente não posso passar um valor para ela, mas, eu posso deixar um valor nela para que ela retorne. quando eu digo que eu não posso passar um valor, quero dizer que ela não pode receber nenhum valor quando eu instancio, eu somente posso colocar o valor pra ela.

        public int Idade
        {
            get => _idade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor não pode ser menor que 0");
                }
                _idade = value;
            }
        }
        //se eu utilizo o "=" utilizo o metodo set.

        public void Apresentar()
        {
            Console.WriteLine($"Nome {NomeCompleto}, idade: {Idade}");
            //se somente utilizo o nome da propriedade, estou chamando o get
        }
    }
}

//value: é o argumento que esta recebendo o nome.
//uma Exceção, é algo que não permite que o meu código continue em execução.

//resumindo, não quer dizer que eu não consiga modificar o meu _nome externamente, quer dizer que eu coloquei uma validação para alterar ele, porque eu coloquei uma estrutura de validação if(); Ou seja, ele esta sim recebendo os valores que vem de fora, porém, esta sofrendo uma validação para fazer a alteração nele.
//Não sei se eu conseguiria fazer o mesmo com as propriedades que são publicas.


//lembrar do chat GTP da recursividade infinita, se eu tentar atribuir o valor a minha propria propriedade, porque ele vai ficar atribuindo o valor a propriedade de forma infinita.

//explicação, porque eu não posso atribuir o valor adquirido na instanciação a minha propria propriedade, utilizando os metodos set dentro da propriedade.
//https://chat.openai.com/share/b5cdbff3-a0f5-4e53-9474-dc720e31f9d2

// o metodo set, se eu não colocar um corpo personalizado para alterar ele e deixar ele no comportamento padrão , por baixo dos panos, ele deve criar uma variavel de instância, para evitar o loop infinito, quando eu tento atribuir o valor direto para a minha propriedade, e ela fica chamando a si mesmo, gerando o loop infinito.

//por isso , se eu utilizar o valor da minha propriedade direto, ela não
