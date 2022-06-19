using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        string vendedor = (Console.ReadLine());
        double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salarioTotal = (totalVendas * 0.15 + salarioFixo);

        Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

    }
}