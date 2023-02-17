using System;

Console.Write("Quantos elementos você quer?... ");
int elemento = Convert.ToInt32(Console.ReadLine());

List<int> numeros = new List<int>();
for (int i = 1; i <= elemento; i++)
{
    Console.Write("Qual é o primeiro elemento?... ");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));
}

numeros.Sort();

System.Console.WriteLine("--------------------------------------------------");

foreach (int numero in numeros)
{
    System.Console.WriteLine(numero);
}