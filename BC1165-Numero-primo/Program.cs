using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, N, X;
            string texto;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                texto = " eh primo";
                X = int.Parse(Console.ReadLine());

                for (j = 2; j < X && texto != " nao eh primo"; j++)
                {
                    if (X % j == 0)
                    {
                        texto = " nao eh primo";
                    }
                }

                Console.WriteLine(X + texto);

            }
        }
    }
}