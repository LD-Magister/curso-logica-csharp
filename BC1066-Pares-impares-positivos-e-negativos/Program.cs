using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, pares, impares, pos, negs;

            n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pares = 0;
            impares = 0;
            pos = 0;
            negs = 0;

            //PARES E IMPARES
            if (n1 % 2 == 0)
            {
                pares += 1;
            }
            else
            {
                impares += 1;
            }

            if (n2 % 2 == 0)
            {
                pares += 1;
            }
            else
            {
                impares += 1;
            }

            if (n3 % 2 == 0)
            {
                pares += 1;
            }
            else
            {
                impares += 1;
            }

            if (n4 % 2 == 0)
            {
                pares += 1;
            }
            else
            {
                impares += 1;
            }

            if (n5 % 2 == 0)
            {
                pares += 1;
            }
            else
            {
                impares += 1;
            }

            //POSITIVOS E NEGATIVOS
            if (n1 > 0)
            {
                pos += 1;
            }
            else if (n1 < 0)
            {
                negs += 1;
            }

            if (n2 > 0)
            {
                pos += 1;
            }
            else if (n2 < 0)
            {
                negs += 1;
            }

            if (n3 > 0)
            {
                pos += 1;
            }
            else if (n3 < 0)
            {
                negs += 1;
            }

            if (n4 > 0)
            {
                pos += 1;
            }
            else if (n4 < 0)
            {
                negs += 1;
            }

            if (n5 > 0)
            {
                pos += 1;
            }
            else if (n5 < 0)
            {
                negs += 1;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(negs + " valor(es) negativo(s)");
        }
    }
}