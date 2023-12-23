using ExemploExplorando.Models;
using System.Globalization;


string dataString = "30/12/2023 14:30";
DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// esse metodo vai tentar fazer o parse da minha string, parametros: 1:string, 2: formato, 3: variante de cultura(independe da cultura, porque eu já defini o formato), 4: sem estilo, mesma coisa do parametro anterior, porque eu já defini o formato que eu espero, 5: se ele conseguir converter ou não, ele vai jogar na minha variavel chamada data.
//com essa conversão, diferente da outra, se der erro, ele não da erro no meu programa.

//agora eu vou para um exemplo, em que eu estou esperando receber uma data, mas provavelmente ela vai vir como string, então eu tenho que converte-lá.
Console.WriteLine(data);







// DateTime data = DateTime.Now;


// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//se atentar que se eu colocar o mm minusculo na data, eu estou representando os minutos. 



































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// //para mudar a localização do meu programa.


// decimal valorMonetario = 1282.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// //posso travar a localização do meu sistema e depois alterar a representação de algo em alguma cultura especifica.

// Console.WriteLine($"{valorMonetario:C}");
// //quiser fazer um valor monetário, eu preciso colocar o template string, e depois uso :C
// //quando eu utilizo o : eu estou dizendo que quero formatar o meu valor, e depois eu coloco para oque eu quero formatar. :C currency


// //diversas maneiras que eu posso formatar e representar um numero.
// //Console.WriteLine($"{valorMonetario.ToString("C2")}"); C: significa moeda, e 2 significa o numero de casas decimais.


// double porcetagem = .3442;
// Console.WriteLine(porcetagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##/##/##"));







































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
