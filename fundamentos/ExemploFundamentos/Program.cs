//dotnet new console
//esse arquivo aqui, é uma classe.
//oque esta dentro do OBJ, é referente a debugar. 
//toda a ação é feita aqui, no program.cs. Ele é o ponto de entrada do nosso sistema.
//o namespace : vai ser usado aqui. Como um modo de eu encontrar as coisas do meu programa.(mesma coisa de import export do JS)
using Csharp.models;


bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a opção desejada");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscas cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar programa");

    string ?opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrado");
            break;
        case "2":
            Console.WriteLine("Buscado");
            break;
        case "3":
            Console.WriteLine("Apagado");
            break;
        case "4":
            Console.WriteLine("Encerrado");
            exibirMenu = false;
            //Environment.Exit(0); fecha tudo // Não executa mais nada.
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");































// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }
// while(numero != 0);

// Console.WriteLine($"A soma total dos numeros é {soma}");
































// int numero = 5 ;
// int contador = 1;

// while(contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução = {numero} x {contador} = {numero*contador}");
//     contador++;

//     //maneira de interroper o fluxo do programa. Mesmo, se a variavel de validação for verdadeira do while.
//     //funciona com o for também 
//     if(contador == 6 )
//     {
//         break;
//     }
// }
































// int numero = 5;

// for(int contador = 0; contador <=10; contador++ )
// {
//     Console.WriteLine($"{numero} x {contador} = {numero*contador}");
// }

































Calculadora calc = new Calculadora();

calc.Somar(1,2);
calc.Subtrair(1,2);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);
































//isso aqui é uma varaivel
// Pessoa pessoa1 = new Pessoa();

// //posso fazer direto
// // C_.models.Pessoa p = new C_.models.Pessoa();  //passo o nome direto. Ai eu não preciso do using

// pessoa1.Nome = "Tiago";
// pessoa1
// .
// Idade = 29;
// //posso usar quebra de linha assim, igual em nodeJS

// //pessoa1.Apresentar();



// //declaração de variaveis.

// string apresentacao = "Olá, seja bem vindo";
// //o nome não é criar uma variavel, mas sim, declarar uma variavel.

// int quantidade = 1;

// double altura = 1.80;
// //posso colocar somente um numero, sem casa decimal dentro do double. 
// //mas não posso fazer isso dentro do int.

// decimal preco = 1.80M;
// //o 'M' no final, significa que eu estou passando um valor direto.
// //caso eu não coloque o 'M', eu tenho que usar o tipo double.
// //para sinalizar que eu quero aquele valor direto.

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da minha variavel quantidade: "+quantidade);
// Console.WriteLine("O valor da minha variavel altura: "+altura);
// Console.WriteLine("O valor da minha variavel preco: "+preco);
// //reparar que na saida desse. Vai aparecer o 0 de 1.80 e no de cima não vai.
// //porque no preco,estou falando que eu quero aquele numero exato. Com o 'M'
// //para arrumar: altura.ToString("0.00")
// Console.WriteLine("O valor da minha variavel condicao: "+condicao);


// //date

// //nao esquecer que o nome que vem antes do nome da variavel, é o tipo.

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// //casting - cast (Conversão da variavel de um tipo para outro tipo.)
// //isso não quer dizer que vai dar certo. Se tiver algum valor invalido quebra o código (ARRISCADO)

// int a = Convert.ToInt32("5");
// Console.WriteLine(a);
// //Covert: é uma class e o ToInt32(): é um método.

// //posso converter de outra maneira.
// int b = int.Parse("5");
// //posso fazer .Parse(), com outros tipos. double.Parse(), float.parse();
// //tomar cuidado, porque pode acontecer de o programa não conseguir fazer a conversão e ele vai estourar um erro. ex: int.Parse("56b")

// //ToString()

// int inteiro = 90;
// string ab = inteiro.ToString();

// Console.WriteLine(ab);

// //casting implicito
// //quando um tipo cabe dentro do outro, ele faz a conversão implicita.

// int q = 5;
// double w = q ;
// //o inverso não pode acontecer
// //o int cabe dentro do double, então ele faz a conversão implicita.
// int yu = 10;
// long io = yu;
// //mesma coisa ai em cima.

// //o C# obdece a ordem da matemática, para resolução de problemas matemáticos. mesmo que eu não coloque os (), mas por se eu quiser aumentar a prioridade eu tenho que colocar.


// //conversão de maneira segura.

// string test = "16-";
// int teste = 10;

// int.TryParse(test, out teste);
// Console.WriteLine(teste);
// //se ele não conseguir fazer a conversão ele vai retornar 0;
// //posso criar uma nova variavel com isso.
// int.TryParse(test, out int c);

// Console.WriteLine(c);











// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"A quantidade em estoque é: {quantidadeEmEstoque}");
// Console.WriteLine($"A quantidade de compra é: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda ?  {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida!");
// }
// else if(possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Não há essa quantidade em estoque!");
// }













// Console.WriteLine("Digite uma letra: ");
// string ?letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;
//     default:
//     {
//         Console.WriteLine("Não é uma vogal");
//         break;
//     }
// }
// //reaparar que nesse código, eu digitei o Console.WriteLine(); no final dos meu cases, ou seja, ele vai passar por todas as verificações, porque ele o break somente no final do meu ultimo case.