using System;

int termo1 = 0;
int termo2 = 1;
int numeros = 0;

Console.Write("Digite um numero de sua preferência...");
int Fibonacci = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("--------------------------------------------------");
System.Console.WriteLine(termo1);
System.Console.WriteLine(termo2);
for(int i=0; i<=Fibonacci; i++)
{
    numeros=termo2;
    termo2+=termo1;
    termo1=numeros;
    System.Console.WriteLine(termo2);
}