using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, quantidade, nota, resto;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            quantidade = resto / nota;
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;
        }
    }
}