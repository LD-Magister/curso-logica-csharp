using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] xy;
            int i, N, x, y;
            double res;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    res = (double)x / y;
                    Console.WriteLine(res.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}