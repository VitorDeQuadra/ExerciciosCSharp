using System;

Random randNum = new Random();
List<int> numeros = new List<int>();
for (int i = 0; i < 20; i++)
{
     numeros.Add(randNum.Next(1000, 1999));
}



foreach (int numero in numeros)
{

    if (numero % 11 == 5)
    {
        System.Console.WriteLine(numero);
    }
}

