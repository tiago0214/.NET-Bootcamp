using ExemploExplorando.Models;
using System.Globalization;
using System.Runtime.CompilerServices;

//new TesteExcecao().Metodo1();

//dictionary
//é outra coleção: só que essa é uma coleção de CHAVE e VALOR, para armazenar valores únicos sem uma ordem específica. (obrigatoriedade: valores únicos.)
//eu preciso declarar quais são os tipos dos meus elementos. Exemplo Dictionary <string, string> O primeiro valor, sempre tem que ser único, se por acaso ele se repetir, vai dar uma exceção.

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("GO", "Goiás");

foreach (KeyValuePair<string, string> item in estados)
{//se eu não quiser usar a palavra KeyValuePair, eu posso usar a VAR, porque ele vai reconhecer automaticamente, sobre oque ela deve ser.
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
//sempre lembrar que quando eu tenho mais de uma coisa, dentro do mesmo escopo, por exemplo mas de metodo dentro de uma classe, ou mais coisa para usar dentro de qualquer coisa, exempplo, dentro de um dictionary, porque ele sempre tem chave e valor, eu preciso utilizar a notação ponto e falar oque eu quero.




































// //falar sobre pilhas (sempre lembrar que pilhas e filas: respeitam regras de inserção e remoção dos seus elementos)
// //obdece a regra do LIFO
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// //mesma coisa que aconteceu na fila,eu não passo qual elemento. Sempre vai ser o elemento to topo, aqui na pilha.
// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
































//falar sobre filas. (sempre lembrar que pilhas e filas: respeitam regras de inserção e remoção dos seus elementos)

//oCsharp tem as filas, que obdecem o a regra FIFO, e não pode ser alterada, ele sempre vai obdecer essa regra. Fila é um tipo de coleção igual existe com os outros tipos, igual array e listas, você também tem que passar o tipo da fila.

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento:{fila.Dequeue()}");
// fila.Enqueue(20);
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
//sempre remove o primeiro elemento


































//na leitura de arquivo, cada linha do meu arquivo é uma string, por isso ele vai me retornar um array de string.
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivoa/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Caminho não encontrado:  {ex.Message}");
// }
// catch (DirectoryNotFoundException)
// {
//     Console.WriteLine($"Diretorio não encontrado:");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção do tipo genérica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Cheguei até aqui. Independente de erro.");
// }

// a diferença entre a exceção genérica e a especifica, que a generica, é todas as minhas exceções, enquanto a especifica, eu uso direto o nome da minha exceção Exemplos acima.
//as exceções especificas: você pega uma metodo em C#, que pode acontecer alguma exceção, e trata de todas as exceções desse metodo.
//entender, que a exceção genérica, so é chamada quando a especifica não é tratada.































// string dataString = "88/12/2023 14:30";


// bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// // esse metodo vai tentar fazer o parse da minha string, parametros: 1:string, 2: formato, 3: variante de cultura(independe da cultura, porque eu já defini o formato), 4: sem estilo, mesma coisa do parametro anterior, porque eu já defini o formato que eu espero, 5: se ele conseguir converter ou não, ele vai jogar na minha variavel chamada data.
// //com essa conversão, diferente da outra, se der erro, ele não da erro no meu programa.


// if (sucesso)
// {
//     Console.WriteLine($"Conversão realizada com sucesso: {data}");
// }
// else
// {
//     Console.WriteLine($"Falha na conversão, data : {data}");
// }

//agora eu vou para um exemplo, em que eu estou esperando receber uma data, mas provavelmente ela vai vir como string, então eu tenho que converte-lá.







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
