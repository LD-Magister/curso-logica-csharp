using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] dados;
            int i, N, c, r, s, qtd, total;
            double percC, percR, percS;
            char tipo;

            c = 0;
            r = 0;
            s = 0;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                dados = Console.ReadLine().Split(' ');
                qtd = int.Parse(dados[0]);
                tipo = char.Parse(dados[1]);

                switch (tipo)
                {
                    case 'C':
                        c += qtd;
                        break;
                    case 'R':
                        r += qtd;
                        break;
                    case 'S':
                        s += qtd;
                        break;
                }
            }

            total = c + r + s;
            percC = (double)(c * 100.0 / total);
            percR = (double)(r * 100.0 / total);
            percS = (double)(s * 100.0 / total);

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + c);
            Console.WriteLine("Total de ratos: " + r);
            Console.WriteLine("Total de sapos: " + s);
            Console.WriteLine("Percentual de coelhos: " + percC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percS.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}