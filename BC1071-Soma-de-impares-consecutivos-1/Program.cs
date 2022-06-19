using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int X, Y, maior, menor, i, soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            soma = 0;

            if (X > Y)
            {
                maior = X;
                menor = Y;
            }
            else
            {
                maior = Y;
                menor = X;
            }

            for (i = menor + 1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}