using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] abc;
            double a, b, c, delta, r1, r2;

            abc = Console.ReadLine().Split(' ');
            a = double.Parse(abc[0], CultureInfo.InvariantCulture);
            b = double.Parse(abc[1], CultureInfo.InvariantCulture);
            c = double.Parse(abc[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - (4 * a * c);
            r1 = ((-b) + Math.Sqrt(delta)) / (2.0 * a);
            r2 = ((-b) - Math.Sqrt(delta)) / (2.0 * a);

            if (delta < 0.0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}