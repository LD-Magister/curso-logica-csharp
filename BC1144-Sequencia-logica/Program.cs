using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                Console.WriteLine(i + " " + (Math.Pow(i, 2) + 1) + " " + (Math.Pow(i, 3) + 1));
            }
        }
    }
}