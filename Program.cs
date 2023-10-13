//dotnet new console
//esse arquivo aqui, é uma classe.
//oque esta dentro do OBJ, é referente a debugar. 
//toda a ação é feita aqui, no program.cs. Ele é o ponto de entrada do nosso sistema.
//o namespace : vai ser usado aqui. Como um modo de eu encontrar as coisas do meu programa.(mesma coisa de import export do JS)
using C_.models;

//isso aqui é uma varaivel
Pessoa pessoa1 = new Pessoa();

//posso fazer direto
// C_.models.Pessoa p = new C_.models.Pessoa();  //passo o nome direto. Ai eu não preciso do using

pessoa1.Nome = "Tiago";
pessoa1
.
Idade = 29;
//posso usar quebra de linha assim, igual em nodeJS

//pessoa1.Apresentar();



//declaração de variaveis.

string apresentacao = "Olá, seja bem vindo";
//o nome não é criar uma variavel, mas sim, declarar uma variavel.

int quantidade = 1;

double altura = 1.80;
//posso colocar somente um numero, sem casa decimal dentro do double. 
//mas não posso fazer isso dentro do int.

decimal preco = 1.80M;
//o 'M' no final, significa que eu estou passando um valor direto.
//caso eu não coloque o 'M', eu tenho que usar o tipo double.
//para sinalizar que eu quero aquele valor direto.

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("O valor da minha variavel quantidade: "+quantidade);
Console.WriteLine("O valor da minha variavel altura: "+altura);
Console.WriteLine("O valor da minha variavel preco: "+preco);
//reparar que na saida desse. Vai aparecer o 0 de 1.80 e no de cima não vai.
//porque no preco,estou falando que eu quero aquele numero exato. Com o 'M'
//para arrumar: altura.ToString("0.00")
Console.WriteLine("O valor da minha variavel condicao: "+condicao);


//date

//nao esquecer que o nome que vem antes do nome da variavel, é o tipo.

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//casting - cast (Conversão da variavel de um tipo para outro tipo.)
//isso não quer dizer que vai dar certo. Se tiver algum valor invalido quebra o código (ARRISCADO)

int a = Convert.ToInt32("5");
//Covert: é uma class e o ToInt32(): é um método.

//posso converter de outra maneira.
int b = int.Parse("5");
//posso fazer .Parse(), com outros tipos. double.Parse(), float.parse();
//tomar cuidado, porque pode acontecer de o programa não conseguir fazer a conversão e ele vai estourar um erro. ex: int.Parse("56b")