using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        int A = int.Parse(numeros[0]);
        int B = int.Parse(numeros[1]);
        int C = int.Parse(numeros[2]);

        int maiorAB = (A + B + Math.Abs(A - B)) / 2;
        int maiorABC = (C + maiorAB + Math.Abs(C - maiorAB)) / 2;

        Console.WriteLine(maiorABC + " eh o maior");
    }
}