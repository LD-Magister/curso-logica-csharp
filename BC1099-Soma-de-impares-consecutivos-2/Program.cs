using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] xy;
            int i, j, N, soma, x, y, maior, menor;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                soma = 0;

                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);

                if (x > y)
                {
                    maior = x;
                    menor = y;
                }
                else
                {
                    maior = y;
                    menor = x;
                }

                for (j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}