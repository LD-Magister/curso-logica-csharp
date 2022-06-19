using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, i, i2;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    i2 = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^" + "2 = " + i2);
                }
            }
        }
    }
}