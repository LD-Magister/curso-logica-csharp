using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] XY;
            int i, j, N, X, Y, soma, cont;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                soma = 0;
                cont = 0;

                XY = Console.ReadLine().Split(' ');
                X = int.Parse(XY[0]);
                Y = int.Parse(XY[1]);

                for (j = X; cont < Y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                        cont++;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}