using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] pop;
            int i, j, T, PA, PB;
            double PAd, PBd, G1, G2;

            T = int.Parse(Console.ReadLine());

            for (i = 0; i < T; i++)
            {
                pop = Console.ReadLine().Split(' ');
                PA = int.Parse(pop[0]);
                PB = int.Parse(pop[1]);
                G1 = double.Parse(pop[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(pop[3], CultureInfo.InvariantCulture);

                for (j = 0; PA <= PB && j <= 100; j++)
                {
                    PAd = PA;
                    PAd = (PAd + (PAd * (G1 / 100.0)));
                    PA = (int)PAd;

                    PBd = PB;
                    PBd = (PBd + (PBd * (G2 / 100.0)));
                    PB = (int)PBd;
                }

                if (j > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(j + " anos.");
                }
            }
        }
    }
}