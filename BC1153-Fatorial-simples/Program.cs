using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, fat;

            N = int.Parse(Console.ReadLine());
            fat = N;

            for (i = 1; i < N; i++)
            {
                fat = fat * (N - i);
            }

            Console.WriteLine(fat);
        }
    }
}