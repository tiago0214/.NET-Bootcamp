using ExemploPOO.Models;
using ExemploPOO.Interfaces;


//posso instanciar a classe assim normalmente.
Calculadora c1 = new Calculadora();
Console.WriteLine(c1.Somar(1, 2));

// como também posso fazer assim: aqui eu estou dizendo que a minha interface ICalculadora vai receber um new calculadora, porque a minha classe calculadora, faz a implementação da minha interface ICalculodora. Se eu tentasse fazer isso com qualquer outra classe daria erro, se eu não tivesse feito a implementação da interface dentro da classe.
ICalculadora c2 = new Calculadora();
//descrição. Eu estou usando uma interface que recebe um new calculadora().
//a interface é como se fosse um contrato. Para que seja considerado ICalculadora. Você tem que fazer a implementação de todos os metodos.








































// Computador c = new Computador();
// Console.WriteLine(c.ToString());
//eu consigo sobrescrever o meu método ToString padrão. Porque ele é uma herança da classe Object. que é o pai de todas as classes.







































// Pessoa p1 = new Pessoa("Tiago");
// Aluno a1 = new Aluno("Shara");
// Professor prof = new Professor("Camille");


// p1.Apresentar();
// a1.Apresentar();
// prof.Apresentar();


// Diretor d1 = new Diretor("tiago");
// d1.Apresentar();





































// Corrente c1 = new Corrente();
// c1.Creditar(500);
// c1.ExibirSaldo();









































// Aluno a1 = new Aluno();
// a1.Nome = "Tiago";
// a1.Idade = 29;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Shara";
// p1.Idade = 27;
// p1.Salario = 30.000M;
// p1.Apresentar();




































// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();
