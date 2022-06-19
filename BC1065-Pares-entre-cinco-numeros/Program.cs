using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, pares;

            n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pares = 0;

            if (n1 % 2 == 0)
            {
                pares += 1;
            }
            if (n2 % 2 == 0)
            {
                pares += 1;
            }
            if (n3 % 2 == 0)
            {
                pares += 1;
            }
            if (n4 % 2 == 0)
            {
                pares += 1;
            }
            if (n5 % 2 == 0)
            {
                pares += 1;
            }
            Console.WriteLine(pares + " valores pares");
        }
    }
}

