using System;

int numero = new Random().Next(0, 100);
int numeroUsuario = 0;
int tentativas = 0;


while (numeroUsuario != numero)
{
    tentativas ++;

    Console.Write("Digite um numero... ");
    numeroUsuario = Convert.ToInt32(Console.ReadLine());

    if (numeroUsuario < numero)
    {
        System.Console.WriteLine("O numero gerado é maior");
    }
    else
    {
        System.Console.WriteLine("O numero gerado é menor");
    }
}
System.Console.WriteLine("--------------------------------------------------------------------------");
System.Console.WriteLine("Párabens, você acertou, utilizando "+ tentativas +" tentativas");