using System;

Console.Write("Qual é a Velocidade permitida na Avenida???---");
int velocidadeAvenida = Convert.ToInt32(Console.ReadLine());

if (velocidadeAvenida < 0)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("Velocidade permetida invalida");
    return;
}

Console.Write("Qual era a velocidade do motorista???---");
int velocidadeMotorista = Convert.ToInt32(Console.ReadLine());

if (velocidadeMotorista < 0)
{
    System.Console.WriteLine("-------------------------------------------");
    System.Console.WriteLine("Velocidade do motorista invalida");
    return;
}
System.Console.WriteLine("-------------------------------------------");

if (velocidadeMotorista > (velocidadeAvenida + 32))
{
    System.Console.WriteLine("Multa de 200 reias");
    return;
}

if (velocidadeMotorista > (velocidadeAvenida + 11))
{
    System.Console.WriteLine("Multa de 100 reias");
    return;

}
else
{
    System.Console.WriteLine("Motorista respeitou a velocidade permitida");
}