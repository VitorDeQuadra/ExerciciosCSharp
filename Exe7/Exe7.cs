using System;

Console.Write("Digite um numero de sua preferência...");
int numeroLegal = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("--------------------------------------------------");

for (int i = 1; i <= numeroLegal; i++)
{
    if (numeroLegal % i == 0)
    {
        System.Console.WriteLine(i);
    }
}