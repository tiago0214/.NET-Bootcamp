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

pessoa1.Apresentar();