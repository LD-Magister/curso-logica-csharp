using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] gols;
            int gremio, inter, empate, golsGremio, golsInter, repetir, cont;

            repetir = 1;
            empate = 0;
            gremio = 0;
            inter = 0;
            cont = 0;

            while (repetir == 1)
            {
                gols = Console.ReadLine().Split(' ');
                golsInter = int.Parse(gols[0]);
                golsGremio = int.Parse(gols[1]);


                if (golsGremio == golsInter)
                {
                    empate += 1;
                }
                else if (golsGremio > golsInter)
                {
                    gremio += 1;
                }
                else if (golsInter > golsGremio)
                {
                    inter += 1;
                }

                cont += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repetir = int.Parse(Console.ReadLine());

                while (repetir != 1 && repetir != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    repetir = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);
            if (gremio == inter)
            {
                Console.WriteLine("Nao houve vencedor");
            }
            else if (gremio > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
        }
    }
}