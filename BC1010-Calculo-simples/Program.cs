using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        string[] peca1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(peca1[0]);
        int qtde1 = int.Parse(peca1[1]);
        double valorUnit1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

        string[] peca2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(peca2[0]);
        int qtde2 = int.Parse(peca2[1]);
        double valorUnit2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

        Console.WriteLine("VALOR A PAGAR: R$ " + (qtde1 * valorUnit1 + qtde2 * valorUnit2).ToString("F2", CultureInfo.InvariantCulture));

    }
}