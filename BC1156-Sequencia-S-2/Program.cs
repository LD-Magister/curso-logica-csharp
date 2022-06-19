using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            double i, S, div;

            S = 1.0;
            div = 2.0;

            for (i = 3.0; i <= 39.0; i = i + 2)
            {
                S = S + (i / div);
                div = div * 2.0;
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}