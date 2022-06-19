using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] mn;
            int i, soma, m, n, maior, menor;

            do
            {
                soma = 0;
                mn = Console.ReadLine().Split(' ');
                m = int.Parse(mn[0]);
                n = int.Parse(mn[1]);

                if (m > n)
                {
                    maior = m;
                    menor = n;
                }
                else
                {
                    maior = n;
                    menor = m;
                }

                if (maior > 0 && menor > 0)
                {
                    for (i = menor; i <= maior; i++)
                    {
                        Console.Write(i + " ");
                        soma += i;
                    }
                    Console.WriteLine("Sum=" + soma);
                }

            } while (m != 0 && n != 0);
        }
    }
}