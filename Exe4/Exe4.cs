using System;

Console.Write("Digite o primeiro Numero...");
double primeiroNumero = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo Numero...");
double segundoNumero = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("-------------------------------------------");

if (segundoNumero != 0)
{
    System.Console.WriteLine(primeiroNumero / segundoNumero);
}
else
{
    System.Console.WriteLine("Divisão por Zero");
}