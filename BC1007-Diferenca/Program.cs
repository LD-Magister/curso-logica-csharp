using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        int A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int diferenca = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + diferenca, CultureInfo.InvariantCulture);

    }
}