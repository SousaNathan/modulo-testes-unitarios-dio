using Calculadora.Services;

CalculadoraImplemantacao calculadora = new CalculadoraImplemantacao();

int num1 = 5;
int num2 = 10;

int resultado = calculadora.Somar(num1, num2);

Console.WriteLine($"{num1} + {num2} = {resultado}");