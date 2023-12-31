using Calculadora.services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"A soma de {num1} + {num2} = {c.Somar(num1, num2)}");