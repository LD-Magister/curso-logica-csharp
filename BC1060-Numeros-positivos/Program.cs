using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6;
            int pos;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pos = 0;

            if (n1 > 0)
            {
                pos = pos + 1;
            }
            if (n2 > 0)
            {
                pos = pos + 1;
            }
            if (n3 > 0)
            {
                pos = pos + 1;
            }
            if (n4 > 0)
            {
                pos = pos + 1;
            }
            if (n5 > 0)
            {
                pos = pos + 1;
            }
            if (n6 > 0)
            {
                pos = pos + 1;
            }

            Console.WriteLine(pos + " valores positivos");
        }
    }
}