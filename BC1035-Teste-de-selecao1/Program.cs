using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] abcd;
            int a, b, c, d;

            abcd = Console.ReadLine().Split(' ');
            a = int.Parse(abcd[0]);
            b = int.Parse(abcd[1]);
            c = int.Parse(abcd[2]);
            d = int.Parse(abcd[3]);

            if (b > c && d > a && (c + d) > (a + b) && c >= 0 && d >= 0 && (a % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}