using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, x1, x2, x3;

            N = int.Parse(Console.ReadLine());
            x1 = 0;
            x2 = 1;
            x3 = 0;

            for (i = 0; i < N; i++)
            {
                if (i == N - 1)
                {
                    Console.WriteLine(x3);
                }
                else
                {
                    Console.Write(x3 + " ");

                    x1 = x2;
                    x2 = x3;
                    x3 = x2 + x1;
                }
            }
        }
    }
}