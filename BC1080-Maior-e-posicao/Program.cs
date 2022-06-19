using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, maior, entrada;

            maior = 0;
            entrada = 0;

            for (i = 1; i <= 100; i++)
            {
                N = int.Parse(Console.ReadLine());

                if (N > maior)
                {
                    maior = N;
                    entrada = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(entrada);
        }
    }
}