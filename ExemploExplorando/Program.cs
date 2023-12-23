using ExemploExplorando.Models;


decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:c}");
//quiser fazer um valor monetário, eu preciso colocar o template string, e depois uso :C
//quando eu utilizo o : eu estou dizendo que quero formatar o meu valor, e depois eu coloco para oque eu quero formatar. :C currency









































// //sempre se recomenda utilizar construtores, eles servem para quando eu sei que existem dois valores ("Que sempre serão passados"), eu já passe eles dentro do parenteses da minha instanciação. 
// //posso colocar o nome e sobrenome na frente, (opcional), . Quando eu faço isso eu estou passando o nome do meu parametro. inclusive, reparar , que se eu mudar a ordem, ele vai ser adcionado em ordem diferente também. Porque isso representa com todo certeza o nome dos meus parametros.
// //tem que ser o nome que eu coloquei.
// Pessoa p1 = new Pessoa(nome: "Tiago", sobrenome: "Souza");
// Pessoa p2 = new Pessoa(sobrenome: "Shara", nome: "Lorrany");

// Curso curso = new Curso();

// // Todo objeto possui o que chamamos de construtor. Mesmo quando não implementado, sempre temos o construtor padrão, como por exemplo: new Pessoa().
// //o construtor tem como finalidade, atribuir valores para um objeto no momento de sua criação.
// //sem construtor não seria possivel passar valores parao objeto.

// curso.Nome = "Inglês";
// curso.Alunos = new List<Pessoa>();
// //se eu não instanciar a lista criada dentro do curso, não da certo.

// //outra coisa, lembrar que os meus parametros que foram definidos na minha class curso, são do tipo da minha class Pessoa, ou seja, eu preciso instanciar as pessoas primeiro e depois passar elas como parametros para o meu curso.

// curso.AdicionarAlunos(p1);
// curso.AdicionarAlunos(p2);


// curso.MostrarAlunos();
// curso.QuantidadeDeAlunosMatriculados();











































// Pessoa p1 = new Pessoa();

// p1.Nome = "Tiago";
// p1.Sobrenome = "Souza";
// p1.Idade = 29;

// p1.Apresentar();

// Curso curso = new Curso();
