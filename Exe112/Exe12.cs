using System;


Console.Write("Quantas linhas você quer?... ");
int linhas = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantas colunas você quer?... ");
int colunas = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("-------------------------------------------------------------------");

if (linhas != colunas)
{
    System.Console.WriteLine("O numero de linhas ou colunas não corresponde.");
    return;
} 

/*while (true)
{
    if (linhas == colunas)
{
    System.Console.Write("1");
}
else
{
    System.Console.Write("0");
    System.Console.WriteLine();
}
}*/

for (int l = 1; l <= linhas; l++)
{
    for (int c = 1; c <= colunas ; c++)
    {
        if (l == c)
        {
            System.Console.Write(" 1 ");
        }else
        {
            System.Console.Write(" 0 ");
        }
    }
    System.Console.WriteLine();
}

