using System;
double nota4 = 0;

Console.Write("Digite a primeira nota... ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 0 || nota > 10)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("Nota invalida!");
    return;
}

Console.Write("Digite a segunda nota... ");
double nota2 = Convert.ToDouble(Console.ReadLine());

if (nota2 < 0 || nota2 > 10)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("Nota invalida!");
    return;
}
Console.Write("Digite a terceira nota... ");
double nota3 = Convert.ToDouble(Console.ReadLine());

if (nota3 < 0 || nota3 > 10)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("Nota invalida!");
    return;
}

System.Console.WriteLine("-------------------------------------------");

Console.Write("Digite o numero de faltas do aluno.. ");
int faltas = Convert.ToInt32(Console.ReadLine());

if (faltas < 0)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("numero de faltas é invalida!");
    return;
}

System.Console.WriteLine("-------------------------------------------");






if ((nota + nota2 + nota3) / 3 >= 7 && faltas < 7)
{
    System.Console.WriteLine("Aluno Aprovado");
    return;
}

if (faltas > 7)
{
    System.Console.WriteLine("Aluno Reprovado");
    return;
}

if ((nota + nota2 + nota3) / 3 >= 3 && (nota + nota2 + nota3) / 3 < 7)
{
    System.Console.WriteLine("Aluno em Recuperação");
    System.Console.WriteLine("-------------------------------------------");
    Console.Write("Digite a quarta nota... ");
    nota4 = Convert.ToDouble(Console.ReadLine());
}

System.Console.WriteLine("-------------------------------------------");

if ((nota + nota2 + nota3 + nota4) / 4 >= 5)
{
    System.Console.WriteLine("Aluno passou na recuperação...");
}
else
{
    System.Console.WriteLine("O aluno reprovou :(");
}