using System;

Console.Write("Digite o ano de sua preferência...");
int ano = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("--------------------------------------------------");

if ((ano%400 == 0) || (ano%4 == 0))
{
    System.Console.WriteLine("Ano bissexto");
}else{
    System.Console.WriteLine("O ano não é bissexto");
}