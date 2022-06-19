using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i;
            double S;

            S = 1;

            for (i = 2; i <= 100; i++)
            {
                S = S + (1.0 / i);
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}