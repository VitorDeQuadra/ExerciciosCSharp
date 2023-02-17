using System;

public class Numeros
{

    public static void Main()
    {

        Console.Write("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite mais um numero: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("---------------------------------------------------------------------------");
        if (numero > (numero2 + numero3))
        {
            System.Console.WriteLine("O primeiro numero é maior que a soma dos outros 2");
        }
        if (numero == (numero2 + numero3))
        {
            System.Console.WriteLine("O primeiro número é igual a soma dos outros 2");
        }
        else
        {
            System.Console.WriteLine("O primeiro numero é menor que a soma dos outros 2");
        }

        System.Console.WriteLine("---------------------------------------------------------------------------");

        System.Console.WriteLine("O primeiro numero é: " + numero);
        System.Console.WriteLine("A soma dos outros 2 numeros é: " + (numero2 + numero3));
    }
}